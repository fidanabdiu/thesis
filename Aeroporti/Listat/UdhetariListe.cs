﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BiznesLogjika;

namespace Aeroporti.Listat
{
    public class UdhetariListe : ListViewItem
    {
        private Udhetari aUdhetari;

        public UdhetariListe(Udhetari u)
        {
            aUdhetari = u;
            VendoseUdhetarin();
        }

        public void VendoseUdhetarin()
        {
            SubItems.Clear();

            Text = aUdhetari.Emri + " " + aUdhetari.Mbiemri;
            SubItems.Add(aUdhetari.NumriIdentifikues);
            SubItems.Add(aUdhetari.DokumentiIdentifikues.ToString());
            SubItems.Add(aUdhetari.Datelindja.ToShortDateString());
            SubItems.Add(aUdhetari.Vendlindja);
            SubItems.Add(aUdhetari.Vendbanimi);
            SubItems.Add(aUdhetari.Adresa);
            SubItems.Add(aUdhetari.TelefoniFiks);
            SubItems.Add(aUdhetari.TelefoniMobil);
            SubItems.Add(aUdhetari.Emaili);
            SubItems.Add(aUdhetari.PerdoruesiAgjensionit.Agjensioni.ToString());
        }

        public Udhetari UdhetariIZgjedhur
        {
            get { return aUdhetari; }
        }
    }
}
