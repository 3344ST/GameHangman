namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            int tryCount = 6;
            int richtige = 0;

            while (running)
            {
                bool test = false;


                Console.WriteLine("Geben Sie das Lösungswort ein: ");
                string lösung = Console.ReadLine().ToLower().Trim();


                do
                {

                    Console.WriteLine("Geben Sie ein Buchstaben ein");
                    string buchstabe = Console.ReadLine().ToLower().Trim();

                    test = false;
                    foreach (char trys in lösung)
                    {

                        if (trys.ToString() == buchstabe)
                        {

                            richtige++;
                            Console.WriteLine("Das War richtig");
                            test = true;

                            if (richtige == lösung.Length)
                            {
                                Console.WriteLine("Spiel beendet. Spieler 2 hat gewonnen!");

                                Console.WriteLine("Wollen Sie eine weitere Runde spielen? Y/N");
                                string wdh = Console.ReadLine().ToLower().Trim();

                                if (wdh == "y")
                                {
                                    running = true;
                                    tryCount = 6;
                                    richtige = 0;
                                    break;

                                }
                                else if (wdh == "n")
                                {
                                    running = false;
                                    Console.WriteLine("Bis zum nächsten Mal.");
                                    return;
                                }

                            }
                        }
                    }
                    if (test == false)
                    {
                        tryCount--;


                        if (tryCount == 5)
                        {
                            Console.WriteLine("       || ");
                            Console.WriteLine("       ||  ");
                            Console.WriteLine("       ||  ");
                            Console.WriteLine("       ||  ");
                            Console.WriteLine("       ||  ");
                            Console.WriteLine("_______||");
                        }
                        else if (tryCount == 4)
                        {
                            Console.WriteLine(" ======|| ");
                            Console.WriteLine("       ||  ");
                            Console.WriteLine("       ||  ");
                            Console.WriteLine("       ||  ");
                            Console.WriteLine("       ||  ");
                            Console.WriteLine("_______||");
                        }
                        else if (tryCount == 3)
                        {
                            Console.WriteLine(" ======|| ");
                            Console.WriteLine(" |     ||  ");
                            Console.WriteLine("       ||  ");
                            Console.WriteLine("       ||  ");
                            Console.WriteLine("       ||  ");
                            Console.WriteLine("_______||");
                        }
                        else if (tryCount == 2)
                        {
                            Console.WriteLine(" ======|| ");
                            Console.WriteLine(" |     ||  ");
                            Console.WriteLine(" O     ||  ");
                            Console.WriteLine("       ||  ");
                            Console.WriteLine("       ||  ");
                            Console.WriteLine("_______||");
                        }
                        else if (tryCount == 1)
                        {
                            Console.WriteLine(" ======|| ");
                            Console.WriteLine(" |     ||  ");
                            Console.WriteLine(" O     ||  ");
                            Console.WriteLine("-x-    ||  ");
                            Console.WriteLine("       ||  ");
                            Console.WriteLine("_______||");
                        }
                        else if (tryCount == 0)
                        {
                            Console.WriteLine(" ======|| ");
                            Console.WriteLine(" |     ||  ");
                            Console.WriteLine(" O     ||  ");
                            Console.WriteLine("-x-    ||  ");
                            Console.WriteLine("| |    ||  ");
                            Console.WriteLine("_______||");
                            Console.WriteLine("Spiel beendet. Spieler 1 hat gewonnen!");


                            Console.WriteLine("Wollen Sie eine weitere Runde spielen? Y/N");
                            string wdh = Console.ReadLine().ToLower().Trim();

                            if (wdh == "y")
                            {
                                running = true;
                                tryCount = 6;
                                richtige = 0;

                            }
                            else if (wdh == "n")
                            {
                                running = false;
                                Console.WriteLine("Bis zum nächsten Mal.");
                            }
                        }




                    }

                } while (tryCount >= 0);





            }
        }
    }
}





        
            
        

    


















