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
    
    public partial class Tb_Orden_Compra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Orden_Compra()
        {
            this.Tb_Detalle_Compra = new HashSet<Tb_Detalle_Compra>();
        }
    
        public string Num_oco { get; set; }
        public System.DateTime Fec_oco { get; set; }
        public string Cod_prv { get; set; }
        public Nullable<System.DateTime> Fec_ate { get; set; }
        public int Est_oco { get; set; }
        public Nullable<System.DateTime> Fec_Registro { get; set; }
        public string Usu_Registro { get; set; }
        public Nullable<System.DateTime> Fec_Ult_Mod { get; set; }
        public string Usu_Ult_Mod { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Detalle_Compra> Tb_Detalle_Compra { get; set; }
        public virtual Tb_Proveedor Tb_Proveedor { get; set; }
    }
}
