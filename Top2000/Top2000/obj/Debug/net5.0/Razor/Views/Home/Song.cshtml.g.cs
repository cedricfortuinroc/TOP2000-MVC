#pragma checksum "C:\RvT\TOP2000-MVC\Top2000\Top2000\Views\Home\Song.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1be35b7c956c673d0cbd60994acf2a76bb89f155"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Song), @"mvc.1.0.view", @"/Views/Home/Song.cshtml")]
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
#line 1 "C:\RvT\TOP2000-MVC\Top2000\Top2000\Views\_ViewImports.cshtml"
using Top2000;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\RvT\TOP2000-MVC\Top2000\Top2000\Views\_ViewImports.cshtml"
using Top2000.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1be35b7c956c673d0cbd60994acf2a76bb89f155", @"/Views/Home/Song.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"130ea2ce154ec2dc2aea044e3d2cc8b73398e578", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Song : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\RvT\TOP2000-MVC\Top2000\Top2000\Views\Home\Song.cshtml"
  
    ViewData["Title"] = "Ploatn";
    string[] tableHeaders = new string[] {"Titel", "Jaar", "Naam", "Positie", "Top2000 Jaar", "Top2000 Titel"};

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Dikk\'n ");
#nullable restore
#line 6 "C:\RvT\TOP2000-MVC\Top2000\Top2000\Views\Home\Song.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n<div class=\"table-responsive\">\r\n    <table class=\"table table-bordered table-hover\">\r\n        <thead>\r\n        <tr>\r\n");
#nullable restore
#line 13 "C:\RvT\TOP2000-MVC\Top2000\Top2000\Views\Home\Song.cshtml"
              
                foreach (var head in tableHeaders)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>\r\n                        ");
#nullable restore
#line 17 "C:\RvT\TOP2000-MVC\Top2000\Top2000\Views\Home\Song.cshtml"
                   Write(head);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n");
#nullable restore
#line 19 "C:\RvT\TOP2000-MVC\Top2000\Top2000\Views\Home\Song.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n        </thead>\r\n");
#nullable restore
#line 23 "C:\RvT\TOP2000-MVC\Top2000\Top2000\Views\Home\Song.cshtml"
          
            if (Model != null)
            {
                foreach (var song in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 29 "C:\RvT\TOP2000-MVC\Top2000\Top2000\Views\Home\Song.cshtml"
                       Write(song.SongTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\RvT\TOP2000-MVC\Top2000\Top2000\Views\Home\Song.cshtml"
                       Write(song.SongYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\RvT\TOP2000-MVC\Top2000\Top2000\Views\Home\Song.cshtml"
                       Write(song.ArtistName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\RvT\TOP2000-MVC\Top2000\Top2000\Views\Home\Song.cshtml"
                       Write(song.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "C:\RvT\TOP2000-MVC\Top2000\Top2000\Views\Home\Song.cshtml"
                       Write(song.ListYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\RvT\TOP2000-MVC\Top2000\Top2000\Views\Home\Song.cshtml"
                       Write(song.ListTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 36 "C:\RvT\TOP2000-MVC\Top2000\Top2000\Views\Home\Song.cshtml"
                }
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
