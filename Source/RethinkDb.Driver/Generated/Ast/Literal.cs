








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class Literal : ReqlQuery {
    
    
        public Literal (object arg) : this(new Arguments(arg), null) {
        }
        public Literal (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Literal (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.LITERAL, args, optargs) {
        }

    protected Literal (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static Literal FromArgs(params object[] args){
         return new Literal (new Arguments(args), null);
        }


    

    


    
    }
}
