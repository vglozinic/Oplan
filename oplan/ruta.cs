
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace oplan
{

using System;
    using System.Collections.Generic;
    
public partial class ruta
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ruta()
    {

        this.tocka = new HashSet<tocka>();

        this.postrojba = new HashSet<postrojba>();

    }


    public int id_ruta { get; set; }

    public int id_pripadnost { get; set; }

    public int id_plan { get; set; }



    public virtual plan plan { get; set; }

    public virtual pripadnost pripadnost { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<tocka> tocka { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<postrojba> postrojba { get; set; }

}

}
