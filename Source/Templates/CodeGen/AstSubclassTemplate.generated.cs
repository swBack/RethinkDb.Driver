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

namespace Templates.CodeGen
{
    
    #line 2 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using System;
    
    #line default
    #line hidden
    
    #line 3 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 4 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 5 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using System.Security.Cryptography;
    
    #line default
    #line hidden
    
    #line 6 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 7 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using Humanizer;
    
    #line default
    #line hidden
    
    #line 8 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using Newtonsoft.Json;
    
    #line default
    #line hidden
    
    #line 9 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using Newtonsoft.Json.Linq;
    
    #line default
    #line hidden
    
    #line 10 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using RazorGenerator.Templating;
    
    #line default
    #line hidden
    
    #line 11 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using Templates.CodeGen;
    
    #line default
    #line hidden
    
    #line 12 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using Templates.CodeGen.Util;
    
    #line default
    #line hidden
    
    #line 13 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using Templates.Metadata;
    
    #line default
    #line hidden
    
    #line 14 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using Z.ExtensionMethods;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class AstSubclassTemplate : BaseTemplate
    {
#line hidden

        #line 18 "..\..\CodeGen\AstSubclassTemplate.cshtml"

    public string ClassName { get; set; }
    public string Superclass { get; set; }

    public string TermName { get; set; }
    public JObject TermMeta { get; set; }
    public Dictionary<string, JObject> AllTerms { get; set; }

    public override RazorTemplateBase UseParentLayout(RazorTemplateBase child)
    {
        return new AstSubclassTemplate()
        {
            ClassName = this.ClassName,
            Superclass = this.Superclass,
            TermName = this.TermName,
            TermMeta = this.TermMeta,
            AllTerms = this.AllTerms,
            ChildTemplate = child
        };
    }
    
    private string[] RenderSigArgs(Signature.SigArg[] sigArgs)
    {
        return sigArgs.Select(arg => $"{ArgumentType(arg.Type)} {ArgumentVariable(arg.Var)}").ToArray();
    }

    protected static Dictionary<string, string[]> EnumerableHelpers = new Dictionary<string, string[]>()
        {
            {
                "GetAll", new[] {"ICollection<string>", "ICollection<Guid>"}
            },
            {
                "HasFields", new[] {"ICollection<string>"}
            }
            ,
            {
                "WithFields", new[] {"ICollection<string>"}
            }
            ,
            {
                "Pluck", new[] {"ICollection<string>"}
            }
            ,
            {
                "Without", new[] {"ICollection<string>"}
            }
            ,
            {
                "IndexStatus", new[] {"ICollection<string>"}
            }
            ,
            {
                "IndexWait", new[] {"ICollection<string>"}
            }
        };


        #line default
        #line hidden
#line hidden
public System.Web.WebPages.HelperResult RenderCtorXmlDoc(string term)
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 77 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    
    Documentation doc;
    if( MetaDb.Docs.TryGetValue(term, out doc) )
    {

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "/// <summary>\r\n");



WriteLiteralTo(@__razor_helper_writer, "/// ");



#line 82 "..\..\CodeGen\AstSubclassTemplate.cshtml"
WriteTo(@__razor_helper_writer, doc.Description);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\r\n");



WriteLiteralTo(@__razor_helper_writer, "/// </summary>\r\n");



WriteLiteralTo(@__razor_helper_writer, "/// <example>");



#line 84 "..\..\CodeGen\AstSubclassTemplate.cshtml"
WriteTo(@__razor_helper_writer, doc.Example);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "</example>\r\n");



#line 85 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    };

#line default
#line hidden

});

}


        public override void Execute()
        {


WriteLiteral("\r\n");














WriteLiteral("\r\n");


WriteLiteral("\r\n");


WriteLiteral("\r\n\r\n");



WriteLiteral("\r\n\r\n");


DefineSection("Ctors", () => {

WriteLiteral("\r\n");


            
            #line 89 "..\..\CodeGen\AstSubclassTemplate.cshtml"
     if( this.TermName != null )
    {
        
            
            #line default
            #line hidden
            
            #line 91 "..\..\CodeGen\AstSubclassTemplate.cshtml"
   Write(RenderCtorXmlDoc(this.TermName));

            
            #line default
            #line hidden
            
            #line 91 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                        

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("public ");


            
            #line 92 "..\..\CodeGen\AstSubclassTemplate.cshtml"
            Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" (object arg) : this(new Arguments(arg), null) {\r\n");



WriteLiteral("        ");

WriteLiteral("}\r\n");


            
            #line 94 "..\..\CodeGen\AstSubclassTemplate.cshtml"

        
            
            #line default
            #line hidden
            
            #line 95 "..\..\CodeGen\AstSubclassTemplate.cshtml"
   Write(RenderCtorXmlDoc(this.TermName));

            
            #line default
            #line hidden
            
            #line 95 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                        

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("public ");


            
            #line 96 "..\..\CodeGen\AstSubclassTemplate.cshtml"
            Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" (Arguments args) : this(args, null) {\r\n");



WriteLiteral("        ");

WriteLiteral("}\r\n");


            
            #line 98 "..\..\CodeGen\AstSubclassTemplate.cshtml"

        
            
            #line default
            #line hidden
            
            #line 99 "..\..\CodeGen\AstSubclassTemplate.cshtml"
   Write(RenderCtorXmlDoc(this.TermName));

            
            #line default
            #line hidden
            
            #line 99 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                        

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("public ");


            
            #line 100 "..\..\CodeGen\AstSubclassTemplate.cshtml"
            Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" (Arguments args, OptArgs optargs)\r\n");



WriteLiteral("        ");

WriteLiteral(" : base(TermType.");


            
            #line 101 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                      Write(TermName);

            
            #line default
            #line hidden
WriteLiteral(", args, optargs) {\r\n");



WriteLiteral("        ");

WriteLiteral("}\r\n");


            
            #line 103 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("protected ");


            
            #line 106 "..\..\CodeGen\AstSubclassTemplate.cshtml"
               Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, opta" +
"rgs)\r\n");



