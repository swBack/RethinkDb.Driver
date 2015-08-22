








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class Keys : ReqlQuery {
    
    
        public Keys (object arg) : this(new Arguments(arg), null) {
        }
        public Keys (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Keys (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.KEYS, args, optargs) {
        }

    protected Keys (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static Keys FromArgs(params object[] args){
         return new Keys (new Arguments(args), null);
        }


    

    


    
    }
}
