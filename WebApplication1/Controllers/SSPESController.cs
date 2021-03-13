using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Spiellogik;
using ZeichenKlasse;

namespace WebApplication1.Controllers
{
    public class SSPESController : Controller
    {      
        // Eine Methode, welche einen Spielzug von SchereSteinPapierEchseSpock simuliert
        // Der Parameter 'name' ist ein String welcher den Spielernamen wiederspiegelt
        // Der Parameter 'spielerZeichen' ist ein String welcher das gewählte Zeichen darstellt
        public String Spielzug(String name, String spielerZeichen)
        { 
            // Alle Zeichen die mitspielen sollen werden initialisiert
            Zeichen Schere = new Zeichen("Schere", new string[] { "Papier", "Echse" });
            Zeichen Stein  = new Zeichen("Stein" , new string[] { "Schere", "Echse" });
            Zeichen Papier = new Zeichen("Papier", new string[] { "Stein" , "Spock" });
            Zeichen Echse  = new Zeichen("Echse" , new string[] { "Papier", "Spock" });
            Zeichen Spock  = new Zeichen("Spock" , new string[] { "Schere", "Stein" });

            // Variablen für das Spiel werden initialisiert
            Zeichen gegnerZeichen;
            Zeichen eigenesZeichen;
            Zeichen[] alleZeichen = new Zeichen[] { Schere, Stein, Papier, Echse, Spock };
            int auswahlZahl = Int32.Parse(spielerZeichen);
            eigenesZeichen = alleZeichen[auswahlZahl];

            // Gegnerzeichen wird ein zufälliges Zeichen zugewiesen
            gegnerZeichen = alleZeichen[Game.Zufallszahl(0, 4)];

            // Der Ausgabe String wird initialisiert
            String ausgabe = null;

            // Die Zeichen spielen gegeneinander
            // Unentschieden ( gleiche Zeichen )
            if (Game.WerGewinnt(eigenesZeichen, gegnerZeichen) == null)
            {
                ausgabe += "Unentschieden! " + eigenesZeichen.getName() + " und " + gegnerZeichen.getName() + " sind gleiche Zeichen.";
            }

            // Eigenes Zeichen gewinnt
            if (Game.WerGewinnt(eigenesZeichen, gegnerZeichen) == eigenesZeichen)
            {
                ausgabe += name + " hat gewonnen! " + eigenesZeichen.getName() + " schlägt " + gegnerZeichen.getName() + ".";
            }

            // Gegnerisches Zeichen gewinnt
            if (Game.WerGewinnt(eigenesZeichen, gegnerZeichen) == gegnerZeichen)
            {
                ausgabe += name + " hat verloren! " + gegnerZeichen.getName() + " schlägt " + eigenesZeichen.getName() + ".";
            }

            return ausgabe;
        }

    }
}
