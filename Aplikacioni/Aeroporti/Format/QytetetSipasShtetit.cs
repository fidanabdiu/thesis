using System.Collections.Generic;
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
