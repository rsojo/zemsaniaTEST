//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zemsaniaTEST.WCF.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class HR_PAGO
    {
        public int CODIGO { get; set; }
        public string COD_EMPRESA { get; set; }
        public string COD_RUBRO_PAGO { get; set; }
        public Nullable<decimal> RESULTADO { get; set; }
        public Nullable<System.DateTime> FECHA_PAGO_ { get; set; }
        public string COD_DEPARTAMENTO { get; set; }
        public string COD_EMPRESA_d { get; set; }
    
        public virtual HR_DEPARTAMENTO HR_DEPARTAMENTO { get; set; }
    }
}
