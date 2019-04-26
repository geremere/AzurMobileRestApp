using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace экр175враинат4
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo exit;
            do
            {
                Random rnd = new Random();
                Competition comp = new Competition();
                for (int i = 0; i < rnd.Next(10,13); i++)
                {
                    if(rnd.Next(1,101)<56)
                    {
                       string name=RandomName(rnd);
                        try
                        {
                            comp.Add(new Runner(name, rnd.Next(9, 14) + rnd.NextDouble()));
                        }
                        catch(ArgumentException)
                        {
                            Console.WriteLine("Doping warning");
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    else
                    {
                        string name = RandomName(rnd);
                        try
                        {
                            comp.Add(new Jumper(name, rnd.Next(6, 9) + rnd.NextDouble()));
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Doping warning");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }

                Console.WriteLine(comp.ToString());
                Jumper bestJumper= null;
                Runner bestRunner=null;
                try
                {
                    bestRunner = comp.GetWinners(ref bestJumper);
                    Console.WriteLine($"Best Jumper: {bestJumper.ToString()}");
                    Console.WriteLine($"Best Runner: {bestRunner.ToString()}");
                    Console.WriteLine($"Second Runner: {SecondRunner(comp,bestRunner).ToString()}");
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (OutOfMemoryException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                
             


                Console.WriteLine("to exit escape");
                exit = Console.ReadKey(true);
            } while (exit.Key != ConsoleKey.Escape);
        }

        private static Runner SecondRunner(Competition comp, Runner bestRunner)
        {
            Runner secondRunner = null;
            bool flag = true;
            for (int i = 0; i < comp.Athlete.Count; i++)
            {
                if (comp[i] is Runner)
                {
                    Runner run = (Runner)comp[i];

                    if (run.Speed != bestRunner.Speed)
                    {
                        if (flag)
                        {
                            secondRunner = (Runner)comp[i];
                            flag = false;
                        }
                        if (run.Speed > secondRunner.Speed) secondRunner = run;
                    }
                }
            }

            return secondRunner;
        }

        private static string RandomName(Random rnd)
        {
            string res = $"{(char)rnd.Next(65,91)}";
            for (int i = 0; i < rnd.Next(5,9); i++)
            {
                res += $"{(char)rnd.Next(97, 123)}";
            }
            return res;
        }
    }
}
