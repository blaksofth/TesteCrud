#pragma checksum "C:\Users\blak\TesteCrud\CrudTeste\CrudTeste\Views\Alunos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17cd59f92d1d24614622f798c9738eb722808ab3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alunos_Index), @"mvc.1.0.view", @"/Views/Alunos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Alunos/Index.cshtml", typeof(AspNetCore.Views_Alunos_Index))]
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
#line 1 "C:\Users\blak\TesteCrud\CrudTeste\CrudTeste\Views\_ViewImports.cshtml"
using CrudTeste.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17cd59f92d1d24614622f798c9738eb722808ab3", @"/Views/Alunos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a167157bf15b83e2e05c4d375a0a0192b08989fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Alunos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Alunos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateAluno", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ImportarAlunos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditAluno", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApagarAluno", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\blak\TesteCrud\CrudTeste\CrudTeste\Views\Alunos\Index.cshtml"
  
    Layout = "_Layout";
    var title = "Lista de Alunos";
    ViewData["Title"] = title;

#line default
#line hidden
            BeginContext(130, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(137, 5, false);
#line 9 "C:\Users\blak\TesteCrud\CrudTeste\CrudTeste\Views\Alunos\Index.cshtml"
Write(title);

#line default
#line hidden
            EndContext();
            BeginContext(142, 17, true);
            WriteLiteral("</h2>\r\n<h3>\r\n    ");
            EndContext();
            BeginContext(159, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffaae965754640e891e28f5e7dd0bcca", async() => {
                BeginContext(220, 4, true);
                WriteLiteral("Novo");
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
            BeginContext(228, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 12 "C:\Users\blak\TesteCrud\CrudTeste\CrudTeste\Views\Alunos\Index.cshtml"
     if (DateTime.Now > CrudTeste.Controllers.AlunosController.bloqueio)
    {

#line default
#line hidden
            BeginContext(311, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(319, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ff066ab246646fcbd3de9ab5e6d4b22", async() => {
                BeginContext(383, 8, true);
                WriteLiteral("Importar");
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
            BeginContext(395, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "C:\Users\blak\TesteCrud\CrudTeste\CrudTeste\Views\Alunos\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(404, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(408, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0f25cc4eb964d4c9a1c2fbe37f471fb", async() => {
                BeginContext(466, 6, true);
                WriteLiteral("Voltar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
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
            BeginContext(476, 153, true);
            WriteLiteral("\r\n</h3>\r\n\r\n<table class=\"table table-bordered table-sm table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th colspan=\"6\">\r\n                &nbsp;\r\n");
            EndContext();
#line 24 "C:\Users\blak\TesteCrud\CrudTeste\CrudTeste\Views\Alunos\Index.cshtml"
                 if(Model != null) 
                {
                    

#line default
#line hidden
#line 26 "C:\Users\blak\TesteCrud\CrudTeste\CrudTeste\Views\Alunos\Index.cshtml"
                     if(Model.Count() > 0)
                    {
                        

#line default
#line hidden
            BeginContext(777, 27, false);
#line 28 "C:\Users\blak\TesteCrud\CrudTeste\CrudTeste\Views\Alunos\Index.cshtml"
                   Write(Model.First().nomeprofessor);

#line default
#line hidden
            EndContext();
#line 28 "C:\Users\blak\TesteCrud\CrudTeste\CrudTeste\Views\Alunos\Index.cshtml"
                                                    
                    }

#line default
#line hidden
#line 29 "C:\Users\blak\TesteCrud\CrudTeste\CrudTeste\Views\Alunos\Index.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(848, 267, true);
            WriteLiteral(@"            </th>
        </tr>
        <tr>
            <th>id</th>
            <th>Nome</th>
            <th>Mensalidade</th>
            <th>Vencimento</th>
            <th>Editar</th>
            <th>Apagar</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 43 "C:\Users\blak\TesteCrud\CrudTeste\CrudTeste\Views\Alunos\Index.cshtml"
         if (Model == null)
        {

#line default
#line hidden
            BeginContext(1155, 109, true);
            WriteLiteral("            <tr>\r\n                <td colspan=\"7\" class=\"text-center\">No Model Data</td>\r\n            </tr>\r\n");
            EndContext();
#line 48 "C:\Users\blak\TesteCrud\CrudTeste\CrudTeste\Views\Alunos\Index.cshtml"
        }
        else
        {
            

#line default
#line hidden
#line 51 "C:\Users\blak\TesteCrud\CrudTeste\CrudTeste\Views\Alunos\Index.cshtml"
             foreach (var p in Model)
            {

#line default
#line hidden
            BeginContext(1354, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1393, 4, false);
#line 54 "C:\Users\blak\TesteCrud\CrudTeste\CrudTeste\Views\Alunos\Index.cshtml"
               Write(p.id);

#line default
#line hidden
            EndContext();
            BeginContext(1397, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1425, 6, false);
#line 55 "C:\Users\blak\TesteCrud\CrudTeste\CrudTeste\Views\Alunos\Index.cshtml"
               Write(p.nome);

#line default
#line hidden
            EndContext();
            BeginContext(1431, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1459, 13, false);
#line 56 "C:\Users\blak\TesteCrud\CrudTeste\CrudTeste\Views\Alunos\Index.cshtml"
               Write(p.mensalidade);

#line default
#line hidden
            EndContext();
            BeginContext(1472, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1500, 12, false);
#line 57 "C:\Users\blak\TesteCrud\CrudTeste\CrudTeste\Views\Alunos\Index.cshtml"
               Write(p.vencimento);

#line default
#line hidden
            EndContext();
            BeginContext(1512, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1539, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9de2aa2209964cab9695cdc9b71a1b5e", async() => {
                BeginContext(1586, 6, true);
                WriteLiteral("Editar");
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
#line 58 "C:\Users\blak\TesteCrud\CrudTeste\CrudTeste\Views\Alunos\Index.cshtml"
                                                WriteLiteral(p.id);

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
            BeginContext(1596, 49, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1645, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a89d27a3ff3445480c8fb937f39b0b4", async() => {
                BeginContext(1711, 71, true);
                WriteLiteral("\r\n                        <button>Apagar</button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\blak\TesteCrud\CrudTeste\CrudTeste\Views\Alunos\Index.cshtml"
                                                                   WriteLiteral(p.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1789, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 65 "C:\Users\blak\TesteCrud\CrudTeste\CrudTeste\Views\Alunos\Index.cshtml"
            }

#line default
#line hidden
#line 65 "C:\Users\blak\TesteCrud\CrudTeste\CrudTeste\Views\Alunos\Index.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1859, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Alunos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
