using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeichenKlasse;
using Spiellogik;
using WebApplication1.Controllers;

namespace Main
{
    public class Program
    {
        // Die Methode für eine Runde Schere Stein Papier Echse Spock
        // Rekursion bei Rückspiel Bedarf des Spielers
        // Der Parameter 'name' ist ein String welcher den Spielernamen wiederspiegelt
        public void spiel(string name)
        {
            SSPESController spielController = new SSPESController();

            // Spielerzeichen wählen
            Console.WriteLine("Bitte wählen sie ihr Zeichen als Zahl. Möglich sind: ");
            Console.WriteLine(" 0:Schere | 1:Stein | 2:Papier | 3:Echse | 4:Spock");
            Console.WriteLine(" Auswahl bestätigen mit Enter.");
            string auswahlString = Console.ReadLine();
            Console.WriteLine(spielController.Spielzug(name, auswahlString));

            // Spiel wiederholen bei Bedarf
            Console.WriteLine("Möchten sie noch eine Runde spielen, dann schreiben Sie 'ja' und bestätigen mit Enter");
            if (Console.ReadLine() == "ja")
            {
                // Console.Clear(); noch nicht wirklich nötig, vielleicht später aber
                spiel(name);
            }

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