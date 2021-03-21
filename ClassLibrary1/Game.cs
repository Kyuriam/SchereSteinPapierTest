using System;
using ZeichenKlasse;

namespace Spiellogik
{
    public static class Game
    {
        // Zufällige Zahl zwischen min-max wird erzeugt
        public static int Zufallszahl(int min, int max)
        {
            Random zahl = new Random();
            int ergebnis = (int)zahl.Next(min, max++);
            return ergebnis;
        }

        // Methode zum ermitteln eines Siegers zwischen Zeichen a und b
        public static Zeichen WerGewinnt(Zeichen a, Zeichen b)
        {
            // Zeichen a gewinnt
            if (a.besiegtZeichen(b))
            {
                return a;
            }
            // Zeichen b gewinnt
            if (b.besiegtZeichen(a))
            {
                return b;
            }
            // Unentschieden ( gleiche Zeichen )
            return null;            
        }

    }
}