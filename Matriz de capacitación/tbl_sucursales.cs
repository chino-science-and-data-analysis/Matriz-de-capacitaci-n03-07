//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Matriz_de_capacitación
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_sucursales
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_sucursales()
        {
            this.tbl_colaboradores = new HashSet<tbl_colaboradores>();
        }
    
        public int Id_Sucursal { get; set; }
        public string Nombre { get; set; }
        public string Estatus { get; set; }
        public string Estado { get; set; }
        public string Calle_Numero { get; set; }
        public string Colonia { get; set; }
        public int Id_Alcaldia { get; set; }
        public Nullable<int> Codigo_Postal { get; set; }
        public Nullable<int> Zona { get; set; }
        public string Comentarios { get; set; }
        public string Observaciones { get; set; }
    
        public virtual tbl_alcaldias tbl_alcaldias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_colaboradores> tbl_colaboradores { get; set; }
    }
}
