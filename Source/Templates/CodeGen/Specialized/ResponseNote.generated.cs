﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Templates.CodeGen.Specialized
{
    using System;
    
    #line 2 "..\..\CodeGen\Specialized\ResponseNote.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 3 "..\..\CodeGen\Specialized\ResponseNote.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 4 "..\..\CodeGen\Specialized\ResponseNote.cshtml"
    using Humanizer;
    
    #line default
    #line hidden
    
    #line 5 "..\..\CodeGen\Specialized\ResponseNote.cshtml"
    using Newtonsoft.Json.Linq;
    
    #line default
    #line hidden
    
    #line 6 "..\..\CodeGen\Specialized\ResponseNote.cshtml"
    using Templates.CodeGen;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class ResponseNote : EnumTemplate
    {
#line hidden

        #line 14 "..\..\CodeGen\Specialized\ResponseNote.cshtml"

    

        #line default
        #line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");






WriteLiteral("\r\n");


WriteLiteral("\r\n");


            
            #line 10 "..\..\CodeGen\Specialized\ResponseNote.cshtml"
  
    this.Layout = UseParentLayout(this);


            
            #line default
            #line hidden
WriteLiteral("\r\n");


WriteLiteral("\r\n\r\n");


DefineSection("CustomMethods", () => {

WriteLiteral("\r\n       public static class ");


            
            #line 19 "..\..\CodeGen\Specialized\ResponseNote.cshtml"
                       Write("ExtensionsFor" + EnumName);

            
            #line default
            #line hidden
WriteLiteral(" {\r\n            public static bool IsFeed(this ResponseNote note){\r\n             " +
"    switch( note ){\r\n");


            
            #line 22 "..\..\CodeGen\Specialized\ResponseNote.cshtml"
                    foreach( var k in Enums.Keys.Where(k => k.EndsWith("FEED")) ) { 

            
            #line default
            #line hidden
WriteLiteral("                        ");

WriteLiteral("case ResponseNote.");


            
            #line 23 "..\..\CodeGen\Specialized\ResponseNote.cshtml"
                                       Write(k);

            
            #line default
            #line hidden
WriteLiteral(":\r\n");



WriteLiteral("                            ");

WriteLiteral("return true;\r\n");


            
            #line 25 "..\..\CodeGen\Specialized\ResponseNote.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    default:\r\n                        return false;\r\n            " +
"     }\r\n            }\r\n      }\r\n");


});

WriteLiteral("\r\n\r\n\r\n");


        }
    }
}
#pragma warning restore 1591
