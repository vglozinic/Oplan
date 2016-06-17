﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oplan
{
    class RadSKorisnicima
    {
        static public void PrikaziKorisnike(BindingSource korisnikBindingSource)
        {
            BindingList<korisnik> listaKorisnika = null;
            using (var db = new EntitiesSettings())
            {
                listaKorisnika = new BindingList<korisnik>(db.korisnik.ToList());
            }
            korisnikBindingSource.DataSource = listaKorisnika;
        }

        static public void DodajKorisnika(BindingSource korisnikBindingSource)
        {
            frmKorisnik formaKorisnik = new frmKorisnik();
            formaKorisnik.ShowDialog();
            PrikaziKorisnike(korisnikBindingSource);
        }

        static public void IzbrisiKorisnika(BindingSource korisnikBindingSource)
        {
            korisnik korisnik = korisnikBindingSource.Current as korisnik;
            if (Izvjestaji.ProvjeriIzvjestaj(korisnik.id_korisnik))
            {
                if (MessageBox.Show("Za ovog korisnika postoji izvještaj. Želite li obrisati i izvještaj?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    Izvjestaji.IzbrisiIzvjestaj(korisnik.id_korisnik);
                    using (var db = new EntitiesSettings())
                    {
                        db.korisnik.Attach(korisnik);
                        db.korisnik.Remove(korisnik);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Uspješno ste izbrisali korisnika i njegov izvještaj.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PrikaziKorisnike(korisnikBindingSource);
                }
            }
            else
            {
                if (MessageBox.Show("Jeste li sigurni da želite obrisati ovog korisnika?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new EntitiesSettings())
                    {
                        db.korisnik.Attach(korisnik);
                        db.korisnik.Remove(korisnik);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Uspješno ste izbrisali korisnika.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PrikaziKorisnike(korisnikBindingSource);
                }
            }
        }

        static public void IzmijeniKorisnika(BindingSource korisnikBindingSource)
        {
            if (korisnikBindingSource.Current as korisnik != null)
            {
                frmKorisnik formaKorisnik = new frmKorisnik(korisnikBindingSource.Current as korisnik);
                formaKorisnik.ShowDialog();
                PrikaziKorisnike(korisnikBindingSource);
            }
        }
    }
}