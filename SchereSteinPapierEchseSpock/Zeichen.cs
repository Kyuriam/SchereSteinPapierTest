using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeichenKlasse
{
    // Die Klasse Zeichen sind die jeweiligen Handzeichen,
    // mit dem string name und dem string array besiegt ( alle Zeichen gegen das jeweilige Zeichen gewinnt )
    public class Zeichen
    {
        string name;
        string[] besiegt;

        public Zeichen(string a, string[] b)
        {
            this.name = a;
            this.besiegt = b;
        }

        // Gibt einen Wahrheitswert wieder,
        // je nachdem ob 'this' Zeichen gegen KontrahentZeichen gewinnt (true) oder verliert (false)
        public bool besiegtZeichen(Zeichen KontrahentZeichen)
        {
            return this.besiegt.Contains(KontrahentZeichen.getName());
        }

        // Gibt den Namen des Zeichens aus
        public string getName()
        {
            return this.name;
        }

        // Gibt den array mit den Namen gegen den das Zeichen gewinnt aus
        public string[] getBesiegt()
        {
            return this.besiegt;
        }
    }
}