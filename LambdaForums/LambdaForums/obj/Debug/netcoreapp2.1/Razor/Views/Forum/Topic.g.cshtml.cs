#pragma checksum "D:\MY WORLD\latest programming\ASP.NET CORE WITH WES DOYLE\LambdaForums\LambdaForums\Views\Forum\Topic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1a1247e8a1592ac2c820c5b9246575653a96e72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forum_Topic), @"mvc.1.0.view", @"/Views/Forum/Topic.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Forum/Topic.cshtml", typeof(AspNetCore.Views_Forum_Topic))]
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
#line 1 "D:\MY WORLD\latest programming\ASP.NET CORE WITH WES DOYLE\LambdaForums\LambdaForums\Views\_ViewImports.cshtml"
using LambdaForums;

#line default
#line hidden
#line 2 "D:\MY WORLD\latest programming\ASP.NET CORE WITH WES DOYLE\LambdaForums\LambdaForums\Views\_ViewImports.cshtml"
using LambdaForums.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1a1247e8a1592ac2c820c5b9246575653a96e72", @"/Views/Forum/Topic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c871c8f56f9c78303e7569257ee93ff97f327e", @"/Views/_ViewImports.cshtml")]
    public class Views_Forum_Topic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LambdaForums.Models.Forum.ForumTopicModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\MY WORLD\latest programming\ASP.NET CORE WITH WES DOYLE\LambdaForums\LambdaForums\Views\Forum\Topic.cshtml"
  
    ViewData["Title"] = "Topic";

#line default
#line hidden
            BeginContext(91, 21, true);
            WriteLiteral("\r\n<h1>Welcome to the ");
            EndContext();
            BeginContext(113, 16, false);
#line 6 "D:\MY WORLD\latest programming\ASP.NET CORE WITH WES DOYLE\LambdaForums\LambdaForums\Views\Forum\Topic.cshtml"
              Write(Model.Forum.Name);

#line default
#line hidden
            EndContext();
            BeginContext(129, 9, true);
            WriteLiteral("</h1>\r\n\r\n");
            EndContext();
#line 8 "D:\MY WORLD\latest programming\ASP.NET CORE WITH WES DOYLE\LambdaForums\LambdaForums\Views\Forum\Topic.cshtml"
 if(Model.Posts.Any())
{

#line default
#line hidden
            BeginContext(165, 71, true);
            WriteLiteral("    <table class=\"table table-bordered table-hover\">\r\n        <tbody>\r\n");
            EndContext();
#line 12 "D:\MY WORLD\latest programming\ASP.NET CORE WITH WES DOYLE\LambdaForums\LambdaForums\Views\Forum\Topic.cshtml"
             foreach(var post in Model.Posts)
            {

#line default
#line hidden
            BeginContext(298, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(358, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "556598be696d48698816f8623c2bf7c7", async() => {
                BeginContext(426, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(453, 10, false);
#line 17 "D:\MY WORLD\latest programming\ASP.NET CORE WITH WES DOYLE\LambdaForums\LambdaForums\Views\Forum\Topic.cshtml"
                   Write(post.Title);

#line default
#line hidden
                EndContext();
                BeginContext(463, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 16 "D:\MY WORLD\latest programming\ASP.NET CORE WITH WES DOYLE\LambdaForums\LambdaForums\Views\Forum\Topic.cshtml"
                                                                  WriteLiteral(post.Id);

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
            BeginContext(489, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(557, 11, false);
#line 21 "D:\MY WORLD\latest programming\ASP.NET CORE WITH WES DOYLE\LambdaForums\LambdaForums\Views\Forum\Topic.cshtml"
               Write(post.Author);

#line default
#line hidden
            EndContext();
            BeginContext(568, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(636, 15, false);
#line 24 "D:\MY WORLD\latest programming\ASP.NET CORE WITH WES DOYLE\LambdaForums\LambdaForums\Views\Forum\Topic.cshtml"
               Write(post.DatePosted);

#line default
#line hidden
            EndContext();
            BeginContext(651, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(719, 17, false);
#line 27 "D:\MY WORLD\latest programming\ASP.NET CORE WITH WES DOYLE\LambdaForums\LambdaForums\Views\Forum\Topic.cshtml"
               Write(post.RepliesCount);

#line default
#line hidden
            EndContext();
            BeginContext(736, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 30 "D:\MY WORLD\latest programming\ASP.NET CORE WITH WES DOYLE\LambdaForums\LambdaForums\Views\Forum\Topic.cshtml"
            }

#line default
#line hidden
            BeginContext(795, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 33 "D:\MY WORLD\latest programming\ASP.NET CORE WITH WES DOYLE\LambdaForums\LambdaForums\Views\Forum\Topic.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(839, 66, true);
            WriteLiteral("    <div class=\"noPosts\">\r\n        <h3>It looks like there are no ");
            EndContext();
            BeginContext(906, 16, false);
#line 37 "D:\MY WORLD\latest programming\ASP.NET CORE WITH WES DOYLE\LambdaForums\LambdaForums\Views\Forum\Topic.cshtml"
                                  Write(Model.Forum.Name);

#line default
#line hidden
            EndContext();
            BeginContext(922, 40, true);
            WriteLiteral(" posts yet. <br />Why not \r\n            ");
            EndContext();
            BeginContext(962, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b712335b8e1f41ebae83de0f0e4ea58d", async() => {
                BeginContext(1038, 51, true);
                WriteLiteral("\r\n                <span>create</span>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "D:\MY WORLD\latest programming\ASP.NET CORE WITH WES DOYLE\LambdaForums\LambdaForums\Views\Forum\Topic.cshtml"
                                                           WriteLiteral(Model.Forum.Id);

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
            BeginContext(1093, 43, true);
            WriteLiteral("\r\n        one?\r\n        </h3>\r\n    </div>\r\n");
            EndContext();
#line 44 "D:\MY WORLD\latest programming\ASP.NET CORE WITH WES DOYLE\LambdaForums\LambdaForums\Views\Forum\Topic.cshtml"
}

#line default
#line hidden
            BeginContext(1139, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LambdaForums.Models.Forum.ForumTopicModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
