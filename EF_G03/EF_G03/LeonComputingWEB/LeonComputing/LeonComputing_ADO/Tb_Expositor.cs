//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeonComputing_ADO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_Expositor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Expositor()
        {
            this.Tb_Evento = new HashSet<Tb_Evento>();
            this.Tb_Expositor_Empresa = new HashSet<Tb_Expositor_Empresa>();
            this.Tb_Especialidad = new HashSet<Tb_Especialidad>();
        }
    
        public string Id_Expositor { get; set; }
        public string Apellido_materno { get; set; }
        public string Apellido_paterno { get; set; }
        public string Nombre { get; set; }
        public string Dirección { get; set; }
        public string Telefono { get; set; }
        public string E_mail { get; set; }
        public string DNI { get; set; }
        public string Foto_Expositor { get; set; }
        public string Comentario { get; set; }
        public string Id_Ubigeo { get; set; }
        public Nullable<System.DateTime> fecha_registro { get; set; }
        public string usuario_ult_modificacion { get; set; }
        public Nullable<System.DateTime> fecha_ult_modificacion { get; set; }
        public Nullable<int> estado_exp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Evento> Tb_Evento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Expositor_Empresa> Tb_Expositor_Empresa { get; set; }
        public virtual Tb_Ubigeo Tb_Ubigeo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Especialidad> Tb_Especialidad { get; set; }
    }
}