WriteLiteral("        ");

WriteLiteral("{\r\n");



WriteLiteral("        ");

WriteLiteral("}\r\n");


            
            #line 109 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    }

            
            #line default
            #line hidden

});

WriteLiteral("\r\n\r\n");


DefineSection("StaticFactories", () => {

WriteLiteral("\r\n\r\n");


});

WriteLiteral("\r\n\r\n");


DefineSection("OptArgs", () => {

WriteLiteral("\r\n");


            
            #line 117 "..\..\CodeGen\AstSubclassTemplate.cshtml"
     if( TermMeta?["optargs"] != null )
    {
        var optArgs = TermMeta["optargs"] as JObject;

            
            #line default
            #line hidden
WriteLiteral("///<summary>\r\n");



WriteLiteral("/// ");


            
            #line 121 "..\..\CodeGen\AstSubclassTemplate.cshtml"
 Write(optArgs.ToString().Trim('{', '}').Trim().Replace("\n","\n///"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");



WriteLiteral("///</summary>\r\n");



WriteLiteral("        ");

WriteLiteral("public ");


            
            #line 123 "..\..\CodeGen\AstSubclassTemplate.cshtml"
            Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" this[object optArgs] {\r\n");



WriteLiteral("        ");

WriteLiteral("    get\r\n");



WriteLiteral("        ");

WriteLiteral("    {\r\n");



WriteLiteral("        ");

WriteLiteral("        var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);\r\n");



WriteLiteral("        ");

WriteLiteral("\r\n");



WriteLiteral("        ");

WriteLiteral("        return new ");


            
            #line 128 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                        Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" (this.Args, newOptArgs);\r\n");



WriteLiteral("        ");

WriteLiteral("    }\r\n");



WriteLiteral("        ");

WriteLiteral("}\r\n");



WriteLiteral("        ");

WriteLiteral("\r\n");



WriteLiteral("///<summary>\r\n");



WriteLiteral("/// ");


            
            #line 133 "..\..\CodeGen\AstSubclassTemplate.cshtml"
 Write(optArgs.ToString().Trim('{', '}').Trim().Replace("\n", "\n///"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");



WriteLiteral("///</summary>\r\n");



WriteLiteral("    ");

WriteLiteral("public ");


            
            #line 135 "..\..\CodeGen\AstSubclassTemplate.cshtml"
        Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" this[OptArgs optArgs] {\r\n");



WriteLiteral("    ");

WriteLiteral("    get\r\n");



WriteLiteral("    ");

WriteLiteral("    {\r\n");



WriteLiteral("    ");

WriteLiteral("        var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);\r\n");



WriteLiteral("    ");

WriteLiteral("\r\n");



WriteLiteral("    ");

WriteLiteral("        return new ");


            
            #line 140 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                    Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" (this.Args, newOptArgs);\r\n");



WriteLiteral("    ");

WriteLiteral("    }\r\n");



WriteLiteral("    ");

WriteLiteral("}\r\n");



WriteLiteral("    ");

WriteLiteral("\r\n");



WriteLiteral("///<summary>\r\n");



WriteLiteral("/// ");


            
            #line 145 "..\..\CodeGen\AstSubclassTemplate.cshtml"
 Write(optArgs.ToString().Trim('{', '}').Trim().Replace("\n","\n///"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");



WriteLiteral("///</summary>\r\n");



WriteLiteral("        ");

WriteLiteral("public ");


            
            #line 147 "..\..\CodeGen\AstSubclassTemplate.cshtml"
            Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" OptArg(string key, object val){\r\n");



WriteLiteral("        ");

WriteLiteral("    \r\n");



WriteLiteral("        ");

WriteLiteral("    var newOptArgs = OptArgs.FromMap(this.OptArgs).With(key, val);\r\n");



WriteLiteral("        ");

WriteLiteral("\r\n");



WriteLiteral("        ");

WriteLiteral("    return new ");


            
            #line 151 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                    Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" (this.Args, newOptArgs);\r\n");



WriteLiteral("        ");

WriteLiteral("}\r\n");



WriteLiteral("        ");

WriteLiteral("internal ");


            
            #line 153 "..\..\CodeGen\AstSubclassTemplate.cshtml"
              Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" optArg(string key, object val){\r\n");



WriteLiteral("        ");

WriteLiteral("\r\n");



WriteLiteral("        ");

WriteLiteral("    return this.OptArg(key, val);\r\n");



WriteLiteral("        ");

WriteLiteral("}\r\n");


            
            #line 157 "..\..\CodeGen\AstSubclassTemplate.cshtml"
     }

            
            #line default
            #line hidden

});

WriteLiteral("\r\n\r\n");


DefineSection("ReqlExprHelpers", () => {

WriteLiteral("\r\n");



WriteLiteral("\r\n    \r\n");


            
            #line 176 "..\..\CodeGen\AstSubclassTemplate.cshtml"
     if (Superclass == "ReqlExpr")
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("/// <summary>\r\n");



WriteLiteral("        ");

WriteLiteral("/// Get a single field from an object. If called on a sequence, gets that field f" +
"rom every object in the sequence, skipping objects that lack it.\r\n");



WriteLiteral("        ");

WriteLiteral("/// </summary>\r\n");



WriteLiteral("        ");

WriteLiteral("/// <param name=\"bracket\"></param>\r\n");


            
            #line 182 "..\..\CodeGen\AstSubclassTemplate.cshtml"
        
            
            #line default
            #line hidden

            
            #line 182 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                                  

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("public new Bracket this[string bracket] => base[bracket];\r\n");



WriteLiteral("        ");

WriteLiteral("\r\n");



WriteLiteral("        ");

WriteLiteral("/// <summary>\r\n");



WriteLiteral("        ");

WriteLiteral("/// Get the nth element of a sequence, counting from zero. If the argument is neg" +
"ative, count from the last element.\r\n");



WriteLiteral("        ");

WriteLiteral("/// </summary>\r\n");



WriteLiteral("        ");

WriteLiteral("/// <param name=\"bracket\"></param>\r\n");



WriteLiteral("        ");

WriteLiteral("/// <returns></returns>\r\n");


            
            #line 190 "..\..\CodeGen\AstSubclassTemplate.cshtml"
        
            
            #line default
            #line hidden

            
            #line 190 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                                  

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("public new Bracket this[int bracket] => base[bracket];\r\n");


            
            #line 192 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    }

            
            #line default
            #line hidden

});

WriteLiteral(@"

//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591 // Missing XML comment for publicly visible type or member
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;
");


            
            #line 207 "..\..\CodeGen\AstSubclassTemplate.cshtml"
Write(RenderSection("add_imports"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\nnamespace RethinkDb.Driver.Ast {\r\n\r\n    public partial class ");


            
            #line 211 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                    Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" : ");


            
            #line 211 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                        Write(Superclass);

            
            #line default
            #line hidden
WriteLiteral(" {\r\n\r\n    ");


            
            #line 213 "..\..\CodeGen\AstSubclassTemplate.cshtml"
Write(RenderSection("MemberVars"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    \r\n    ");


            
            #line 215 "..\..\CodeGen\AstSubclassTemplate.cshtml"
Write(RenderSection("Ctors"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    ");


            
            #line 217 "..\..\CodeGen\AstSubclassTemplate.cshtml"
Write(RenderSection("StaticFactories"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    ");


            
            #line 219 "..\..\CodeGen\AstSubclassTemplate.cshtml"
Write(RenderSection("OptArgs"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    ");


            
            #line 221 "..\..\CodeGen\AstSubclassTemplate.cshtml"
Write(RenderSection("ReqlExprHelpers"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    ");


            
            #line 223 "..\..\CodeGen\AstSubclassTemplate.cshtml"
Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    ");


            
            #line 225 "..\..\CodeGen\AstSubclassTemplate.cshtml"
Write(RenderSection("SpecialMethods"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");


            
            #line 227 "..\..\CodeGen\AstSubclassTemplate.cshtml"
     foreach( var termInfo in AllTerms )
    {
        var term = termInfo.Key;
        var info = termInfo.Value;


        if( info["include_in"].ToObject<string[]>().Any(inc => string.Equals(inc, ClassName, StringComparison.OrdinalIgnoreCase)) )
        { // is the current term included in this class we're generating?
            foreach( var rawMethodName in info["methodnames"].ToObject<string[]>() )
            {
                foreach( var signature in info["signatures"].ToObject<Signature[]>() )
                {
                    if( signature.FirstArg == ClassName )
                    {
                        Signature.SigArg[] remainingArgs;
                        if( signature.Args[0].IsParams() ) // for r.term(params object[] foo)
                        {
                            remainingArgs = signature.Args;
                        }
                        else
                        {
                            remainingArgs = signature.Args.Skip(1).ToArray();
                        }
                        var className = Class(info["classname"].ToString());
                        var methodName = Method(rawMethodName);
                        var internalMethodName = MethodInternalName(rawMethodName);

                        
            
            #line default
            #line hidden
            
            #line 254 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                   Write(RenderCtorXmlDoc(term));

            
            #line default
            #line hidden
            
            #line 254 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                               

            
            #line default
            #line hidden
WriteLiteral("                        ");

WriteLiteral("public ");


            
            #line 255 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                            Write(className);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 255 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                       Write(methodName);

            
            #line default
            #line hidden
WriteLiteral(" ( ");


            
            #line 255 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                                     Write(string.Join(", ", RenderSigArgs(remainingArgs) ));

            
            #line default
            #line hidden
WriteLiteral(" )\r\n");



WriteLiteral("                        ");

WriteLiteral("{\r\n");


            
            #line 257 "..\..\CodeGen\AstSubclassTemplate.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                        ");

WriteLiteral("    Arguments arguments = new Arguments(this);\r\n");


            
            #line 259 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                        foreach( var param in remainingArgs )
                        {
                            if( param.IsParams() )
                            {

            
            #line default
            #line hidden
WriteLiteral("                            ");

WriteLiteral("arguments.CoerceAndAddAll(");


            
            #line 263 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                                   Write(ArgumentVariable(param.Var));

            
            #line default
            #line hidden
WriteLiteral(");\r\n");


            
            #line 264 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                            ");

WriteLiteral("arguments.CoerceAndAdd(");


            
            #line 267 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                                Write(ArgumentVariable(param.Var));

            
            #line default
            #line hidden
WriteLiteral(");\r\n");


            
            #line 268 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                            }
                        }

            
            #line default
            #line hidden
WriteLiteral("                        ");

WriteLiteral("    return new ");


            
            #line 270 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                    Write(className);

            
            #line default
            #line hidden
WriteLiteral(" (arguments );\r\n");


            
            #line 271 "..\..\CodeGen\AstSubclassTemplate.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                        ");

WriteLiteral("}\r\n");


            
            #line 273 "..\..\CodeGen\AstSubclassTemplate.cshtml"

                        //Create a IList helper overload for "params object[] args"
                        string[] helperSigs;
                        if (signature.OnlyHasParams() && EnumerableHelpers.TryGetValue(methodName, out helperSigs))
                        {
                            foreach (var helperSig in helperSigs)
                            {
                            
            
            #line default
            #line hidden
            
            #line 280 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                       Write(RenderCtorXmlDoc(term));

            
            #line default
            #line hidden
            
            #line 280 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                                   

            
            #line default
            #line hidden
WriteLiteral("                            ");

WriteLiteral("/// <param name=\"args\">Same as calling params object[] overload, except the colle" +
"ction is applied as object[] params.</param>\r\n");



WriteLiteral("                            ");

WriteLiteral("public ");


            
            #line 282 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                Write(className);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 282 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                           Write(methodName);

            
            #line default
            #line hidden
WriteLiteral(" ( ");


            
            #line 282 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                                         Write(helperSig);

            
            #line default
            #line hidden
WriteLiteral(" args )\r\n");



WriteLiteral("                            ");

WriteLiteral("{\r\n");



WriteLiteral("                                ");

WriteLiteral("var arguments = new Arguments(this);\r\n");



WriteLiteral("                                ");

WriteLiteral("arguments.CoerceAndAddAll(args);\r\n");



WriteLiteral("                                ");

WriteLiteral("return new ");


            
            #line 286 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                        Write(className);

            
            #line default
            #line hidden
WriteLiteral(" (arguments);\r\n");



WriteLiteral("                            ");

WriteLiteral("}\r\n");


            
            #line 288 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                            }
                        }

                        //Internal API for Unit Tests

            
            #line default
            #line hidden
WriteLiteral("                        ");

WriteLiteral("internal ");


            
            #line 292 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                              Write(className);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 292 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                         Write(internalMethodName);

            
            #line default
            #line hidden
WriteLiteral(" ( ");


            
            #line 292 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                                               Write(string.Join(", ", RenderSigArgs(remainingArgs) ));

            
            #line default
            #line hidden
WriteLiteral(" )\r\n");



WriteLiteral("                        ");

WriteLiteral("{\r\n");



WriteLiteral("                        ");

WriteLiteral("   return ");


            
            #line 294 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                               Write(methodName);

            
            #line default
            #line hidden
WriteLiteral(" ( ");


            
            #line 294 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                             Write(string.Join(", ", remainingArgs.Select(arg => $"{ArgumentVariable(arg.Var)}").ToArray()));

            
            #line default
            #line hidden
WriteLiteral(" );\r\n");



WriteLiteral("                        ");

WriteLiteral("}\r\n");


            
            #line 296 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                    }
                }
            }

        }
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    \r\n    }\r\n}\r\n");


        }
    }
}
#pragma warning restore 1591
