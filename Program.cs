using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String jatekos;
            String szgep;
            String valasz;
            String eredmeny;
            int szgeppont;
            int jatekospont;

            while (playAgain)
            {
                jatekos = "";
                szgep = "";
                valasz = "";
                szgeppont = 0;
                jatekospont = 0;

                while (jatekos != "KO" && jatekos != "PAPIR" && jatekos != "OLLO" && jatekos != "SPOCK" && jatekos != "GYIK")
                {
                    Console.Write("ko/papir/ollo/spock/gyik: ");
                    jatekos = Console.ReadLine();
                    jatekos = jatekos.ToUpper();
                }


                switch (random.Next(1, 6))
                {
                    case 1:
                        szgep = "KO";
                        break;
                    case 2:
                        szgep = "PAPIR";
                        break;
                    case 3:
                        szgep = "OLLO";
                        break;
                    case 4:
                        szgep = "SPOCK";
                        break;
                    case 5:
                        szgep = "GYIK";
                        break;
                }

                Console.WriteLine("Te: " + jatekos);
                Console.WriteLine("A gep: " + szgep);

                switch (jatekos)
                {
                    case "KO":
                        if (szgep == "KO")
                        {
                            Console.WriteLine("Dontetlen!");
                        }
                        else if (szgep == "PAPIR")
                        {
                            Console.WriteLine("Vesztettel!");
                        }
                        else if (szgep == "SPOCK")
                        {
                            Console.WriteLine("Vesztettel!");
                        }
                        else if (szgep == "GYIK")
                        {
                            Console.WriteLine("Nyertel!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "PAPIR":
                        if (szgep == "KO")
                        {
                            Console.WriteLine("Nyertel!");
                        }
                        else if (szgep == "PAPIR")
                        {
                            Console.WriteLine("Dontetlen!");
                        }
                        else if (szgep == "SPOCK")
                        {
                            Console.WriteLine("Nyertel!");
                        }
                        else if (szgep == "GYIK")
                        {
                            Console.WriteLine("Vesztettel!");
                        }
                        else
                        {
                            Console.WriteLine("Vesztettel!");
                        }
                        break;
                    case "OLLO":
                        if (szgep == "KO")
                        {
                            Console.WriteLine("Vesztettel!");
                        }
                        else if (szgep == "PAPIR")
                        {
                            Console.WriteLine("Nyertel!");
                        }
                        else if (szgep == "SPOCK")
                        {
                            Console.WriteLine("Nyertel!");
                        }
                        else if (szgep == "GYIK")
                        {
                            Console.WriteLine("Vesztettel!");
                        }
                        else
                        {
                            Console.WriteLine("Dontetlen!");
                        }
                        break;
                    case "SPOCK":
                        if (szgep == "KO")
                        {
                            Console.WriteLine("Nyertel!");
                        }
                        else if (szgep == "PAPIR")
                        {
                            Console.WriteLine("Vesztettel!");
                        }
                        else if (szgep == "OLLO")
                        {
                            Console.WriteLine("Nyertel!");
                        }
                        else if (szgep == "SPOCK")
                        {
                            Console.WriteLine("Dontetlen!");
                        }
                        else if (szgep == "GYIK")
                        {
                            Console.WriteLine("Vesztettel!");
                        }
                        else
                        {
                            Console.WriteLine("Dontetlen!");
                        }
                        break;
                    case "GYIK":
                        if (szgep == "KO")
                        {
                            Console.WriteLine("Vesztettel!");
                        }
                        else if (szgep == "PAPIR")
                        {
                            Console.WriteLine("Nyertel!");
                        }
                        else if (szgep == "OLLO")
                        {
                            Console.WriteLine("Vesztettel!");
                        }
                        else if (szgep == "SPOCK")
                        {
                            Console.WriteLine("Nyertel!");
                        }
                        else if (szgep == "GYIK")
                        {
                            Console.WriteLine("Dontetlen");
                        }
                        else
                        {
                            Console.WriteLine("Dontetlen!");
                        }
                        break;
                }

                eredmeny = Console.ReadLine();
                if (eredmeny == "Nyertel!") 
                {
                    jatekospont = +1;
                }
                else if (eredmeny == "Vesztettel") 
                {
                    szgeppont = +1;
                }
                else
                {
                    Console.WriteLine("Nincs valtozas a pontokban");
                }
                break;

                Console.WriteLine("Pontjaid: ", jatekospont);

                Console.Write("Ujrakezded? (I/N): ");
                valasz = Console.ReadLine();
                valasz = valasz.ToUpper();

                if (valasz == "I")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }


                Console.WriteLine("Szia");

                Console.ReadKey();
            }
        }
    }
}