








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class DayOfYear : ReqlQuery {
    
    
        public DayOfYear (object arg) : this(new Arguments(arg), null) {
        }
        public DayOfYear (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public DayOfYear (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.DAY_OF_YEAR, args, optargs) {
        }

    protected DayOfYear (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static DayOfYear FromArgs(params object[] args){
         return new DayOfYear (new Arguments(args), null);
        }


    

    


    
    }
}
