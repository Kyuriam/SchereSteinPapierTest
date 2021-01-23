using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchereSteinPapierEchseSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            // Alle Zeichen die mitspielen sollen werden initialisiert
            Schere = new Zeichen("Schere", new string[] { "Papier", "Echse" });
            Stein  = new Zeichen("Stein" , new string[] { "Schere", "Echse" });
            Papier = new Zeichen("Papier", new string[] { "Stein" , "Spock" });
            Echse  = new Zeichen("Echse" , new string[] { "Papier", "Spock" });
            Spock  = new Zeichen("Spock" , new string[] { "Schere", "Stein" });
        }

        // Die Klasse Zeichen sind die jeweiligen Handzeichen,
        // mit dem string name und dem string array besiegt ( alle Zeichen gegen das jeweilige Zeichen gewinnt )
        public class Zeichen()
        {
            string name = a;
            string[] besiegt = b;

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
}