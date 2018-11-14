#pragma checksum "C:\Users\opilane\Desktop\Polykas2018-master\19-AspNetCore\MediaGallery\Views\Shared\Components\GalleryMenu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "450cd068f5bd25946076c3ec807d1595f98075fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_GalleryMenu_Index), @"mvc.1.0.view", @"/Views/Shared/Components/GalleryMenu/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/GalleryMenu/Index.cshtml", typeof(AspNetCore.Views_Shared_Components_GalleryMenu_Index))]
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
#line 1 "C:\Users\opilane\Desktop\Polykas2018-master\19-AspNetCore\MediaGallery\Views\_ViewImports.cshtml"
using MediaGallery;

#line default
#line hidden
#line 2 "C:\Users\opilane\Desktop\Polykas2018-master\19-AspNetCore\MediaGallery\Views\_ViewImports.cshtml"
using MediaGallery.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"450cd068f5bd25946076c3ec807d1595f98075fc", @"/Views/Shared/Components/GalleryMenu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1534bc3d03d3d4493d4ab3b663027f8558bf613f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_GalleryMenu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MediaGallery.Data.MediaFolder>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\opilane\Desktop\Polykas2018-master\19-AspNetCore\MediaGallery\Views\Shared\Components\GalleryMenu\Index.cshtml"
  
    var ids = _galleryContext.GetCurrentFolderPath();

#line default
#line hidden
            BeginContext(148, 24, true);
            WriteLiteral("<ul class=\"list-group\">\n");
            EndContext();
#line 7 "C:\Users\opilane\Desktop\Polykas2018-master\19-AspNetCore\MediaGallery\Views\Shared\Components\GalleryMenu\Index.cshtml"
     foreach (var item in Model)
    {
        var activeClass = "";
        if(ids.Contains(item.Id))
        {
            activeClass = "active";
        }
        var routeData = new Dictionary<string, string>
        {
            { "id", item.Id.ToString() }
        };

#line default
#line hidden
            BeginContext(448, 11, true);
            WriteLiteral("        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 459, "\"", 504, 3);
            WriteAttributeValue("", 467, "list-group-item", 467, 15, true);
            WriteAttributeValue(" ", 482, "clearfix", 483, 9, true);
#line 18 "C:\Users\opilane\Desktop\Polykas2018-master\19-AspNetCore\MediaGallery\Views\Shared\Components\GalleryMenu\Index.cshtml"
WriteAttributeValue(" ", 491, activeClass, 492, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(505, 60, true);
            WriteLiteral(">\n            <i class=\"fa fa-angle-right\"></i>\n            ");
            EndContext();
            BeginContext(565, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "527b77eff0bb433f869531e1f6f750c0", async() => {
                BeginContext(644, 10, false);
#line 20 "C:\Users\opilane\Desktop\Polykas2018-master\19-AspNetCore\MediaGallery\Views\Shared\Components\GalleryMenu\Index.cshtml"
                                                                                     Write(item.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 20 "C:\Users\opilane\Desktop\Polykas2018-master\19-AspNetCore\MediaGallery\Views\Shared\Components\GalleryMenu\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = routeData;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(658, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 21 "C:\Users\opilane\Desktop\Polykas2018-master\19-AspNetCore\MediaGallery\Views\Shared\Components\GalleryMenu\Index.cshtml"
             if (item.Items.Count > 0 && activeClass=="active")
            {
                

#line default
#line hidden
            BeginContext(754, 48, false);
#line 23 "C:\Users\opilane\Desktop\Polykas2018-master\19-AspNetCore\MediaGallery\Views\Shared\Components\GalleryMenu\Index.cshtml"
           Write(await Component.InvokeAsync("GalleryMenu", item));

#line default
#line hidden
            EndContext();
#line 23 "C:\Users\opilane\Desktop\Polykas2018-master\19-AspNetCore\MediaGallery\Views\Shared\Components\GalleryMenu\Index.cshtml"
                                                                 
            }

#line default
#line hidden
            BeginContext(817, 14, true);
            WriteLiteral("        </li>\n");
            EndContext();
#line 26 "C:\Users\opilane\Desktop\Polykas2018-master\19-AspNetCore\MediaGallery\Views\Shared\Components\GalleryMenu\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(837, 5, true);
            WriteLiteral("</ul>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public GalleryContext _galleryContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MediaGallery.Data.MediaFolder>> Html { get; private set; }
    }
}
#pragma warning restore 1591