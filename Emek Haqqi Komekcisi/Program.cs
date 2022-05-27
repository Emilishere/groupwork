using System;

namespace Emek_Haqqi_Komekcisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Umumi emek haqqini daxil edin");
            int a = Convert.ToInt32(Console.ReadLine()); //umumi emek haqqi
            Console.WriteLine("aile veziyyetiniz e-evli, b-subay, d-dul");
            string b = Console.ReadLine(); //aile veziyyeti
            bool isContinue = true;
            int i = 0; //usaq sayi
            float Gr = 0; //gross gelir
            float v = 0;//vergi
            string c = ""; //fiziki qusur
            int u = 0; //usaq pulu
            int aile=0; //aile muavineti
            do
            {
                if (b == "d")
                {
                    Console.WriteLine("Usaq varmi? e-beli, h-xeyr");
                    string k = Console.ReadLine();
                    if (k == "e")
                    {
                        Console.WriteLine("Usaq sayini daxil et");
                        i = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("fiziki qusurunuz varmi? e-beli, h-yox");
                    c = Console.ReadLine();
                    isContinue = false;
                }
                else if (b == "e")
                {
                    Console.WriteLine("Usaq varmi? e-beli, h-xeyr");
                    string k = Console.ReadLine();
                    if (k=="e")
                    {
                        Console.WriteLine("Usaq sayini daxil et");
                        i = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("fiziki qusurunuz varmi? e-beli, h-yox");
                    c = Console.ReadLine();
                    isContinue = false;
                }
                else if (b == "b")
                {
                    Console.WriteLine("fiziki qusurunuz varmi? e-beli, h-yox");
                    c = Console.ReadLine();
                    isContinue = false;
                }
                else
                {
                    Console.WriteLine("Yanlis herf,e-evli, b-subay, d-dul, gosterilen herflerden birini daxil edin");
                    b = Console.ReadLine();
                }
            } while (isContinue);
            if (b == "e")
            {
                aile = 50;
                Gr = a + aile;
            }
            else
            {
                aile = 0;
                Gr = a + aile;
            }

            if (i==1)
            {
                u = 30;
                Gr = Gr + u;
            }
            else if (i==2)
            {
                u = 55;
                Gr = Gr + u;
            }
            else if (i==3)
            {
                u = 75;
                Gr = Gr + u;
            }
            else if (i>4)
            {
                u= 75 + 15 * (i - 3);
                Gr = Gr + u;
            }

            
            if (Gr<=1000)
            {
                v = Gr * 15 /100;
            }
            else if (Gr<2000 && Gr>1000)
            {
                v = Gr * 20 / 100;
            }
            else if (Gr>=2000 && Gr<3000)
            {
                v = Gr * 25 / 100;
            }
            else if (Gr>=3000)
            {
                v = Gr * 30 / 100;
            }
            if (c == "e")
            {
                v = v * 50 / 100;
            }
            Gr = Gr - v;
            Console.WriteLine("Aile muavinati");
            Console.WriteLine(aile);
            Console.WriteLine("Usaq pulu");
            Console.WriteLine(u);
            Console.WriteLine("Vergi derecesi");
            if (c=="e")
            {
                Console.WriteLine("Elillik var");
            }
            else
            {
                Console.WriteLine("Elillik yoxdu");
            }
            Console.WriteLine("vergi meblegi");
            Console.WriteLine(v); 
            Console.WriteLine("Umumi emek haqqi");
            Console.WriteLine(a);
            Console.WriteLine("Xalis emek haqqi");
            Console.WriteLine(Gr);
            int interval = (int)Math.Floor(Gr / 200);
            int interval2 = (int)Math.Floor((Gr - interval * 200) / 100);
            int interval3 = (int)Math.Floor(((Gr - interval * 200) - interval2 * 100) / 50);
            int interval4 = (int)Math.Floor((((Gr - interval * 200) - interval2 * 100) - interval3 * 50) / 20);
            int interval5 = (int)Math.Floor(((((Gr - interval * 200) - interval2 * 100) - interval3 * 50) - interval4 * 20) / 10);
            int interval6 = (int)Math.Floor((((((Gr - interval * 200) - interval2 * 100) - interval3 * 50) - interval4 * 20) - interval5 * 10) / 5);
            int interval7 = (int)Math.Floor(((((((Gr - interval * 200) - interval2 * 100) - interval3 * 50) - interval4 * 20) - interval5 * 10) - interval6 * 5) / 1);
            Console.WriteLine(interval+ "x 200"); 
            Console.WriteLine(interval2+"x 100");
            Console.WriteLine(interval3 + "x 50");
            Console.WriteLine(interval4 +"x 20");
            Console.WriteLine(interval5+"x 10");
            Console.WriteLine(interval6+"x 5");
            Console.WriteLine(interval7+"x 1");



           
        }
    }
}
