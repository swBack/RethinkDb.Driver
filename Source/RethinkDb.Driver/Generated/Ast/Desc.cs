








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class Desc : ReqlQuery {
    
    
        public Desc (object arg) : this(new Arguments(arg), null) {
        }
        public Desc (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Desc (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.DESC, args, optargs) {
        }

    protected Desc (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static Desc FromArgs(params object[] args){
         return new Desc (new Arguments(args), null);
        }


    

    


    
    }
}
