#pragma checksum "D:\repos\C#\Master Blogger\MasterBlogger\Presentation\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5012fc932143236b7eb5b01da9443a0ab3e7a8e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Onion.Presentation.Areas.Administrator.Pages.CommentManagement.Areas_Administrator_Pages_CommentManagement_List), @"mvc.1.0.razor-page", @"/Areas/Administrator/Pages/CommentManagement/List.cshtml")]
namespace Onion.Presentation.Areas.Administrator.Pages.CommentManagement
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
#line 2 "D:\repos\C#\Master Blogger\MasterBlogger\Presentation\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
using MB.Domain.CommentAgg;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5012fc932143236b7eb5b01da9443a0ab3e7a8e7", @"/Areas/Administrator/Pages/CommentManagement/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"876095a2c6c38372b32de27da760084e90170f72", @"/Areas/Administrator/Pages/_ViewImports.cshtml")]
    public class Areas_Administrator_Pages_CommentManagement_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Confirm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Cancel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""card"">
    <div class=""card-header"">
        <h3 class=""float-left"">Comment List</h3>
    </div>
    <div class=""card-body"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Article</th>
                    <th>Message</th>
                    <th>Status</th>
                    <th>Creation Date</th>
                    <th>Operation</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 25 "D:\repos\C#\Master Blogger\MasterBlogger\Presentation\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                 foreach (var comment in Model.Comments)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th>");
#nullable restore
#line 28 "D:\repos\C#\Master Blogger\MasterBlogger\Presentation\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 29 "D:\repos\C#\Master Blogger\MasterBlogger\Presentation\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 30 "D:\repos\C#\Master Blogger\MasterBlogger\Presentation\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 31 "D:\repos\C#\Master Blogger\MasterBlogger\Presentation\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.Article);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 32 "D:\repos\C#\Master Blogger\MasterBlogger\Presentation\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>\r\n");
#nullable restore
#line 34 "D:\repos\C#\Master Blogger\MasterBlogger\Presentation\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                             if (comment.Status == Statuses.New)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa fa-eye fa-2x text-info aria-hidden\"></i>\r\n");
#nullable restore
#line 37 "D:\repos\C#\Master Blogger\MasterBlogger\Presentation\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                            }
                            else if (comment.Status == Statuses.Canceled)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa fa-close fa-2x text-danger\"></i>\r\n");
#nullable restore
#line 41 "D:\repos\C#\Master Blogger\MasterBlogger\Presentation\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa fa-check fa-2x text-success\"></i>\r\n");
#nullable restore
#line 45 "D:\repos\C#\Master Blogger\MasterBlogger\Presentation\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </th>\r\n                        <th>");
#nullable restore
#line 47 "D:\repos\C#\Master Blogger\MasterBlogger\Presentation\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>\r\n");
#nullable restore
#line 49 "D:\repos\C#\Master Blogger\MasterBlogger\Presentation\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                             if (comment.Status == Statuses.New)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5012fc932143236b7eb5b01da9443a0ab3e7a8e79651", async() => {
                WriteLiteral("\r\n                                    <button class=\"btn btn-success\">Confirm</button>\r\n                                    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2163, "\"", 2182, 1);
#nullable restore
#line 53 "D:\repos\C#\Master Blogger\MasterBlogger\Presentation\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
WriteAttributeValue("", 2171, comment.Id, 2171, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5012fc932143236b7eb5b01da9443a0ab3e7a8e712031", async() => {
                WriteLiteral("\r\n                                    <button class=\"btn btn-danger\">Cancel</button>\r\n                                    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2478, "\"", 2497, 1);
#nullable restore
#line 57 "D:\repos\C#\Master Blogger\MasterBlogger\Presentation\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
WriteAttributeValue("", 2486, comment.Id, 2486, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 59 "D:\repos\C#\Master Blogger\MasterBlogger\Presentation\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </th>\r\n                    </tr>\r\n");
#nullable restore
#line 62 "D:\repos\C#\Master Blogger\MasterBlogger\Presentation\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MB.Presentation.MVCCore.Areas.Administrator.Pages.CommentManagement.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MB.Presentation.MVCCore.Areas.Administrator.Pages.CommentManagement.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MB.Presentation.MVCCore.Areas.Administrator.Pages.CommentManagement.ListModel>)PageContext?.ViewData;
        public MB.Presentation.MVCCore.Areas.Administrator.Pages.CommentManagement.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
