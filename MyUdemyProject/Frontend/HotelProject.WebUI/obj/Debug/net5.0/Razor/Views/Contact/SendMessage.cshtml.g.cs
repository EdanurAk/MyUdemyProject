#pragma checksum "C:\Users\PC_3829\Desktop\apiornek\MyUdemyProject\Frontend\HotelProject.WebUI\Views\Contact\SendMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a36962a1885cc85ccce5342ba4b3bad662d2508"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_SendMessage), @"mvc.1.0.view", @"/Views/Contact/SendMessage.cshtml")]
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
#line 1 "C:\Users\PC_3829\Desktop\apiornek\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC_3829\Desktop\apiornek\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PC_3829\Desktop\apiornek\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Staff;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PC_3829\Desktop\apiornek\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Testimonial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PC_3829\Desktop\apiornek\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ServiceDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PC_3829\Desktop\apiornek\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RegisterDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PC_3829\Desktop\apiornek\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.LoginDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PC_3829\Desktop\apiornek\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.AboutDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PC_3829\Desktop\apiornek\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RoomDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\PC_3829\Desktop\apiornek\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.TestimonialDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\PC_3829\Desktop\apiornek\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.StaffDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\PC_3829\Desktop\apiornek\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.BookingDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\PC_3829\Desktop\apiornek\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ContactDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\PC_3829\Desktop\apiornek\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.GuestDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a36962a1885cc85ccce5342ba4b3bad662d2508", @"/Views/Contact/SendMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f99fc7dd4185202306665d2acc3dc65ed0a84c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_SendMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreateContactDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""container-xxl py-5"">
    <div class=""container"">
        <div class=""text-center wow fadeInUp"" data-wow-delay=""0.1s"">
            <h6 class=""section-title text-center text-primary text-uppercase"">Bize Ulaşın</h6>
            <h1 class=""mb-5""><span class=""text-primary text-uppercase"">Tüm Sorularınız İçin</span> Bize Yazabilirsiniz</h1>
        </div>
        <div class=""row g-4"">
            <div class=""col-12"">
                <div class=""row gy-4"">
                    <div class=""col-md-4"">
                        <h6 class=""section-title text-start text-primary text-uppercase"">Rezervasyon</h6>
                        <p><i class=""fa fa-envelope-open text-primary me-2""></i>hotelapi@example.com</p>
                    </div>
                    <div class=""col-md-4"">
                        <h6 class=""section-title text-start text-primary text-uppercase"">Genel Sorularınız</h6>
                        <p><i class=""fa fa-envelope-open text-primary me-2""></i>info@example.com</p>
                    <");
            WriteLiteral(@"/div>
                    <div class=""col-md-4"">
                        <h6 class=""section-title text-start text-primary text-uppercase"">İş Başvurusu</h6>
                        <p><i class=""fa fa-envelope-open text-primary me-2""></i>ik@example.com</p>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 wow fadeIn"" data-wow-delay=""0.1s"">
                <iframe class=""position-relative rounded w-100 h-100""
                        src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d48182.94830584892!2d29.006573027518414!3d40.99386720369605!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cac7f0882bb5db%3A0x8f002035885528db!2sAkasya%20AVM!5e0!3m2!1str!2str!4v1694704918150!5m2!1str!2str""
                        frameborder=""0"" style=""min-height: 350px; border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 1882, "\"", 1900, 0);
            EndWriteAttribute();
            WriteLiteral(" aria-hidden=\"false\"\n                        tabindex=\"0\"></iframe>\n            </div>\n            <div class=\"col-md-6\">\n                <div class=\"wow fadeInUp\" data-wow-delay=\"0.2s\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a36962a1885cc85ccce5342ba4b3bad662d25089289", async() => {
                WriteLiteral(@"
                        <div class=""row g-3"">
                            <div class=""col-md-6"">
                                <div class=""form-floating"">
                                    <input type=""text"" class=""form-control"" id=""name"" placeholder=""Adınız Soyadınız"" name=""Name"">
                                    <label for=""name"">Adınız Soyadınız</label>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-floating"">
                                    <input type=""email"" class=""form-control"" id=""email"" placeholder=""Mail Adresiniz"" name=""Mail"">
                                    <label for=""email"">Mail Adresiniz</label>
                                </div>
                            </div>
                            <div class=""col-12"">
                                <div class=""form-floating"">
                                    <input type=""text"" class=""form-control"" id=""s");
                WriteLiteral(@"ubject"" placeholder=""Konu"" name=""Subject"">
                                    <label for=""subject"">Konu</label>
                                </div>
                            </div>
                            <div class=""col-12"">
                                <div class=""form-floating"">
                                    <textarea class=""form-control"" placeholder=""Mesajınızı Buraya Yazabilirsiniz"" name=""Message"" style=""height: 150px""></textarea>
                                    <label for=""message"">Mesajınız</label>
                                </div>
                            </div>
                            <div class=""col-12"">
                                <button class=""btn btn-primary w-100 py-3"" type=""submit"">Mesajı Gönder</button>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateContactDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
