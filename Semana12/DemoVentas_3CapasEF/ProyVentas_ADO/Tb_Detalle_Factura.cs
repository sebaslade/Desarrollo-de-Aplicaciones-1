//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyVentas_ADO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_Detalle_Factura
    {
        public string Num_fac { get; set; }
        public string Cod_pro { get; set; }
        public int Can_ven { get; set; }
        public float Pre_ven { get; set; }
    
        public virtual Tb_Producto Tb_Producto { get; set; }
        public virtual Tb_Factura Tb_Factura { get; set; }
    }
}
