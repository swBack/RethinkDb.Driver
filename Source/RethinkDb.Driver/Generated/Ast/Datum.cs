








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class Datum : ReqlQuery {
    
    
    public Datum(object arg) : base(null, TermType.DATUM, null, null) {
            datum = arg;
        }


    
    


    









       
        protected object datum;



    
    
        protected object build() {
            // Overridden because Datums are leaf-nodes and therefore
            // don't contain lower ReqlAst objects.
            return datum;
        }



    
    }
}
