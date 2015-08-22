








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class Range : ReqlQuery {
    
    
        public Range (object arg) : this(new Arguments(arg), null) {
        }
        public Range (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Range (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.RANGE, args, optargs) {
        }

    protected Range (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static Range FromArgs(params object[] args){
         return new Range (new Arguments(args), null);
        }


    

    


    
    }
}
