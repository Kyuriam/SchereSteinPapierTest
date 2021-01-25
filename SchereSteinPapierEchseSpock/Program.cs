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
            Zeichen Schere = new Zeichen("Schere", new string[] { "Papier", "Echse" });
            Zeichen Stein  = new Zeichen("Stein" , new string[] { "Schere", "Echse" });
            Zeichen Papier = new Zeichen("Papier", new string[] { "Stein" , "Spock" });
            Zeichen Echse  = new Zeichen("Echse" , new string[] { "Papier", "Spock" });
            Zeichen Spock  = new Zeichen("Spock" , new string[] { "Schere", "Stein" });

            // Variablen für das Spiel werden initialisiert
            Zeichen gegnerZeichen;
            Zeichen eigenesZeichen;
            Zeichen[] alleZeichen = new Zeichen[] { Schere, Stein, Papier, Echse, Spock };

            // Spielernamen setzen
            Console.WriteLine("Bitte geben sie jetzt ihren Spielernamen ein, bestätigen sie mit Enter:");
            string spielerName= Console.ReadLine();

            // Einleitung des eigentlichen Spiels
            spiel();

                // Die Methode für eine Runde Schere Stein Papier Echse Spock
                // Rekursion bei Wiederspiel Bedarf des Spielers
                void spiel()
                {
                    // Spielerzeichen wählen
                    Console.WriteLine("Bitte wählen sie ihr Zeichen als Zahl. Möglich sind: ");
                    Console.WriteLine(" 0:Schere | 1:Stein | 2:Papier | 3:Echse | 4:Spock");
                    string auswahlString = Console.ReadLine();
                    int auswahlZahl = Int32.Parse(auswahlString);
                    eigenesZeichen = alleZeichen[auswahlZahl];
                
                    // Gegnerzeichen wird ein zufälliges Zeichen zugewiesen
                    gegnerZeichen = alleZeichen[zufallszahl(0,4)];
                    
                    // Die Zeichen spielen gegeneinander
                    // Unentschieden ( gleiche Zeichen )
                    if (eigenesZeichen.getName() == gegnerZeichen.getName())
                    {
                         Console.WriteLine("Unentschieden! " + eigenesZeichen.getName() + " und sind gleiche Zeichen " + gegnerZeichen.getName() + ".");
                    } 
                    // Eigenes Zeichen gewinnt
                    if (eigenesZeichen.besiegtZeichen(gegnerZeichen))
                    {
                        Console.WriteLine( spielerName + " hat gewonnen! " + eigenesZeichen.getName() + " schlägt " + gegnerZeichen.getName() + ".");
                    }
                    // Gegnerisches Zeichen gewinnt
                    if (gegnerZeichen.besiegtZeichen(eigenesZeichen))
                    {
                        Console.WriteLine("Sie haben verloren! " + gegnerZeichen.getName() + " schlägt " + eigenesZeichen.getName() + ".");
                    }

                    // Spiel wiederholen bei Bedarf
                    Console.WriteLine("Möchten sie noch eine Runde spielen, dann schreiben Sie 'ja'");
                    if (Console.ReadLine() == "ja")
                    {
                        spiel();
                    }
                }

                // Zufällige Zahl zwischen min-max wird erzeugt
                int zufallszahl(int min, int max)
                {
                    Random zahl = new Random();
                    int ergebnis = (int)zahl.Next( min , max++);
                    return ergebnis;
                }

        }

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
}