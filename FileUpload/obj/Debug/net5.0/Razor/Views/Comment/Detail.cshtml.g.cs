#pragma checksum "C:\Users\gkykl\source\repos\FileUpload\FileUpload\Views\Comment\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b92c5b3b811f6a0aef6bd9bc441bd04f7a711b4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_Detail), @"mvc.1.0.view", @"/Views/Comment/Detail.cshtml")]
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
#line 1 "C:\Users\gkykl\source\repos\FileUpload\FileUpload\Views\_ViewImports.cshtml"
using FileUpload;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gkykl\source\repos\FileUpload\FileUpload\Views\_ViewImports.cshtml"
using FileUpload.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b92c5b3b811f6a0aef6bd9bc441bd04f7a711b4c", @"/Views/Comment/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c4da4f3990f4e4ed916571717d0596d929556ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Comment>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gkykl\source\repos\FileUpload\FileUpload\Views\Comment\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\gkykl\source\repos\FileUpload\FileUpload\Views\Comment\Detail.cshtml"
Write(Model.CommentText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 8 "C:\Users\gkykl\source\repos\FileUpload\FileUpload\Views\Comment\Detail.cshtml"
Write(Model.FullName);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Comment> Html { get; private set; }
    }
}
#pragma warning restore 1591
