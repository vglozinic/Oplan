
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
    
public partial class tocka
{

    public int id_tocka { get; set; }

    public double koord_x { get; set; }

    public double koord_y { get; set; }

    public string sadrzi_marker { get; set; }

    public int id_ruta { get; set; }



    public virtual ruta ruta { get; set; }

}

}
