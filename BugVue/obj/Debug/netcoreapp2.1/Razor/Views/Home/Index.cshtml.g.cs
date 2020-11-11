#pragma checksum "E:\BugVue\BugVue\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce162a5c149baa2ad769ec7fe67e604b422f3505"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce162a5c149baa2ad769ec7fe67e604b422f3505", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/vue/vue.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1966, true);
            WriteLiteral(@"<div id=""app"">

    <button class=""btn btn-primary"" v-on:click=""showNewBugModal"">Add new bug...</button>

    <table class=""table"">

        <thead>
            <tr>
                <th>#</th>
                <th>Name</th>
                <th>Description</th>
            </tr>
        </thead>

        <tbody>
            <tr v-for=""(bug,index) in bugs"">
                <td>{{index+1}}</td>
                <td>{{bug.name}}</td>
                <td>{{bug.description}}</td>
            </tr>
        </tbody>
    </table>

    <div class=""modal fade"" id=""addNewBugModal"" tabindex=""-1"" role=""dialog"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                    <h4 class=""modal-title"">Add new bug</h4>
                </div>
                <div class=""");
            WriteLiteral(@"modal-body"">
                    <div class=""form-group"">
                        <label for=""name"">Name</label>
                        <input v-model=""name"" type=""text"" class=""form-control"" style=""width:100%"">
                    </div>
                    <div class=""form-group"">
                        <label for=""description"">Description</label>
                        <input v-model=""description"" name=""Description"" type=""text"" class=""form-control"" style=""width:100%"">
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-primary"" v-on:click=""addBugs"">Save changes</button>
                </div>
            </div><!-- /.modal-content -->
        </div><!-- /.modal-dialog -->
    </div><!-- /.modal -->

</div>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1983, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(1991, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3676826f839467899898314f7f804d6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2035, 1581, true);
                WriteLiteral(@"

<script>

    var app = new Vue({

        el: ""#app"",
        data: {
            
            bugs: [],
            name: """",
            description:""""
        },
        created: function () {
            this.getBugs();

        },
        methods: {

            showNewBugModal: function () {
                $(""#addNewBugModal"").modal(""show"");
            },

            addBugs: function () {

                var vm = this;
                var newBug = {
                    name: vm.name,
                    description: vm.description
                }

                $.ajax({ url: ""/bug"", data: newBug, method: ""POST"" })
                    .done(function (data) {
                        vm.bugs.splice(0, 0, newBug);
                        toastr.success(""Success"");
                    }).fail(function () {
                        toastr.fail(""Failed"");
                    }).always(function () {
                        vm.name = """";
                        v");
                WriteLiteral(@"m.description = """";
                        $(""#addNewBugModal"").modal(""hide"");
                    });

            },

            getBugs: function () {
                var vm = this;

                $.ajax({ url: ""/bug"", method: ""GET"" })
                    .done(function (data) {
                        vm.bugs = data;
                        toastr.success(""Success"");
                    }).fail(function () {
                        toastr.error(""Error"");
                    });
            }
        }

    });

</script>
");
                EndContext();
            }
            );
            BeginContext(3619, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
