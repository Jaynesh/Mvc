﻿#pragma checksum "TestFiles/Input/ModelExpressionTagHelper.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b1d4af116a70f83c556ece1980f2e9364e6baa7"
namespace Asp
{
    using Microsoft.AspNet.Razor.Runtime.TagHelpers;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.AspNet.Mvc;
    using Microsoft.AspNet.Mvc.Rendering;
    using System.Threading.Tasks;

    public class ASPV_TestFiles_Input_ModelExpressionTagHelper_cshtml : Microsoft.AspNet.Mvc.Razor.RazorPage<
#line 1 "TestFiles/Input/ModelExpressionTagHelper.cshtml"
       DateTime

#line default
#line hidden
    >
    {
        #line hidden
        #pragma warning disable 0414
        private System.IO.TextWriter __tagHelperStringValueBuffer = null;
        #pragma warning restore 0414
        private Microsoft.AspNet.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext = null;
        private Microsoft.AspNet.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new Microsoft.AspNet.Razor.Runtime.TagHelpers.TagHelperRunner();
        private Microsoft.AspNet.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager = new Microsoft.AspNet.Razor.Runtime.TagHelpers.TagHelperScopeManager();
        private Microsoft.AspNet.Mvc.Razor.InputTestTagHelper __Microsoft_AspNet_Mvc_Razor_InputTestTagHelper = null;
        #line hidden
        public ASPV_TestFiles_Input_ModelExpressionTagHelper_cshtml()
        {
        }
        #line hidden
        [Microsoft.AspNet.Mvc.ActivateAttribute]
        public Microsoft.AspNet.Mvc.Rendering.IHtmlHelper<DateTime> Html { get; private set; }
        [Microsoft.AspNet.Mvc.ActivateAttribute]
        public Microsoft.AspNet.Mvc.IViewComponentHelper Component { get; private set; }
        [Microsoft.AspNet.Mvc.ActivateAttribute]
        public Microsoft.AspNet.Mvc.IUrlHelper Url { get; private set; }

        #line hidden

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            BeginContext(120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input-test", true, "test", async() => {
            }
            , StartWritingScope, EndWritingScope);
            __Microsoft_AspNet_Mvc_Razor_InputTestTagHelper = CreateTagHelper<Microsoft.AspNet.Mvc.Razor.InputTestTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNet_Mvc_Razor_InputTestTagHelper);
#line 5 "TestFiles/Input/ModelExpressionTagHelper.cshtml"
__Microsoft_AspNet_Mvc_Razor_InputTestTagHelper.For = CreateModelExpression(__model => __model.Now);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNet_Mvc_Razor_InputTestTagHelper.For);
            __tagHelperExecutionContext.Output = __tagHelperRunner.RunAsync(__tagHelperExecutionContext).Result;
            WriteLiteral(__tagHelperExecutionContext.Output.GenerateStartTag());
            Write(__tagHelperExecutionContext.Output.GeneratePreContent());
            if (__tagHelperExecutionContext.Output.ContentSet)
            {
                Write(__tagHelperExecutionContext.Output.GenerateContent());
            }
            else if (__tagHelperExecutionContext.ChildContentRetrieved)
            {
                Write(__tagHelperExecutionContext.GetChildContentAsync().Result);
            }
            else
            {
                __tagHelperExecutionContext.ExecuteChildContentAsync().Wait();
            }
            Write(__tagHelperExecutionContext.Output.GeneratePostContent());
            WriteLiteral(__tagHelperExecutionContext.Output.GenerateEndTag());
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            BeginContext(146, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input-test", true, "test", async() => {
            }
            , StartWritingScope, EndWritingScope);
            __Microsoft_AspNet_Mvc_Razor_InputTestTagHelper = CreateTagHelper<Microsoft.AspNet.Mvc.Razor.InputTestTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNet_Mvc_Razor_InputTestTagHelper);
#line 6 "TestFiles/Input/ModelExpressionTagHelper.cshtml"
__Microsoft_AspNet_Mvc_Razor_InputTestTagHelper.For = CreateModelExpression(__model => Model);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNet_Mvc_Razor_InputTestTagHelper.For);
            __tagHelperExecutionContext.Output = __tagHelperRunner.RunAsync(__tagHelperExecutionContext).Result;
            WriteLiteral(__tagHelperExecutionContext.Output.GenerateStartTag());
            Write(__tagHelperExecutionContext.Output.GeneratePreContent());
            if (__tagHelperExecutionContext.Output.ContentSet)
            {
                Write(__tagHelperExecutionContext.Output.GenerateContent());
            }
            else if (__tagHelperExecutionContext.ChildContentRetrieved)
            {
                Write(__tagHelperExecutionContext.GetChildContentAsync().Result);
            }
            else
            {
                __tagHelperExecutionContext.ExecuteChildContentAsync().Wait();
            }
            Write(__tagHelperExecutionContext.Output.GeneratePostContent());
            WriteLiteral(__tagHelperExecutionContext.Output.GenerateEndTag());
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
    }
}
