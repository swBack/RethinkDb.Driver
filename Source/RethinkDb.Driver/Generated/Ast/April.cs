








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class April : ReqlQuery {
    
    
        public April (object arg) : this(new Arguments(arg), null) {
        }
        public April (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public April (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.APRIL, args, optargs) {
        }

    protected April (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static April FromArgs(params object[] args){
         return new April (new Arguments(args), null);
        }


    

    


    
    }
}
