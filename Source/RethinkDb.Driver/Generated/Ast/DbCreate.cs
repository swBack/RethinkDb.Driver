








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class DbCreate : ReqlQuery {
    
    
        public DbCreate (object arg) : this(new Arguments(arg), null) {
        }
        public DbCreate (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public DbCreate (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.DB_CREATE, args, optargs) {
        }

    protected DbCreate (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static DbCreate FromArgs(params object[] args){
         return new DbCreate (new Arguments(args), null);
        }


    

    


    
    }
}
