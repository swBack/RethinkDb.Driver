








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class July : ReqlQuery {
    
    
        public July (object arg) : this(new Arguments(arg), null) {
        }
        public July (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public July (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.JULY, args, optargs) {
        }

    protected July (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static July FromArgs(params object[] args){
         return new July (new Arguments(args), null);
        }


    

    


    
    }
}
