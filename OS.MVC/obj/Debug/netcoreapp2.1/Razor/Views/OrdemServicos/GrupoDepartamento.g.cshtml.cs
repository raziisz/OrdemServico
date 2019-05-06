#pragma checksum "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\GrupoDepartamento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c24d80bec4bbbf8c4b64ff82bb012a042e1cb250"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrdemServicos_GrupoDepartamento), @"mvc.1.0.view", @"/Views/OrdemServicos/GrupoDepartamento.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OrdemServicos/GrupoDepartamento.cshtml", typeof(AspNetCore.Views_OrdemServicos_GrupoDepartamento))]
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
#line 1 "C:\ProjetosCode\OS\OS.MVC\Views\_ViewImports.cshtml"
using OS;

#line default
#line hidden
#line 2 "C:\ProjetosCode\OS\OS.MVC\Views\_ViewImports.cshtml"
using OS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c24d80bec4bbbf8c4b64ff82bb012a042e1cb250", @"/Views/OrdemServicos/GrupoDepartamento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f4d766f0601744d93862fced26da5d02b291c21", @"/Views/_ViewImports.cshtml")]
    public class Views_OrdemServicos_GrupoDepartamento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IGrouping<OS.MVC.Models.Departamento, OS.MVC.Models.OrdemServico>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(87, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\GrupoDepartamento.cshtml"
  
    ViewData["Title"] = "Ordem de Serviços por Departamentos";
    DateTime minDate = DateTime.Parse(ViewData["minDate"] as string);
    DateTime maxDate = DateTime.Parse(ViewData["maxDate"] as string);

#line default
#line hidden
            BeginContext(302, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(309, 17, false);
#line 9 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\GrupoDepartamento.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(326, 90, true);
            WriteLiteral(" </h2>\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(416, 672, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f704a5b4999347ed9de9348edbbdfe15", async() => {
                BeginContext(468, 218, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Data mínima</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 686, "", 713, 1);
#line 17 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\GrupoDepartamento.cshtml"
WriteAttributeValue("", 693, ViewData["minDate"], 693, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(713, 207, true);
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Data maxima</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", "  value=", 920, "", 948, 1);
#line 21 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\GrupoDepartamento.cshtml"
WriteAttributeValue("", 928, ViewData["maxDate"], 928, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(948, 133, true);
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Filtrar</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1088, 24, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n\r\n");
            EndContext();
#line 29 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\GrupoDepartamento.cshtml"
 foreach (var departamentoGroup in Model)
{

#line default
#line hidden
            BeginContext(1158, 93, true);
            WriteLiteral("<div class=\"panel panel-primary\">\r\n    <div class=\"panel-heading\">\r\n        <h3>Departamento ");
            EndContext();
            BeginContext(1252, 31, false);
#line 33 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\GrupoDepartamento.cshtml"
                    Write(departamentoGroup.Key.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(1283, 605, true);
            WriteLiteral(@"</h3>
    </div>
    <table class=""table table-striped table-hover"">
        <thead>
            <tr class=""success"">
                <th>
                    Descrição
                </th>
                <th>
                    Tipo de Ordem
                </th>
                <th>
                    Status
                </th>
                <th>
                    Data Registrada
                </th>
                <th>
                    Funcionario responsavel
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 57 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\GrupoDepartamento.cshtml"
             foreach (var item in departamentoGroup)
            {

#line default
#line hidden
            BeginContext(1957, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2030, 44, false);
#line 61 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\GrupoDepartamento.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(2074, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2154, 44, false);
#line 64 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\GrupoDepartamento.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TipoOrdem));

#line default
#line hidden
            EndContext();
            BeginContext(2198, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2278, 41, false);
#line 67 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\GrupoDepartamento.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2319, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2399, 47, false);
#line 70 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\GrupoDepartamento.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DataRegistro));

#line default
#line hidden
            EndContext();
            BeginContext(2446, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2526, 51, false);
#line 73 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\GrupoDepartamento.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Funcionario.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(2577, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2656, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddaab76b5ace41ea8ee73358f1445548", async() => {
                BeginContext(2701, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\GrupoDepartamento.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2709, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2735, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab08c6df93704288a49d419f73ef00c0", async() => {
                BeginContext(2783, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\GrupoDepartamento.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2794, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2820, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70399d0ab0bf4373b3aaf3009120a10e", async() => {
                BeginContext(2867, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\GrupoDepartamento.cshtml"
                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2877, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 81 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\GrupoDepartamento.cshtml"
            }

#line default
#line hidden
            BeginContext(2944, 40, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            EndContext();
#line 85 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\GrupoDepartamento.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IGrouping<OS.MVC.Models.Departamento, OS.MVC.Models.OrdemServico>>> Html { get; private set; }
    }
}
#pragma warning restore 1591