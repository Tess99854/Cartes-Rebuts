using Cartes_Rebuts.Models;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using OfficeOpenXml;


namespace Cartes_Rebuts.Repository
{
    public class CardRepository
    {
        private string sourceFile = $"{Directory.GetCurrentDirectory()}{@"\wwwroot\files"}" + "\\testSheet.xlsx";

        public List<CardModel> getAllCards()
        {
            return DataSource(); 
        }

        public void addCard(CardModel Card, int line)
        {
            var fi = new FileInfo(sourceFile);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var p = new ExcelPackage(fi))
            {
                //Get the Worksheet created in the previous codesample. 
                var ws = p.Workbook.Worksheets["Feuil1"];
                line += 2; 

                ws.Cells[line, 1].Value = DateTime.Today.ToString();
                ws.Cells[line, 2].Value = Card.Atelier;
                ws.Cells[line, 3].Value = Card.Equipe;
                ws.Cells[line, 4].Value = Card.Ligne;
                ws.Cells[line, 5].Value = Card.Source ;
                ws.Cells[line, 6].Value = Card.Reference;
                ws.Cells[line, 7].Value = Card.Designation;
                ws.Cells[line, 8].Value = Card.RepereTopo == null ? " - ": Card.RepereTopo;
                ws.Cells[line, 9].Value = Card.TypeDefaut;
                ws.Cells[line, 10].Value = Card.CauseDefaut;
                ws.Cells[line, 11].Value = Card.ActionComm == null ? " - " : Card.ActionComm;
                ws.Cells[line, 12].Value = Card.Repartition;
                ws.Cells[line, 13].Value = Card.Machine == null ? " - " : Card.Machine;
                ws.Cells[line, 14].Value = Card.Responsable == null ? " - " : Card.Responsable;
                ws.Cells[line, 15].Value = Card.Qte;
                ws.Cells[line, 16].Value = Card.PMP;
                ws.Cells[line, 17].Value = Card.Valeur ;
                ws.Cells[line, 18].Value = Card.EtatCarte == null ? " - " : Card.EtatCarte;
                ws.Cells[line, 19].Value = Card.Operateur == null ? " - " : Card.Operateur;
                ws.Cells[line, 20].Value = Card.Produit == null ? " - " : Card.Produit;
                ws.Cells[line, 21].Value = Card.NumSerie == null ? " - " : Card.NumSerie;



                p.Save();
            }
        }

        public string getDesign(int refe)
        {
            string des = "Error";
            var fi = new FileInfo(sourceFile);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            
            using (var p = new ExcelPackage(fi))
            {
                var ws = p.Workbook.Worksheets["Feuil2"];

                for (int i = ws.Dimension.Start.Row + 1; i <= ws.Dimension.End.Row; i++)
                {

                    int Val = Int32.Parse(ws.Cells[i, 1].Value.ToString());
                   

                    if (Val == refe)
                    {
                       
                        return ws.Cells[i, 2].Value.ToString();
                    }

                }
            }

            return des; 
        }
        public int getCountCards()
        {

            using (var stream = System.IO.File.Open(sourceFile, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    return reader.RowCount - 1 ; 
                }
            }
        }

        private List<CardModel> DataSource()
        {
            List<CardModel> Cards = new List<CardModel>();



            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = System.IO.File.Open(sourceFile, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    int i = 0;
                    var oo = reader.Read(); 
                    while (reader.Read())
                    {
                       
                        Cards.Add(new CardModel()
                        {
                            Id = ++i,
                            Date = reader.GetValue(0).ToString() ,
                            Atelier = reader.GetValue(1).ToString(),
                            Equipe = reader.GetValue(2).ToString(),
                            Ligne = reader.GetValue(3).ToString(),
                            Source = reader.GetValue(4).ToString(),
                            Reference = Int32.Parse(reader.GetValue(5).ToString()) ,
                            Designation = reader.GetValue(6).ToString(),
                            RepereTopo = reader.GetValue(7).ToString(),
                            TypeDefaut = reader.GetValue(8).ToString(),
                            CauseDefaut = reader.GetValue(9).ToString(),
                            ActionComm = reader.GetValue(10).ToString(),
                            Repartition = reader.GetValue(11).ToString(),
                            Machine = reader.GetValue(12).ToString(),
                            Responsable = reader.GetValue(13).ToString(),
                            Qte = Int32.Parse(reader.GetValue(14).ToString()),
                            PMP = Double.Parse(reader.GetValue(15).ToString()),
                            Valeur = Double.Parse(reader.GetValue(16).ToString()),
                            EtatCarte = reader.GetValue(17).ToString(),
                            Operateur = reader.GetValue(18).ToString(),
                            Produit = reader.GetValue(19).ToString(),
                            NumSerie = reader.GetValue(20).ToString(),




                        }) ;
                    }
                }
            }
            return Cards; 
        }


    }
}
