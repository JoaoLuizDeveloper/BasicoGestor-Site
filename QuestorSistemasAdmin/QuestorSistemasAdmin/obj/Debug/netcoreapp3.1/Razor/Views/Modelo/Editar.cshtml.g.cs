#pragma checksum "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5f7064ce02fe56b16d5f293da453b62bf7505b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Modelo_Editar), @"mvc.1.0.view", @"/Views/Modelo/Editar.cshtml")]
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
#line 1 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml"
using QuestorSistemasAdmin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5f7064ce02fe56b16d5f293da453b62bf7505b0", @"/Views/Modelo/Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e287e82abf8b3d39cd943b3451445c548dd8de", @"/Views/_ViewImports.cshtml")]
    public class Views_Modelo_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Modelo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml"
  
    ViewData["Title"] = "Editar Modelo";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""wrapper"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <section class=""panel"">
                <header class=""panel-heading"">
                    Editar Modelo
                    <span class=""tools pull-right"">
                        <a class=""fa fa-chevron-down"" href=""javascript:;""></a>
                        <a class=""fa fa-times"" href=""javascript:;""></a>
                    </span>
                </header>
                <div class=""panel-body"">
                    <div class=""form"">
");
#nullable restore
#line 20 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml"
                         using (Html.BeginForm("Editar", "Modelo", FormMethod.Post, new { role = "form", enctype = "multipart/form-data", @class = "form-horizontal" }))
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml"
                       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml"
                       Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"form-group\">\r\n                                <div class=\"col-sm-12\">\r\n                                    <br />\r\n                                    ");
#nullable restore
#line 27 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml"
                               Write(Html.LabelFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 28 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml"
                               Write(Html.TextAreaFor(model => model.Nome, new { @class = "form-control ckeditor", Maxlength = "100", rows = "6" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 29 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    <br />\r\n                                    <button type=\"submit\" class=\"btn btn-primary\">Enviar</button>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 35 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </section>
        </div>
    </div>
</div>

<script type=""text/javascript"" src=""/js/ckeditor/ckeditor.js""></script>
<script type=""text/javascript"" src=""/js/bootstrap-wysihtml5/wysihtml5-0.3.0.js""></script>
<script type=""text/javascript"" src=""/js/bootstrap-wysihtml5/bootstrap-wysihtml5.js""></script>
<script>
    jQuery(document).ready(function () {
        $('.wysihtml5').wysihtml5();
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Modelo> Html { get; private set; }
    }
}
#pragma warning restore 1591
