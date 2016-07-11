using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiznesLogjika
{
    public enum DokumentiIdentifikues
    {
       Leternjoftim = 0,
       Patente = 1,
       Pasaporte = 2
    }

    public enum Privilegji
    {
        Administrator = 0,
        Punetor = 1
    }

    public enum LlojiIRezervimit
    {
        NjeKahesh = 0,
        Kthyes = 1
    }

    public enum UlesjaEZene
    {
        JO = 0,
        PO = 1
    }

    public enum FluturimiAnuluar
    {
        JO = 0,
        PO = 1
    }
}
