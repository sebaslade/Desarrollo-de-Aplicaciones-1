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
    
    public partial class Tb_UnidadMedida
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_UnidadMedida()
        {
            this.Tb_Producto = new HashSet<Tb_Producto>();
        }
    
        public int Id_UM { get; set; }
        public string Des_UM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Producto> Tb_Producto { get; set; }
    }
}
