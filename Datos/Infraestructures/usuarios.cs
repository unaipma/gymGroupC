//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos.Infraestructures
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuarios()
        {
            this.actividades = new HashSet<actividades>();
        }
    
        public string DNI { get; set; }
        public string EMAIL { get; set; }
        public string PASS { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDOS { get; set; }
        public Nullable<int> TELEFONO { get; set; }
        public string DIRECCION { get; set; }
        public string CCC { get; set; }
        public string PRIVILEGIO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<actividades> actividades { get; set; }
    }
}
