using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Имамов Радмир Мратович
 * Группа: БПИ183-2
 * Вариант 2;
 * Задача про солдат
 * 
 */
namespace kr
{
    class Program
    {
        /// <summary>
        /// метод для заполнения массива squad
        /// </summary>
        /// <returns>массив типа squad</returns>
        public static Soldier[] SquadVolume()
        {
            Soldier[] arr = new Soldier[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int proc = rand.Next(1, 11);
                if ((proc >= 1) && (proc <= 6))//60%
                {
                    arr[i] = new Squaddie();
                    arr[i].Report();
                    Console.WriteLine();
                }
                else
                {
                    arr[i] = new Commander(rand.Next(1,10));///40%
                    arr[i].Report();
                    Console.WriteLine();
                }
            }
            return arr;
        }

        /// <summary>
        /// метод для заполнения и создания массива Squaddie
        /// </summary>
        /// <param name="squad"></param>
        /// <returns>массив типа Squaddie</returns>
        public static Squaddie[] Squadiearr(Soldier[] squad)
        {
            int size = 0;
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(""+squad[i].GetType()+" "+squad[i]);
                if(squad[i] is Squaddie)
                {
                    if ((squad[i].Height > 185) && ((squad[i].Age >= 20) && (squad[i].Age <= 25)))
                    {
                        size++;//считаем количество таких обьектов для создания массива такой длины
                    }
                }
            }
            Squaddie[] arr = new Squaddie[size];//инициализиуем этот массив длинной size

            for (int i = 0, j = 0; i < 10; i++)
            {
                if (squad[i] is Squaddie)
                {
                    if ((squad[i].Height > 185) && ((squad[i].Age >= 20) && (squad[i].Age <= 25)))
                    {
                        arr[j++] = (Squaddie)squad[i];
                    }
                }
            }
            return arr;
        }

        /// <summary>
        /// метод для печати массива
        /// </summary>
        /// <param name="array"></param>
        public static void Print(Squaddie[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i].ToString());
            }
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
                Soldier[] squad = SquadVolume();//массив squad
                Console.Write("////////////////////////////////////////////////\n");
                Squaddie[] array = Squadiearr(squad);///массив типа Squaddie
                Print(array);
                Console.WriteLine("для выхода нажмите Escape");
                k = Console.ReadKey(true);
            } while (k.Key != ConsoleKey.Escape);//выход на Escape
        }
    }
}
