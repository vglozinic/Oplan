﻿

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
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class EntitiesSettings : DbContext
{
    public EntitiesSettings()
        : base("name=EntitiesSettings")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<korisnik> korisnik { get; set; }

    public virtual DbSet<plan> plan { get; set; }

    public virtual DbSet<pripadnost> pripadnost { get; set; }

    public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

    public virtual DbSet<vrsta> vrsta { get; set; }

    public virtual DbSet<promjena> promjena { get; set; }

    public virtual DbSet<tip_postrojbe> tip_postrojbe { get; set; }

    public virtual DbSet<oprema> oprema { get; set; }

    public virtual DbSet<tip_opreme> tip_opreme { get; set; }

    public virtual DbSet<zemlja> zemlja { get; set; }

    public virtual DbSet<postrojba> postrojba { get; set; }

    public virtual DbSet<tocka> tocka { get; set; }

}

}

