using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace _175экрвариант3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo exit;
            do
            {
                Band one = new Band();
                Band two = new Band();

                Console.WriteLine("Play first band");
                one.Play();

                Console.WriteLine("Play second band");
                two.Play();

                double MoreCool = one.GetHowCoolBand() > two.GetHowCoolBand() ? one.GetHowCoolBand() : two.GetHowCoolBand();
                string MoreCoolString = one.GetHowCoolBand() > two.GetHowCoolBand() ? "First Band" : "Second Band";

                Console.WriteLine($"More Coool {MoreCoolString}\tCoolRate: {MoreCool:f3}");

                try
                {
                    Drum res1 = MoreHoiseDrum(one);
                    if (res1 == null) throw new NullReferenceException();
                    Console.WriteLine($"More Hoise Drum in First Band: {res1.ToString()}");
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("В первой группе не было барабанщиков");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                try
                {
                    Drum res2 = MoreHoiseDrum(two);
                    if (res2 == null) throw new NullReferenceException();
                    Console.WriteLine($"More Hoise Drum in First Band: {res2.ToString()}");
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Во второй группе не было барабанщиков");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                try
                {
                    Guitar res = MoreMasteryFuitar(one);
                    if (res == null) throw new NullReferenceException();
                    Console.WriteLine($"More Mastery Guitar in First Band: {res.ToString()}");
                }
                catch(NullReferenceException)
                {
                    Console.WriteLine("В первой группе не оказалось гитаристов");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                try
                {
                    Guitar res = MoreMasteryFuitar(two);
                    if (res == null) throw new NullReferenceException();
                    Console.WriteLine($"More Mastery Guitar in First Band: {res.ToString()}");
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Во второй группе не оказалось гитаристов");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("to exit escape");
                exit = Console.ReadKey(true);
            } while (exit.Key != ConsoleKey.Escape);
        }

        private static Guitar MoreMasteryFuitar(Band one)
        {
            int mastery = one.Bandd[0].Mastery;
            Guitar res = null;
            for (int i = 0; i < one.Bandd.Length; i++)
            {
                if(one[i].Mastery>mastery && one[i] is Guitar)
                {
                    res = (Guitar)one[i];
                    mastery = one[i].Mastery;
                }
            }
            return res;
        }

        private static Drum MoreHoiseDrum(Band one)
        {
            double volume= one.Bandd[0].Volume;
            Drum res =null;
            for (int i = 1; i < one.Bandd.Length; i++)
            {
                if (one[i].Volume > volume && one[i] is Drum)
                {
                    volume = one.Bandd[i].Volume;
                    res=(Drum)one[i];
                }
            }
            return res;
        }
    }
}
