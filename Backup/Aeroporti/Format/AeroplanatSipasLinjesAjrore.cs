using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BiznesLogjika;
using Aeroporti.Listat;

namespace Aeroporti.Format
{
    public partial class AeroplanatSipasLinjesAjrore : FormatBaze.InformataBaze
    {
        List<Aeroplani> aAeroplanat;
        
        public AeroplanatSipasLinjesAjrore(List<Aeroplani> la)
        {
            InitializeComponent();

            aAeroplanat = la;

            VendosiAeroplanat();
        }

        private void VendosiAeroplanat()
        {
            lvAeroplanat.Items.Clear();

            foreach (Aeroplani a in aAeroplanat)
                lvAeroplanat.Items.Add(new AeroplaniListe(a));
        }
    }
}
