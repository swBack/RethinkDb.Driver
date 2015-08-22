








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class TableDrop : ReqlQuery {
    
    
        public TableDrop (object arg) : this(new Arguments(arg), null) {
        }
        public TableDrop (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public TableDrop (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.TABLE_DROP, args, optargs) {
        }

    protected TableDrop (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static TableDrop FromArgs(params object[] args){
         return new TableDrop (new Arguments(args), null);
        }


    

    


    
    }
}
