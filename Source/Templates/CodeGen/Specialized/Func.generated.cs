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
    
    #line 2 "..\..\CodeGen\Specialized\Func.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 3 "..\..\CodeGen\Specialized\Func.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 4 "..\..\CodeGen\Specialized\Func.cshtml"
    using Humanizer;
    
    #line default
    #line hidden
    
    #line 5 "..\..\CodeGen\Specialized\Func.cshtml"
    using Newtonsoft.Json.Linq;
    
    #line default
    #line hidden
    
    #line 6 "..\..\CodeGen\Specialized\Func.cshtml"
    using Templates.CodeGen;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class Func : AstSubclassTemplate
    {
#line hidden

        #line 36 "..\..\CodeGen\Specialized\Func.cshtml"

    

        #line default
        #line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");






WriteLiteral("\r\n");


WriteLiteral("\r\n");


            
            #line 10 "..\..\CodeGen\Specialized\Func.cshtml"
  
    this.Layout = UseParentLayout(this);


            
            #line default
            #line hidden
WriteLiteral("\r\n");


DefineSection("Ctors", () => {

WriteLiteral(@"
   public Func(ReqlFunction function) : this(Arguments.make(
            new MakeArray(new Arguments(1), null),
                Util.toReqlAst(function.apply(new Var(1)))))
    {
    }

    public Func(ReqlFunction2 function) :
        this(Arguments.make(
            new MakeArray(Arguments.make(1, 2)),
                Util.toReqlAst(function.apply(new Var(1), new Var(1)))))
    {
    }

    protected Func(Arguments args) : base(null, TermType.FUNC, args, null) {
    }
");


});

WriteLiteral("\r\n");


DefineSection("StaticFactories", () => {

WriteLiteral("\r\n    \r\n");


});

WriteLiteral("\r\n\r\n\r\n");


WriteLiteral("\r\n       \r\n      ");


        }
    }
}
#pragma warning restore 1591
