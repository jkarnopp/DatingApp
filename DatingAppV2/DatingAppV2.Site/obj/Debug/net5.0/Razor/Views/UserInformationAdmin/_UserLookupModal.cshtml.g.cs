#pragma checksum "C:\Users\jim\source\repos\DatingAppV2\DatingAppV2\DatingAppV2.Site\Views\UserInformationAdmin\_UserLookupModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9208cd38fb22f9792dbdd49291bb6dab50854ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserInformationAdmin__UserLookupModal), @"mvc.1.0.view", @"/Views/UserInformationAdmin/_UserLookupModal.cshtml")]
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
#line 1 "C:\Users\jim\source\repos\DatingAppV2\DatingAppV2\DatingAppV2.Site\Views\_ViewImports.cshtml"
using DatingAppV2.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jim\source\repos\DatingAppV2\DatingAppV2\DatingAppV2.Site\Views\_ViewImports.cshtml"
using DatingAppV2.Site.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9208cd38fb22f9792dbdd49291bb6dab50854ca", @"/Views/UserInformationAdmin/_UserLookupModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae597c13be822c574c4ef2fb565016f7c908d315", @"/Views/_ViewImports.cshtml")]
    public class Views_UserInformationAdmin__UserLookupModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal fade"" id=""idSearchModal"" role=""dialog"">
    <div class=""modal-dialog"">

        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header bg-dark"">

                <h5 class=""modal-title text-white"">Lookup User</h5>
                <button type=""button"" class=""close text-white cuClose"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>

            <div class=""modal-body"">
                <p>Enter the LAN ID of the user.</p>

                <div class=""form-inline"">
                    <label for=""usrname"">Username: </label>
                    <input type=""text"" class=""form-control pl-1 pr-1 ml-2 mr-2"" id=""usrname"" placeholder=""Enter LAN ID"">
                    <button id=""checkUser"" class=""btn btn-secondary""> Lookup</button>
                </div>

                <div id=""LanIdDetails"">
                </div>
            </div>
   ");
            WriteLiteral(@"         <div class=""modal-footer"">
                <button id=""saveUser"" class=""btn btn-outline-primary""><span class=""fa fa-plus""></span> Save</button>
                <button type=""submit"" id=""idSearchModalCancel"" class=""btn btn-outline-danger"" data-dismiss=""modal""><span class=""fa fa-remove""></span> Cancel</button>
            </div>
        </div>
    </div>
</div>");
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
