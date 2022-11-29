using System;

namespace MyFirstProgram
{
    class Program
    {
        static int szgeppont;
        static int jatekospont = 0;

        static void Win()
        {
            jatekospont++;
            Console.WriteLine("Nyertel!\nPontjaid: " + jatekospont);
        }

        static void Lose()
        {
            szgeppont++;
            Console.WriteLine("Vesztettel!\nGep pontjai: " + szgeppont);
        }

        static void Draw()
        {
            Console.WriteLine("Dontetlen!\nNincs valtozas a pontokban");
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String jatekos;
            String szgep;
            String valasz;
            String eredmeny;

            while (playAgain)
            {
                jatekos = "";
                szgep = "";
                valasz = "";

                while (jatekos != "KO" && jatekos != "PAPIR" && jatekos != "OLLO" && jatekos != "SPOCK" && jatekos != "GYIK")
                {
                    Console.WriteLine("ko/papir/ollo/spock/gyik: ");
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
                            Draw();
                        }
                        else if (szgep == "PAPIR")
                        {
                            Lose();
                        }
                        else if (szgep == "SPOCK")
                        {
                            Lose();
                        }
                        else if (szgep == "GYIK")
                        {
                            Win();
                        }
                        else
                        {
                            Win();
                        }
                        break;
                    case "PAPIR":
                        if (szgep == "KO")
                        {
                            Win();
                        }
                        else if (szgep == "PAPIR")
                        {
                            Draw();
                        }
                        else if (szgep == "SPOCK")
                        {
                            Win();
                        }
                        else if (szgep == "GYIK")
                        {
                            Lose();
                        }
                        else
                        {
                            Lose();
                        }
                        break;
                    case "OLLO":
                        if (szgep == "KO")
                        {
                            Lose();
                        }
                        else if (szgep == "PAPIR")
                        {
                            Win();
                        }
                        else if (szgep == "SPOCK")
                        {
                            Win();
                        }
                        else if (szgep == "GYIK")
                        {
                            Lose();
                        }
                        else
                        {
                            Draw();
                        }
                        break;
                    case "SPOCK":
                        if (szgep == "KO")
                        {
                            Win();
                        }
                        else if (szgep == "PAPIR")
                        {
                            Lose();
                        }
                        else if (szgep == "OLLO")
                        {
                            Win();
                        }
                        else if (szgep == "SPOCK")
                        {
                            Draw();
                        }
                        else if (szgep == "GYIK")
                        {
                            Lose();
                        }
                        else
                        {
                            Draw();
                        }
                        break;
                    case "GYIK":
                        if (szgep == "KO")
                        {
                            Lose();
                        }
                        else if (szgep == "PAPIR")
                        {
                            Win();
                        }
                        else if (szgep == "OLLO")
                        {
                            Lose();
                        }
                        else if (szgep == "SPOCK")
                        {
                            Win();
                        }
                        else if (szgep == "GYIK")
                        {
                            Draw();
                        }
                        else
                        {
                            Draw();
                        }
                        break;
                }

                if (Math.Abs(szgeppont - jatekospont) == 3)
                {
                    if (szgeppont > jatekospont)
                    {
                        Console.WriteLine("Gep nyert!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Nyerted a merkozest!");
                        Console.ReadKey();
                    }
                }

                Console.WriteLine("Kovetkezo fordulo mehet? (I/N): ");
                valasz = Console.ReadLine().ToUpper();

                if (valasz == "I")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                    Console.WriteLine("Szia");
                    Console.ReadKey();
                }
            }
        }
    }
}