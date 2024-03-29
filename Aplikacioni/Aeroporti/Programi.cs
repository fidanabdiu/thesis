﻿using System;
using System.Windows.Forms;
using Aeroporti.Format;

namespace Aeroporti
{
    static class Programi
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Kycja forma = new Kycja();

            if (forma.ShowDialog() == DialogResult.OK)
                Application.Run(new FormaKryesore());
            else
                Application.Exit();
        }
    }
}
