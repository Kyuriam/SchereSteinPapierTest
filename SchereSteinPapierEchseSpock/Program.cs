using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeichenKlasse;

namespace SSPES
{
    public class Program
    {
        // Die Methode für eine Runde Schere Stein Papier Echse Spock
        // Rekursion bei Wiederspiel Bedarf des Spielers
        public void spiel(string a)
        {
            string name = a;
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

            // Spielerzeichen wählen
            Console.WriteLine("Bitte wählen sie ihr Zeichen als Zahl. Möglich sind: ");
            Console.WriteLine(" 0:Schere | 1:Stein | 2:Papier | 3:Echse | 4:Spock");
            Console.WriteLine(" Auswahl bestätigen mit Enter.");
            string auswahlString = Console.ReadLine();
            int auswahlZahl = Int32.Parse(auswahlString);
            eigenesZeichen = alleZeichen[auswahlZahl];
                
            // Gegnerzeichen wird ein zufälliges Zeichen zugewiesen
            gegnerZeichen = alleZeichen[zufallszahl(0,4)];
                    
            // Die Zeichen spielen gegeneinander
            // Unentschieden ( gleiche Zeichen )
            if (eigenesZeichen.getName() == gegnerZeichen.getName())
            {
                Console.WriteLine("Unentschieden! " + eigenesZeichen.getName() + " und " + gegnerZeichen.getName() + " sind gleiche Zeichen.");
            } 
                // Eigenes Zeichen gewinnt
                if (eigenesZeichen.besiegtZeichen(gegnerZeichen))
                {
                    Console.WriteLine( name + " hat gewonnen! " + eigenesZeichen.getName() + " schlägt " + gegnerZeichen.getName() + ".");
                }

                // Gegnerisches Zeichen gewinnt
                if (gegnerZeichen.besiegtZeichen(eigenesZeichen))
                {
                    Console.WriteLine( name + " hat verloren! " + gegnerZeichen.getName() + " schlägt " + eigenesZeichen.getName() + ".");
                }

                // Spiel wiederholen bei Bedarf
                Console.WriteLine("Möchten sie noch eine Runde spielen, dann schreiben Sie 'ja' und bestätigen mit Enter");
                if (Console.ReadLine() == "ja")
                {
                    spiel(name);
                }
        }

        // Zufällige Zahl zwischen min-max wird erzeugt
        private int zufallszahl(int min, int max)
        {
            Random zahl = new Random();
            int ergebnis = (int)zahl.Next( min , max++);
            return ergebnis;
        }

        static void Main(string[] args)
        {
            // Spielernamen setzen
            Console.WriteLine("Bitte geben sie jetzt ihren Spielernamen ein, bestätigen sie mit Enter:");
            string spielerName = Console.ReadLine();

            Program testSpiel = new Program();

            // Einleitung des eigentlichen Spiels
            testSpiel.spiel(spielerName);
        }

    }
}