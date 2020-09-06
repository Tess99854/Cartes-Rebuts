using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartes_Rebuts.Models
{
    public class CardModel
    {
        public long Id { get; set; }
        public string Designation { get; set; }
        public string Date { get; set; }
        public string Atelier { get; set; }
        public string Equipe { get; set; }
        public long Reference { get; set; }
        public string Ligne { get; set; }
        public string RepereTopo { get; set; }
        public string TypeDefaut { get; set; }
        public string Source { get; set; }
        public string CauseDefaut { get; set; }
        public string Repartition { get; set; }
        public string ActionComm { get; set; }
        public string Machine { get; set; }
        public string Responsable { get; set; }
        public string EtatCarte { get; set; }
        public string Produit { get; set; }
        public string Operateur { get; set; }
        public double PMP { get; set; }
        public double Valeur { get; set; }
        public int Qte { get; set; }
        public string NumSerie { get; set; }







    }
}
