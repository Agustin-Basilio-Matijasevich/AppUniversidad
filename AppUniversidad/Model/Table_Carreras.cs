//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppUniversidad.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_Carreras
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table_Carreras()
        {
            this.Table_Carrera_Materia = new HashSet<Table_Carrera_Materia>();
            this.Table_Carrera_Alumno = new HashSet<Table_Carrera_Alumno>();
            this.Table_Carrera_Alumno1 = new HashSet<Table_Carrera_Alumno>();
        }
    
        public int ID { get; set; }
        public Nullable<int> id_Materia { get; set; }
        public string Materia { get; set; }
        public string Carrera { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Carrera_Materia> Table_Carrera_Materia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Carrera_Alumno> Table_Carrera_Alumno { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Carrera_Alumno> Table_Carrera_Alumno1 { get; set; }
    }
}
