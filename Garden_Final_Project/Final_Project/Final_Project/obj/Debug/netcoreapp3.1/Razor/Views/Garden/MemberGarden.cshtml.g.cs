#pragma checksum "C:\Users\goods\source\repos\Grand_Circus_Final_Project-1\Garden_Final_Project\Final_Project\Final_Project\Views\Garden\MemberGarden.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "332d061fd950559847baf164a61ea4644d4b7232"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Garden_MemberGarden), @"mvc.1.0.view", @"/Views/Garden/MemberGarden.cshtml")]
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
#line 1 "C:\Users\goods\source\repos\Grand_Circus_Final_Project-1\Garden_Final_Project\Final_Project\Final_Project\Views\_ViewImports.cshtml"
using Final_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\goods\source\repos\Grand_Circus_Final_Project-1\Garden_Final_Project\Final_Project\Final_Project\Views\_ViewImports.cshtml"
using Final_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"332d061fd950559847baf164a61ea4644d4b7232", @"/Views/Garden/MemberGarden.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4fb7ef317ae05155a488c52b2e91b7ab94cdc5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Garden_MemberGarden : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Final_Project.Models.ViewModels.GardenControllerViewModels.MemberGardenViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/stylesheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Garden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateNote", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePlant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "332d061fd950559847baf164a61ea4644d4b72326388", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <div id=\"garden\">\r\n\r\n        <div class=\"gardenheader\">\r\n            <div class=\"gardentitle\">\r\n                <h1>MeGarden</h1>\r\n            </div>\r\n\r\n            <div class=\"addplant\">\r\n                <h1>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "332d061fd950559847baf164a61ea4644d4b72327743", async() => {
                WriteLiteral("Add To Garden");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h1>\r\n            </div>\r\n        </div>\r\n        <br />\r\n\r\n");
#nullable restore
#line 23 "C:\Users\goods\source\repos\Grand_Circus_Final_Project-1\Garden_Final_Project\Final_Project\Final_Project\Views\Garden\MemberGarden.cshtml"
         foreach (var plant in Model.garden)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"plant\">\r\n\r\n                <div class=\"column1garden\">\r\n                    <b>Name:</b> ");
#nullable restore
#line 28 "C:\Users\goods\source\repos\Grand_Circus_Final_Project-1\Garden_Final_Project\Final_Project\Final_Project\Views\Garden\MemberGarden.cshtml"
                            Write(plant.common_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Scientific Name: </b>");
#nullable restore
#line 29 "C:\Users\goods\source\repos\Grand_Circus_Final_Project-1\Garden_Final_Project\Final_Project\Final_Project\Views\Garden\MemberGarden.cshtml"
                                       Write(plant.scientific_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Quantity: </b>");
#nullable restore
#line 30 "C:\Users\goods\source\repos\Grand_Circus_Final_Project-1\Garden_Final_Project\Final_Project\Final_Project\Views\Garden\MemberGarden.cshtml"
                                Write(plant.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Location within the Garden: </b>");
#nullable restore
#line 31 "C:\Users\goods\source\repos\Grand_Circus_Final_Project-1\Garden_Final_Project\Final_Project\Final_Project\Views\Garden\MemberGarden.cshtml"
                                                  Write(plant.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Date of Planting: </b>");
#nullable restore
#line 32 "C:\Users\goods\source\repos\Grand_Circus_Final_Project-1\Garden_Final_Project\Final_Project\Final_Project\Views\Garden\MemberGarden.cshtml"
                                        Write(plant.plantDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Date of Harvest: </b>");
#nullable restore
#line 33 "C:\Users\goods\source\repos\Grand_Circus_Final_Project-1\Garden_Final_Project\Final_Project\Final_Project\Views\Garden\MemberGarden.cshtml"
                                       Write(plant.harvestDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br />\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "332d061fd950559847baf164a61ea4644d4b723211816", async() => {
                WriteLiteral("\r\n                        <textarea");
                BeginWriteAttribute("id", " id=\"", 1345, "\"", 1366, 1);
#nullable restore
#line 36 "C:\Users\goods\source\repos\Grand_Circus_Final_Project-1\Garden_Final_Project\Final_Project\Final_Project\Views\Garden\MemberGarden.cshtml"
WriteAttributeValue("", 1350, plant.PlantNote, 1350, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"PlantNote\" rows=\"4\" cols=\"50\">\r\n");
#nullable restore
#line 37 "C:\Users\goods\source\repos\Grand_Circus_Final_Project-1\Garden_Final_Project\Final_Project\Final_Project\Views\Garden\MemberGarden.cshtml"
                 if(plant.PlantNote == null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\goods\source\repos\Grand_Circus_Final_Project-1\Garden_Final_Project\Final_Project\Final_Project\Views\Garden\MemberGarden.cshtml"
               Write(Html.Raw("No Note Available"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\goods\source\repos\Grand_Circus_Final_Project-1\Garden_Final_Project\Final_Project\Final_Project\Views\Garden\MemberGarden.cshtml"
                                                  ;
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\goods\source\repos\Grand_Circus_Final_Project-1\Garden_Final_Project\Final_Project\Final_Project\Views\Garden\MemberGarden.cshtml"
               Write(plant.PlantNote);

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\goods\source\repos\Grand_Circus_Final_Project-1\Garden_Final_Project\Final_Project\Final_Project\Views\Garden\MemberGarden.cshtml"
                                    
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </textarea>\r\n                        <br />\r\n                        <button>Submit</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\goods\source\repos\Grand_Circus_Final_Project-1\Garden_Final_Project\Final_Project\Final_Project\Views\Garden\MemberGarden.cshtml"
                                                                            WriteLiteral(plant.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\goods\source\repos\Grand_Circus_Final_Project-1\Garden_Final_Project\Final_Project\Final_Project\Views\Garden\MemberGarden.cshtml"
                                                                                                            WriteLiteral(plant.PlantNote);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["PlantNote"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-PlantNote", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["PlantNote"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n              \r\n                </div>\r\n                <br />\r\n                <div class=\"centertext\">\r\n                    <img class=\"plantimg\"");
            BeginWriteAttribute("src", " src=\"", 1927, "\"", 1949, 1);
#nullable restore
#line 53 "C:\Users\goods\source\repos\Grand_Circus_Final_Project-1\Garden_Final_Project\Final_Project\Final_Project\Views\Garden\MemberGarden.cshtml"
WriteAttributeValue("", 1933, plant.image_url, 1933, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /><br />\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "332d061fd950559847baf164a61ea4644d4b723218159", async() => {
                WriteLiteral("Delete Plant?");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\goods\source\repos\Grand_Circus_Final_Project-1\Garden_Final_Project\Final_Project\Final_Project\Views\Garden\MemberGarden.cshtml"
                                                                WriteLiteral(plant.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                \r\n            </div>\r\n            <br />\r\n");
#nullable restore
#line 59 "C:\Users\goods\source\repos\Grand_Circus_Final_Project-1\Garden_Final_Project\Final_Project\Final_Project\Views\Garden\MemberGarden.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Final_Project.Models.ViewModels.GardenControllerViewModels.MemberGardenViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
