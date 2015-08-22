








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class Split : ReqlQuery {
    
    
        public Split (object arg) : this(new Arguments(arg), null) {
        }
        public Split (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Split (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.SPLIT, args, optargs) {
        }

    protected Split (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static Split FromArgs(params object[] args){
         return new Split (new Arguments(args), null);
        }


    

    


    
    }
}
