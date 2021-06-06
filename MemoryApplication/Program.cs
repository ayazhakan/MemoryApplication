using System;
using System.Diagnostics;

namespace MemoryApplication
{
    class Program
    {
        static void Main(string[] args)
        {


            inputControl control = new inputControl();
            var chars = "ABCDEFGHABCDEFGH".ToCharArray();
            Random rng = new Random();
            int sayac = 1;
            var dagitilmis = RandomString(16, chars, rng).ToCharArray();
            int secim1 = 0;
            int secim2 = 0;
            int bitis = 0;
            bool bittimi = false;
            Stopwatch watch = new Stopwatch();


            bool[] acikKartlar = new bool[16];
            bool[] bilinenler = new bool[16];







            while (true)
            {

                watch.Start();
            a:

                for (int i = 0; i < 16; i++)
                {


                    Console.Write(" | ");
                    if (acikKartlar[i] == true)
                    {
                        Console.Write(dagitilmis[i]);
                        Console.Write(" | ");
                    }
                    else
                    {
                        Console.Write(i + 1);
                        Console.Write(" | ");
                    }

                    if ((i + 1) % 4 == 0)
                    {
                        Console.WriteLine("\n");
                    }


                }



            a1:
                Console.WriteLine("birinci kartınızı giriniz");
                string secimm1 = Console.ReadLine();
                if (control.c(secimm1) == true)
                {
                    if (bosmu(secimm1) == false)
                    {
                        secim1 = Convert.ToInt32(secimm1);

                    }
                    else
                    {
                        goto a1;
                    }


                    if (secim1 > 0 && secim1 < 17)
                    {
                        if (acikKartlar[secim1 - 1] == false)
                        {
                            acikKartlar[secim1 - 1] = true;
                        }
                        else
                        {
                            Console.WriteLine("Zaten açılmış bir kart girdiniz");
                            goto a1;
                        }

                    }
                    else
                    {
                        Console.WriteLine("yanlış değer girdiniz");
                        goto a1;
                    }

                }
                else
                {
                    Console.WriteLine("yanlış değer girdiniz");
                    goto a1;
                }
            a2:
                Console.WriteLine("ikinci kartınızı giriniz");
                string secimm2 = Console.ReadLine();
                if (control.c(secimm2) == true && secimm2 != null)
                {
                    if (bosmu(secimm2) == false)
                    {
                        secim2 = Convert.ToInt32(secimm2);

                    }
                    else
                    {
                        goto a2;
                    }

                    if (secim2 > 0 && secim2 < 17)
                    {

                        if (acikKartlar[secim2 - 1] == false)
                        {
                            acikKartlar[secim2 - 1] = true;
                        }
                        else
                        {
                            Console.WriteLine("Zaten açılmış bir kart girdiniz");
                            goto a2;
                        }

                    }
                    else
                    {
                        Console.WriteLine("yanlış değer girdiniz");
                        goto a2;
                    }

                }
                else
                {
                    Console.WriteLine("yanlış değer girdiniz");
                    goto a2;
                }

                if (acikKartlar[secim1 - 1] == true && acikKartlar[secim2 - 1] == true)
                {
                    for (int i = 0; i < 16; i++)
                    {


                        Console.Write(" | ");
                        if (acikKartlar[i] == true)
                        {
                            Console.Write(dagitilmis[i]);
                            Console.Write(" | ");
                        }
                        else
                        {
                            Console.Write(i + 1);
                            Console.Write(" | ");
                        }

                        if ((i + 1) % 4 == 0)
                        {
                            Console.WriteLine("\n");
                        }






                    }

                    System.Threading.Thread.Sleep(2000);
                    sayac++;
                    Console.Clear();

                    //10 sn bekle 
                    if (dagitilmis[secim1 - 1] == dagitilmis[secim2 - 1])
                    {
                        bitis++;

                        acikKartlar[secim1 - 1] = true;
                        acikKartlar[secim2 - 1] = true;

                        

                    }

                    else
                    {
                        acikKartlar[secim1 - 1] = false;
                        acikKartlar[secim2 - 1] = false;
                    }

                }

                 
                

                if (bitis == 8)
                {
                    
                    watch.Stop();

                    break;
                }
                }








        



            



            for (int i = 0; i < 16; i++)
            {


                Console.Write(" | ");

                Console.Write(dagitilmis[i]);

                Console.Write(" | ");



                if ((i + 1) % 4 == 0)
                {
                    Console.WriteLine("\n");
                }

            }
            Console.WriteLine("Oyun bitti, adım sayınız= " + sayac);
            watch.Stop();
            Console.WriteLine("Süreniz= " + watch.Elapsed.Seconds/60 + "dk");
            
            Environment.Exit(0);
        }





        public static bool bosmu(string s)
        {
            if (String.IsNullOrEmpty(s))
                return true;
            else
                return false;
        }








        public static string RandomString(int n, char[] chars, Random rng)
        {
            Shuffle(chars, rng);
            return new string(chars, 0, n);
        }

        public static void Shuffle(char[] array, Random rng)
        {
            for (int n = array.Length; n > 1;)
            {
                int k = rng.Next(n);
                --n;
                char temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }




        }
    }
}
