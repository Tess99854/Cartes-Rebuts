#pragma checksum "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5481d8375dfb3ffe76262367ef2131354f34e363"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cartes_Index), @"mvc.1.0.view", @"/Views/Cartes/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\_ViewImports.cshtml"
using Cartes_Rebuts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\_ViewImports.cshtml"
using Cartes_Rebuts.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5481d8375dfb3ffe76262367ef2131354f34e363", @"/Views/Cartes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7035e24dbbb5ba895efbf82a3ac8a16811ada58", @"/Views/_ViewImports.cshtml")]
    public class Views_Cartes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CardModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right:1em"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cartes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addcard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row page-titles justify-content-between\">\r\n    <div class=\"col-md-5 align-self-center\">\r\n        <h2 class=\"text-themecolor\">Dashboard</h2>\r\n    </div>\r\n    <!-- date and search input -->\r\n    <!-- Search form -->\r\n \r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5481d8375dfb3ffe76262367ef2131354f34e3636401", async() => {
                WriteLiteral(@"
            <div class=""input-group"" style=""margin-right:5em"">
                <input type=""text"" class=""form-control"" placeholder=""Search"" id=""search"" style=""border-radius: 10px 0px 0px 10px"">
                <div class=""input-group-btn"">
                    <button class=""btn btn-default"" type=""submit"" style=""background-color: white; border: 1px solid #DEE2E6;
                            border-radius: 0px 10px 10px 0px; padding:0.8em"">
                        <i class=""fas fa-search""></i>
                    </button>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    \r\n   \r\n</div>\r\n\r\n");
            DefineSection("styles", async() => {
                WriteLiteral("\r\n  \r\n    th{\r\n        color: black; \r\n    }\r\n    \r\n");
            }
            );
            WriteLiteral(@"
<div class=""row"">
    <!-- column -->
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex"">
                    <div>
                        <h5 class=""card-title"">Table de base</h5>
                        <h6 class=""card-subtitle"">Défiler vers la droite pour voir le reste du tableau</h6>
                    </div>
                    <div class=""ml-auto"">
                        <!--add rebut-->
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5481d8375dfb3ffe76262367ef2131354f34e3639092", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5481d8375dfb3ffe76262367ef2131354f34e3639380", async() => {
                    WriteLiteral("\r\n                                Ajouter Rebut\r\n                                <i style=\" color:rgba(0,130,255,1); margin-left:1em\" class=\"fas fa-plus-square\"></i>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""table-responsive"">
                <table class=""table table-hover"">
                    <thead>
                        <tr>

                            <th class=""text-center"">#</th>
                            <th>DATE</th>
                            <th>Equipe</th>
                            <th>Atelier</th>
                            <th>Ligne</th>
                            <th>Référence</th>
                            <th>Designation</th>
                            <th>Repere Topo</th>
                            <th>Type du défaut</th>
                            <th>Source</th>
                            <th>Cause défaut</th>
                            <th>Action/Commentaire</th>
                            <th>Répartition</th>
                            <th>Machine</th>
                            <th>Qte</th>
                            <th>PMP</th>
                      ");
            WriteLiteral(@"      <th>Valeur</th>
                            <th>Responsable</th>
                            <th>Etat de la Carte</th>
                            <th>Operateur</th>
                            <th>Produit</th>
                            <th>N° de cde</th>
                        </tr>
                    </thead>
                    <tbody>

");
#nullable restore
#line 88 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                         foreach (CardModel card in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"text-center\">");
#nullable restore
#line 91 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                                                   Write(card.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-oflo\">");
#nullable restore
#line 92 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                                                Write(card.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-oflo\">");
#nullable restore
#line 93 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                                                Write(card.Equipe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-oflo\">");
#nullable restore
#line 94 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                                                Write(card.Atelier);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-oflo\">");
#nullable restore
#line 95 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                                                Write(card.Ligne);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-oflo\">");
#nullable restore
#line 96 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                                                Write(card.Reference);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-oflo\">");
#nullable restore
#line 97 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                                                Write(card.Designation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-oflo\">");
#nullable restore
#line 98 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                                                Write(card.RepereTopo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-oflo\">");
#nullable restore
#line 99 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                                                Write(card.TypeDefaut);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-oflo\">");
#nullable restore
#line 100 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                                                Write(card.Source);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-oflo\">");
#nullable restore
#line 101 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                                                Write(card.CauseDefaut);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-oflo\">");
#nullable restore
#line 102 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                                                Write(card.ActionComm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-oflo\">");
#nullable restore
#line 103 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                                                Write(card.Repartition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-oflo\">");
#nullable restore
#line 104 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                                                Write(card.Machine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-oflo\">");
#nullable restore
#line 105 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                                                Write(card.Qte);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-oflo\">");
#nullable restore
#line 106 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                                                Write(card.PMP);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-oflo\">");
#nullable restore
#line 107 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                                                Write(card.Valeur);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-oflo\">");
#nullable restore
#line 108 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                                                Write(card.Responsable);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-oflo\">");
#nullable restore
#line 109 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                                                Write(card.EtatCarte);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-oflo\">");
#nullable restore
#line 110 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                                                Write(card.Operateur);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-oflo\">");
#nullable restore
#line 111 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                                                Write(card.Produit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"txt-oflo\">");
#nullable restore
#line 112 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                                                Write(card.NumSerie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 116 "C:\Users\Lenovo\source\repos\Cartes-Rebuts\Cartes-RebutsSolution\Cartes-Rebuts\Views\Cartes\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
    <script>
        $(""input#search"").keyup(function () {
            var input = $(this);
            $('tbody tr').each(function () {
                if ($(this).text().toLowerCase().indexOf(input.val().toLowerCase()) > -1) {

                    $(this).show();


                } else {
                    $(this).hide();
                }
            })
        })
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CardModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
