using System;

namespace L2_7_Zad_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ten program sprawdzi czy w Twój wiek uprawnia Cię do ubiegania się o dany urząd.");
            Console.Write("Podaj swój wiek: ");
            byte.TryParse(Console.ReadLine(), out byte userAge);

            if (userAge >= 21)
            {
                Console.WriteLine("Możesz zostać posłem.");
                if(userAge >= 25)
                {
                    Console.WriteLine("Możesz zostać premierem.");
                    if (userAge >= 30)
                    {
                        Console.WriteLine("Możesz zostać senatorem.");
                        if (userAge >= 35)
                        {
                            Console.WriteLine("Możesz zostać prezydentem.");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Jesteś za młody aby ubuegać się o urząd.");
            }
        }
    }
}
