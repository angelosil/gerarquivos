#pragma checksum "C:\arquivos\servicos\gerarquivos\gerArquivos\Views\Arquivo\AddArquivo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abf947aee17c68e05049808085c2de48b5d9114c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Arquivo_AddArquivo), @"mvc.1.0.view", @"/Views/Arquivo/AddArquivo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Arquivo/AddArquivo.cshtml", typeof(AspNetCore.Views_Arquivo_AddArquivo))]
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
#line 1 "C:\arquivos\servicos\gerarquivos\gerArquivos\Views\_ViewImports.cshtml"
using gerArquivos;

#line default
#line hidden
#line 2 "C:\arquivos\servicos\gerarquivos\gerArquivos\Views\_ViewImports.cshtml"
using gerArquivos.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abf947aee17c68e05049808085c2de48b5d9114c", @"/Views/Arquivo/AddArquivo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fddaa2ace530a4085b8cde9c492e4864e6d6012", @"/Views/_ViewImports.cshtml")]
    public class Views_Arquivo_AddArquivo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<gerArquivos.Models.vo.voArquivo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Arquivo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Voltar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("javascript: return validaForm(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\arquivos\servicos\gerarquivos\gerArquivos\Views\Arquivo\AddArquivo.cshtml"
  
    ViewData["Title"] = "AddArquivo";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(135, 194, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-xs-12 col-sm-12 col-md-12 col-lg-12\">\r\n        <h2>Adicionando novo Arquivo</h2>\r\n    </div>\r\n    <div class=\"col-xs-12 col-sm-12 col-md-12 col-lg-12\">\r\n");
            EndContext();
#line 13 "C:\arquivos\servicos\gerarquivos\gerArquivos\Views\Arquivo\AddArquivo.cshtml"
          
            if (TempData["mensagem"] != null)
            {
                if (Model.Erros.Count != 0)
                {
                    foreach (string msg in Model.Erros)
                    {

#line default
#line hidden
            BeginContext(547, 105, true);
            WriteLiteral("                        <div class=\"alert alert-warning\"><span class=\"glyphicon glyphicon-alert\"></span> ");
            EndContext();
            BeginContext(653, 3, false);
#line 20 "C:\arquivos\servicos\gerarquivos\gerArquivos\Views\Arquivo\AddArquivo.cshtml"
                                                                                                    Write(msg);

#line default
#line hidden
            EndContext();
            BeginContext(656, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 21 "C:\arquivos\servicos\gerarquivos\gerArquivos\Views\Arquivo\AddArquivo.cshtml"
                    }
                }
                else
                {

#line default
#line hidden
            BeginContext(747, 53, true);
            WriteLiteral("                    <div class=\"alert alert-success\">");
            EndContext();
            BeginContext(801, 20, false);
#line 25 "C:\arquivos\servicos\gerarquivos\gerArquivos\Views\Arquivo\AddArquivo.cshtml"
                                                Write(TempData["mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(821, 62, true);
            WriteLiteral("</div>\r\n                    <center>\r\n                        ");
            EndContext();
            BeginContext(883, 161, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b94d497691114e3980a3824ff82742c6", async() => {
                BeginContext(969, 71, true);
                WriteLiteral("<span class=\'glyphicon glyphicon-list-alt\'> Voltar para Listagem</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1044, 33, true);
            WriteLiteral("\r\n                    </center>\r\n");
            EndContext();
#line 29 "C:\arquivos\servicos\gerarquivos\gerArquivos\Views\Arquivo\AddArquivo.cshtml"
                }
            }
        

#line default
#line hidden
            BeginContext(1122, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(1144, 699, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01e358977f784800bc9faf4a8b8b5603", async() => {
                BeginContext(1291, 545, true);
                WriteLiteral(@"

    <div class=""row"">
        <div class=""col-xs-12 col-sm-6 col-md-4 col-lg-4"">
            <div class=""form-group"">
                <label for=""NomeArquivo"">Escolha o arquivo:</label>
                <input type=""file"" class=""form-control"" id=""NomeArquivo"" name=""NomeArquivo"" onchange=""javascript: validacao(this);"" accept="".pdf"">
            </div>

            <div class=""form-group"">
                <input type=""submit"" value=""Upload"" class=""btn btn-primary glyphicon-save"" />
            </div>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1843, 2177, true);
            WriteLiteral(@"

    <div id=""diagAlerta"" class=""modal fade"" role=""dialog"">
        <div class=""modal-dialog"">
            <!-- Modal content-->
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                    <h4 class=""modal-title"">
                        Aviso
                    </h4>
                </div>
                <div class=""modal-body"">
                    <p>Tipo de Arquivo Inválido. Somente arquivos PDF até 10mb são permitidos</p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Fechar</button>
                </div>
            </div>

        </div>
    </div>

    <script>
        function validaForm(formulario) {
            if (!fctValidarArquivo(formulario.NomeArquivo)) {
                $(""#diagAlerta"").modal();
                return false;");
            WriteLiteral(@"
            }
        }

        function fctValidarArquivo(arquivo) {
            var extensoesValidas = new Array(""pdf"");
            var extensao = arquivo.value.split('.').pop().toLowerCase();

            for (var i = 0; i <= extensoesValidas.length; i++) {
                if (extensoesValidas[i] == extensao) {

                    if (arquivo.files[0].size > 9999999) {
                        return false;
                    };

                    return true; // valid file extension
                }
            }

            return false;
        }

        function validacao(arquivo) {

            if (!fctValidarArquivo(arquivo)) {
                $(""#diagAlerta"").modal();
            }
        }


        function fctTamanho(campoFile) {
            var uploadField = document.getElementById(""file"");

            uploadField.onchange = function () {
                if (this.files[0].size > 307200) {
                    alert(""File is too big!"");
              ");
            WriteLiteral("      this.value = \"\";\r\n                };\r\n            };\r\n        }\r\n\r\n        \r\n        LoginGoogle();   \r\n\r\n    </script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<gerArquivos.Models.vo.voArquivo> Html { get; private set; }
    }
}
#pragma warning restore 1591
