








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class Db : ReqlAst {
    
    
        public Db (object arg) : this(new Arguments(arg), null) {
        }
        public Db (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Db (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.DB, args, optargs) {
        }

    protected Db (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static Db FromArgs(params object[] args){
         return new Db (new Arguments(args), null);
        }


    

    

            public Table table (params object[] fields){
                    return new Table (this, new Arguments(fields), new OptArgs());
            }
            public TableCreate tableCreate (params object[] fields){
                    return new TableCreate (this, new Arguments(fields), new OptArgs());
            }
            public TableDrop tableDrop (params object[] fields){
                    return new TableDrop (this, new Arguments(fields), new OptArgs());
            }
            public TableList tableList (params object[] fields){
                    return new TableList (this, new Arguments(fields), new OptArgs());
            }
            public Config config (params object[] fields){
                    return new Config (this, new Arguments(fields), new OptArgs());
            }
            public Wait wait (params object[] fields){
                    return new Wait (this, new Arguments(fields), new OptArgs());
            }
            public Reconfigure reconfigure (params object[] fields){
                    return new Reconfigure (this, new Arguments(fields), new OptArgs());
            }
            public Rebalance rebalance (params object[] fields){
                    return new Rebalance (this, new Arguments(fields), new OptArgs());
            }

    
    }
}
