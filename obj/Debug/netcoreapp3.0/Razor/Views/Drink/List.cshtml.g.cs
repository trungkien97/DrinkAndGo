#pragma checksum "C:\Users\dtkien\source\repos\DrinkAndGo\DrinkAndGo\Views\Drink\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6c1a64aca633223e7f4c482f5312bf1c3d8ca7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Drink_List), @"mvc.1.0.view", @"/Views/Drink/List.cshtml")]
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
#line 1 "C:\Users\dtkien\source\repos\DrinkAndGo\DrinkAndGo\Views\Drink\List.cshtml"
using DrinkAndGo.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6c1a64aca633223e7f4c482f5312bf1c3d8ca7e", @"/Views/Drink/List.cshtml")]
    public class Views_Drink_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DrinkListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    <h2>");
#nullable restore
#line 4 "C:\Users\dtkien\source\repos\DrinkAndGo\DrinkAndGo\Views\Drink\List.cshtml"
   Write(Model.CurrentCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n</div>\r\n");
#nullable restore
#line 6 "C:\Users\dtkien\source\repos\DrinkAndGo\DrinkAndGo\Views\Drink\List.cshtml"
   
    foreach(var drink in Model.Drinks)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <h4>Drink Name: ");
#nullable restore
#line 10 "C:\Users\dtkien\source\repos\DrinkAndGo\DrinkAndGo\Views\Drink\List.cshtml"
                       Write(drink.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <p>Price: ");
#nullable restore
#line 11 "C:\Users\dtkien\source\repos\DrinkAndGo\DrinkAndGo\Views\Drink\List.cshtml"
                 Write(drink.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n");
#nullable restore
#line 13 "C:\Users\dtkien\source\repos\DrinkAndGo\DrinkAndGo\Views\Drink\List.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DrinkListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591