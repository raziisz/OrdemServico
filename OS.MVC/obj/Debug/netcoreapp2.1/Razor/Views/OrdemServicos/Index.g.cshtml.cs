#pragma checksum "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39f1140e752a268e98e9e6140dd730785f3ae13f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrdemServicos_Index), @"mvc.1.0.view", @"/Views/OrdemServicos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OrdemServicos/Index.cshtml", typeof(AspNetCore.Views_OrdemServicos_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39f1140e752a268e98e9e6140dd730785f3ae13f", @"/Views/OrdemServicos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f4d766f0601744d93862fced26da5d02b291c21", @"/Views/_ViewImports.cshtml")]
    public class Views_OrdemServicos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OS.MVC.Models.OrdemServico>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PesquisarDatas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GrupoDepartamento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cancelar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cancelar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
  
    ViewData["Title"] = "Ordem de Serviços";

#line default
#line hidden
            BeginContext(103, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(110, 17, false);
#line 7 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(127, 19, true);
            WriteLiteral(" </h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(146, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df4915d541a54e369b315ef3d48789a1", async() => {
                BeginContext(193, 22, true);
                WriteLiteral("Criar uma nova chamada");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(219, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(225, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1266ff34e30d4a238dc4f7189aa8c3f9", async() => {
                BeginContext(280, 25, true);
                WriteLiteral("Gerar Relatórios por data");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(309, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(315, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3f9b74d6189444c9f3e2228aae6ce97", async() => {
                BeginContext(373, 33, true);
                WriteLiteral("Gerar Relatórios por departamento");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(410, 299, true);
            WriteLiteral(@"
</p>

<div class=""panel panel-default"">
    <div class=""panel-heading text-center"">
        <h4>Ordens de serviços pendentes</h4>
    </div>


    <table class=""table table-striped table-hover"">
        <thead>
            <tr class=""success"">
                <th>
                    ");
            EndContext();
            BeginContext(710, 45, false);
#line 25 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(755, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(823, 45, false);
#line 28 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.TipoOrdem));

#line default
#line hidden
            EndContext();
            BeginContext(868, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(936, 42, false);
#line 31 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(978, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1046, 48, false);
#line 34 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DataRegistro));

#line default
#line hidden
            EndContext();
            BeginContext(1094, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1162, 47, false);
#line 37 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Funcionario));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 118, true);
            WriteLiteral(" responsavel\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 43 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
             foreach (var item in Model)
            {
                

#line default
#line hidden
#line 45 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
                 if (item.Status.ToString() == "EmExecucao" ||
                 item.Status.ToString() == "Pausado" || item.Status.ToString() == "Iniciado")
                {

#line default
#line hidden
            BeginContext(1562, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1647, 44, false);
#line 50 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1691, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1783, 44, false);
#line 53 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TipoOrdem));

#line default
#line hidden
            EndContext();
            BeginContext(1827, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 55 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
                         if (item.Status.ToString() == "EmExecucao")
                        {

#line default
#line hidden
            BeginContext(1957, 120, true);
            WriteLiteral("                            <td class=\"active text-center\" style=\"padding-top: 20px;\">\r\n                                ");
            EndContext();
            BeginContext(2078, 41, false);
#line 58 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2119, 37, true);
            WriteLiteral("\r\n                            </td>\r\n");
            EndContext();
#line 60 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
                        } else if (item.Status.ToString() == "Pausado")
                        {

#line default
#line hidden
            BeginContext(2256, 121, true);
            WriteLiteral("                            <td class=\"warning text-center\" style=\"padding-top: 20px;\">\r\n                                ");
            EndContext();
            BeginContext(2378, 41, false);
#line 63 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2419, 37, true);
            WriteLiteral("\r\n                            </td>\r\n");
            EndContext();
#line 65 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
                        } else if (item.Status.ToString() == "Iniciado")
                        {

#line default
#line hidden
            BeginContext(2557, 118, true);
            WriteLiteral("                            <td class=\"info text-center\" style=\"padding-top: 20px;\">\r\n                                ");
            EndContext();
            BeginContext(2676, 41, false);
#line 68 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2717, 37, true);
            WriteLiteral("\r\n                            </td>\r\n");
            EndContext();
#line 70 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2781, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(2840, 47, false);
#line 72 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DataRegistro));

#line default
#line hidden
            EndContext();
            BeginContext(2887, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2979, 51, false);
#line 75 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Funcionario.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(3030, 109, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"btn-group\">\r\n                            ");
            EndContext();
            BeginContext(3139, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df5b350f1f844909aec914295caf0a65", async() => {
                BeginContext(3208, 9, true);
                WriteLiteral("Finalizar");
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
#line 78 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3221, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3251, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "278ab5a74a33433296d9c33264875e15", async() => {
                BeginContext(3337, 8, true);
                WriteLiteral("Cancelar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 79 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
                                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3349, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 82 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
                }

#line default
#line hidden
#line 82 "C:\ProjetosCode\OS\OS.MVC\Views\OrdemServicos\Index.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(3443, 42, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OS.MVC.Models.OrdemServico>> Html { get; private set; }
    }
}
#pragma warning restore 1591
