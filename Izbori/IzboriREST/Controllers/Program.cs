using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBPAutoGeneratorCS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] klase = {
                                "Akcija",
                                "Koordinator",
                                "BrTel",
                                "DeljenjeLetaka",
                                "EMailAktiviste",
                                "GlasackoMesto",
                                "Gost",
                                "IntervjuNovine",
                                "LokacijaDeljenjaLetaka",
                                "Miting",
                                "MitingZatvoreniP",
                                "NovinariIzNovina",
                                "NovineReklama",
                                "PanoReklama",
                                "PitanjaTVDuel",
                                "Primedbe",
                                "ProtivKandidatiTVDuel",
                                "Reklama",
                                "RezultatiIzbora",
                                "SusretKandidata",
                                "TVDuel",
                                "TVRadioGost",
                                "TVRadioReklama"
                            };

            string ctrl = System.IO.File.ReadAllText(@"..\\..\\CtrlTemplate.txt");
            foreach (string s in klase)
            {
                Console.WriteLine("Obradjujem " + s + "...");
                string temp = String.Format(ctrl, "Izbori", s);
                System.IO.File.WriteAllText(@"..\\..\\" + s + "Controller.cs", temp);
                Console.WriteLine(s + " obradjeno. Idemo dalje...");
            }
            
        }
    }
}
