#pragma checksum "E:\.net\Fiap.Aula02.Web\Fiap.Aula02.Web\Views\Usuario\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "043495ad94f6d7df27a43538f1f046c8b2ae97be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Cadastrar), @"mvc.1.0.view", @"/Views/Usuario/Cadastrar.cshtml")]
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
#line 1 "E:\.net\Fiap.Aula02.Web\Fiap.Aula02.Web\Views\_ViewImports.cshtml"
using Fiap.Aula02.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\.net\Fiap.Aula02.Web\Fiap.Aula02.Web\Views\_ViewImports.cshtml"
using Fiap.Aula02.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"043495ad94f6d7df27a43538f1f046c8b2ae97be", @"/Views/Usuario/Cadastrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6899319d03165b68675dee522edc453b156c0cce", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/usuario/cadastrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\.net\Fiap.Aula02.Web\Fiap.Aula02.Web\Views\Usuario\Cadastrar.cshtml"
  
    ViewData["Title"] = "Cadastrar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Cadastrar</h1>\r\n\r\n");
#nullable restore
#line 10 "E:\.net\Fiap.Aula02.Web\Fiap.Aula02.Web\Views\Usuario\Cadastrar.cshtml"
 if (Model != null)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        ");
#nullable restore
#line 14 "E:\.net\Fiap.Aula02.Web\Fiap.Aula02.Web\Views\Usuario\Cadastrar.cshtml"
   Write(ViewData["msg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 15 "E:\.net\Fiap.Aula02.Web\Fiap.Aula02.Web\Views\Usuario\Cadastrar.cshtml"
   Write(TempData["msg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        ");
#nullable restore
#line 17 "E:\.net\Fiap.Aula02.Web\Fiap.Aula02.Web\Views\Usuario\Cadastrar.cshtml"
   Write(ViewBag.user.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 17 "E:\.net\Fiap.Aula02.Web\Fiap.Aula02.Web\Views\Usuario\Cadastrar.cshtml"
                       Write(ViewBag.user.DataNascimento);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 17 "E:\.net\Fiap.Aula02.Web\Fiap.Aula02.Web\Views\Usuario\Cadastrar.cshtml"
                                                     Write(ViewBag.user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        ");
#nullable restore
#line 19 "E:\.net\Fiap.Aula02.Web\Fiap.Aula02.Web\Views\Usuario\Cadastrar.cshtml"
   Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 19 "E:\.net\Fiap.Aula02.Web\Fiap.Aula02.Web\Views\Usuario\Cadastrar.cshtml"
                Write(Model.DataNascimento.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 19 "E:\.net\Fiap.Aula02.Web\Fiap.Aula02.Web\Views\Usuario\Cadastrar.cshtml"
                                                           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 21 "E:\.net\Fiap.Aula02.Web\Fiap.Aula02.Web\Views\Usuario\Cadastrar.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "043495ad94f6d7df27a43538f1f046c8b2ae97be6499", async() => {
                WriteLiteral(@"
    <div class=""form=group"" >
        <label>Nome</label>
        <input type=""text"" name=""nome"" class=""form-control"" />
    </div>
    <div class=""form-group"">
        <label>Data Nascimento</label>
        <input type=""date"" name=""dataNascimento"" class=""form-control"" />

    </div>
    <div class=""form-group"">
        <label>Email</label>
        <input type=""text"" name=""email"" class=""form-control"" />
    </div>
    <input type=""submit"" value=""Cadastrar"" class=""btn btn-outline-primary"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591