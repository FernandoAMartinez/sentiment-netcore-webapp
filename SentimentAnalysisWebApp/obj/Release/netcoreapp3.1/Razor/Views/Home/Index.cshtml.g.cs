#pragma checksum "C:\Users\Kraps\source\repos\SentimentAnalysisNetCoreWebApp\SentimetAnalysisWebApp\SentimentAnalysisWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef7c64f3789b0ed4636747cf836540816a8b0c7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Kraps\source\repos\SentimentAnalysisNetCoreWebApp\SentimetAnalysisWebApp\SentimentAnalysisWebApp\Views\_ViewImports.cshtml"
using SentimentAnalysisWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kraps\source\repos\SentimentAnalysisNetCoreWebApp\SentimetAnalysisWebApp\SentimentAnalysisWebApp\Views\_ViewImports.cshtml"
using SentimentAnalysisWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef7c64f3789b0ed4636747cf836540816a8b0c7f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cc2def306d5026fb34f1913d80effd5a455b88f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConsoleViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Kraps\source\repos\SentimentAnalysisNetCoreWebApp\SentimetAnalysisWebApp\SentimentAnalysisWebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef7c64f3789b0ed4636747cf836540816a8b0c7f3512", async() => {
                WriteLiteral("\r\n\r\n    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js\"></script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <div class=""main"">
        <div>
            <div>
                <p>
                    <input type=""text"" id=""inputSentiment"" style=""width:60%"" placeholder=""Insert here your sentiment"" />
                    <button type=""button"" id=""processSentiment"" title=""Process"" style=""margin-right:-1%;""");
            BeginWriteAttribute("action", " action=\"", 562, "\"", 571, 0);
            EndWriteAttribute();
            WriteLiteral(">Process</button>\r\n                </p>\r\n            </div>\r\n            <div>\r\n                    <textarea placeholder=\"Result\" id=\"processResult\" style=\"width:70.5%; margin-right:-1%\" readonly>\r\n                        ");
#nullable restore
#line 23 "C:\Users\Kraps\source\repos\SentimentAnalysisNetCoreWebApp\SentimetAnalysisWebApp\SentimentAnalysisWebApp\Views\Home\Index.cshtml"
                   Write(Model.ResponsePrediction);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </textarea>
            </div>
        </div>
    </div>
    <div>
        <div style=""width:100%; margin-top:5%"">
            <p>
                <textarea readonly id=""consoleArea"" placeholder=""Insert here your sentiment."" rows=""15"" style=""width:100%; height:100%; border-radius:10px; background-color:black; color:aliceblue; text-align:left; font-family:Consolas;"">
                    ");
#nullable restore
#line 32 "C:\Users\Kraps\source\repos\SentimentAnalysisNetCoreWebApp\SentimetAnalysisWebApp\SentimentAnalysisWebApp\Views\Home\Index.cshtml"
               Write(Model.StringBuilder.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </textarea>
            </p>
        </div>
    </div>
</div>

<script>
    $(document).ready(function () {
        $(""#processSentiment"").click(function () {
            var processText = $(""#inputSentiment"").val();
            $.ajax({
                url: """);
#nullable restore
#line 44 "C:\Users\Kraps\source\repos\SentimentAnalysisNetCoreWebApp\SentimetAnalysisWebApp\SentimentAnalysisWebApp\Views\Home\Index.cshtml"
                 Write(Url.Action("Privacy", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                //data: { ""inputSentiment"": processText },
                data: { ""id"": processText },
                success: function (response) {
                    //debugger;
                    $(""#processResult"").val(response);
                }
            });
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConsoleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591