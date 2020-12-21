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
    public partial class QytetetSipasShtetit : FormatBaze.InformataBaze
    {
        private List<Qyteti> aQytetet;
        
        public QytetetSipasShtetit(List<Qyteti> lq)
        {
            InitializeComponent();

            aQytetet = lq;
            VendosiQytetet();
        }

        private void VendosiQytetet()
        {
            lvQytetet.Items.Clear();

            foreach (Qyteti q in aQytetet)
                lvQytetet.Items.Add(new QytetiListe(q));
        }
    }
}
