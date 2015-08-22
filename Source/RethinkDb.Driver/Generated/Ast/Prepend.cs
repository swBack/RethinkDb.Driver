








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class Prepend : ReqlQuery {
    
    
        public Prepend (object arg) : this(new Arguments(arg), null) {
        }
        public Prepend (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Prepend (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.PREPEND, args, optargs) {
        }

    protected Prepend (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static Prepend FromArgs(params object[] args){
         return new Prepend (new Arguments(args), null);
        }


    

    


    
    }
}
