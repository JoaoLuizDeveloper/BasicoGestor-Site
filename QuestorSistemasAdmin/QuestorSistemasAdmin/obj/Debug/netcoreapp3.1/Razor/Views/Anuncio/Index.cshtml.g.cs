#pragma checksum "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "244b848b1fa44aff6d2396b31c4c4d1d41ce4114"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anuncio_Index), @"mvc.1.0.view", @"/Views/Anuncio/Index.cshtml")]
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
#line 1 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\_ViewImports.cshtml"
using QuestorSistemasAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Index.cshtml"
using QuestorSistemasAdmin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"244b848b1fa44aff6d2396b31c4c4d1d41ce4114", @"/Views/Anuncio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e287e82abf8b3d39cd943b3451445c548dd8de", @"/Views/_ViewImports.cshtml")]
    public class Views_Anuncio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Anuncio>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Index.cshtml"
  
    ViewData["Title"] = "Anuncios";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"wrapper\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12\">\r\n            <section class=\"panel\">\r\n                <header class=\"panel-heading\">\r\n                    Listagem de Anuncios (");
#nullable restore
#line 11 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Index.cshtml"
                                     Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")
                    <span class=""tools pull-right"">
                        <a href=""javascript:;"" class=""fa fa-chevron-down""></a>
                        <a href=""javascript:;"" class=""fa fa-times""></a>
                    </span>
                </header>
                <div class=""panel-body"">
                    <div class=""adv-table editable-table "">
                        <div class=""clearfix"">
                            <div class=""btn-group"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 824, "\"", 863, 1);
#nullable restore
#line 21 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Index.cshtml"
WriteAttributeValue("", 831, Url.Action("Create", "Anuncio"), 831, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    <button id=""editable-sample_new"" class=""btn btn-primary"">
                                        Cadastrar <i class=""fa fa-plus""></i>
                                    </button>
                                </a>
                            </div>

                            <div class=""btn-group"" style=""margin-left: 20%"">
");
#nullable restore
#line 29 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Index.cshtml"
                                 using (Html.BeginForm("Index", "Anuncio", method: FormMethod.Get))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"datepicker\">\r\n                                        <label for=\"De\">De</label>\r\n                                        <input type=\"date\" class=\"input\" name=\"Inicial\" id=\"De\" min=\"01/01/2020\"");
            BeginWriteAttribute("value", " value=\"", 1619, "\"", 1643, 1);
#nullable restore
#line 33 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Index.cshtml"
WriteAttributeValue("", 1627, ViewBag.Inicial, 1627, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        \r\n                                        <label for=\"Ate\">Até</label>\r\n                                        <input type=\"date\" class=\"input\" name=\"Final\" id=\"Ate\" min=\"01/01/2020\"");
            BeginWriteAttribute("value", " value=\"", 1870, "\"", 1892, 1);
#nullable restore
#line 36 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Index.cshtml"
WriteAttributeValue("", 1878, ViewBag.Final, 1878, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                                        <button class=\"btn btn-dark fa fa-search\" style=\"margin-left: 5px;\"> Pesquisar</button>\r\n                                    </div>\r\n");
#nullable restore
#line 40 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>

                            <div class=""btn-group pull-right"">
                                <button class=""btn btn-default dropdown-toggle"" data-toggle=""dropdown"">
                                    Relatorios <i class=""fa fa-angle-down""></i>
                                </button>
                                <ul class=""dropdown-menu pull-right"">
                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2550, "\"", 2643, 1);
#nullable restore
#line 48 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Index.cshtml"
WriteAttributeValue("", 2557, Url.Action("Print","Anuncio", new { Inicial= ViewBag.Inicial, Final = ViewBag.Final}), 2557, 86, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Imprimir</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2722, "\"", 2813, 1);
#nullable restore
#line 49 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Index.cshtml"
WriteAttributeValue("", 2729, Url.Action("Pdf","Anuncio", new { Inicial= ViewBag.Inicial, Final = ViewBag.Final}), 2729, 84, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"">Relatorio PDF</a></li>
                                </ul>
                            </div>
                            </div>
                        <br />
                        <div class=""space15""></div>
                        <table class=""table table-striped table-hover table-bordered"" id=""editable-sample"">
                            <thead>
                                <tr>
                                    <th>Marca</th>
                                    <th>Valor Venda</th>
                                    <th>Cor</th>
                                    <th>Data</th>
                                    <th>Detalhes</th>
                                    <th>Editar</th>
                                    <th>Deletar</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 68 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Index.cshtml"
                                 if (Model != null && Model.Count() > 0)
                                {
                                    foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr");
            BeginWriteAttribute("class", " class=\"", 3978, "\"", 3986, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <td>");
#nullable restore
#line 73 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Index.cshtml"
                                           Write(item.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 74 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Index.cshtml"
                                           Write(item.ValorVenda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 75 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Index.cshtml"
                                           Write(item.Cor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 76 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Index.cshtml"
                                           Write(item.DataVenda.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td><a");
            BeginWriteAttribute("href", " href=\"", 4334, "\"", 4401, 1);
#nullable restore
#line 77 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Index.cshtml"
WriteAttributeValue("", 4341, Url.Action("Detalhes", "Anuncio", new { Slug = item.Slug }), 4341, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detalhes</a></td>\r\n                                            <td><a class=\"edit\"");
            BeginWriteAttribute("href", " href=\"", 4485, "\"", 4549, 1);
#nullable restore
#line 78 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Index.cshtml"
WriteAttributeValue("", 4492, Url.Action("Editar", "Anuncio", new { Slug = item.Slug}), 4492, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                                            <td><a class=\"delete\"");
            BeginWriteAttribute("href", " href=\"", 4633, "\"", 4694, 1);
#nullable restore
#line 79 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Index.cshtml"
WriteAttributeValue("", 4640, Url.Action("Excluir", "Anuncio", new { id = item.Id}), 4640, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Deletar</a></td>\r\n                                        </tr>\r\n");
#nullable restore
#line 81 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Index.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </section>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Anuncio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
