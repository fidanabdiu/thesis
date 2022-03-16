using System.Collections.Generic;
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
