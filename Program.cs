using System;

namespace LäxaTvå
{
    class Program
    {
        static void Main(string[] args)


        {






            string menyVal;
            
            do
            {
                Console.WriteLine("BANKEN");
                Console.WriteLine("Menyval:");
                Console.WriteLine("[I]nsättning");
                Console.WriteLine("[U]ttag");
                Console.WriteLine("[S]aldo");
                Console.WriteLine("[R]äntebetalning");
                Console.WriteLine("[A]vsluta");
                menyVal = Console.ReadLine();


            double räntesats = 0;
            double insättning = 0;
            double uttag = 0;
            double saldo = 0; ;
            
               

                switch (menyVal)
                {
                    case "I":
                    case "i":
                        Console.WriteLine("Var god ange summa du vill sätta in:");
                        insättning = double.Parse(Console.ReadLine());
                        saldo = saldo + insättning;


                        break;

                    case "U":
                    case "u":
                        Console.WriteLine("Var god ange summa du vill ta ut");
                        uttag = double.Parse(Console.ReadLine());
                        saldo = saldo - uttag;
                        
                        break;

                    case "S":
                    case "s":
                        Console.WriteLine("Ditt saldo är:" + saldo);
                        
                        break;

                    case "R":
                    case "r":
                        Console.WriteLine("Var god ange Årlig insättning:");
                        double årligInsättning = double.Parse(Console.ReadLine());
                        if (årligInsättning > 0)
                        {
                            Console.WriteLine("Välj räntesats:");
                            räntesats = double.Parse(Console.ReadLine());
                        }

                        if (räntesats > 0)
                        {
                            Console.WriteLine("Välj antal år");
                            double antalÅr = double.Parse(Console.ReadLine());

                          

                            for (int i = 1; i < antalÅr; i++)
                            {

                                double avkastning =  (saldo +årligInsättning) * (räntesats / 100);
                                double sparandet = årligInsättning + avkastning;      // total avkastning för ett år
                                saldo = +sparandet;

                        


                                // detta ska upprepas så många gånger som antal år



                                Console.WriteLine("Sparandet blir " + sparandet + " kr.");


                            }

                        }

                        break;


                    case "A":
                    case "a":
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Ogiltigt alternativ");
                        break;

                       }



            } while (menyVal != "i" + "I" + "U" + "u" + "S" + "s" + "R"+ "r");


        }

    }



}

