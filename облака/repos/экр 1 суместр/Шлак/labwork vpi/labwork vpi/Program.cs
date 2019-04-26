using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * группа: Бпи183
 * выполнил: Имамов Радмир Маратович
 * здание: написать игру 
 */
namespace labwork_vpi
{
    class Program
    {
      
        public static void PrintMenu()//методдля вывода меню игры
        {
            Console.WriteLine("         Меню             ");
            Console.WriteLine("1. Начать игру");
            Console.WriteLine("2. Правила игры");
            Console.WriteLine("3. Выйти");
        }
        public static void PrintInfo()//метод для вывод праивл игры
        {
            Console.WriteLine("Программа загадывает число n, возводит его в квадрат и выводит в консоль. Ваша задача: напсиать исходное число n");
            Console.WriteLine("Сама игра сосотоит из 3-ёх уровней. Загадиваются числа от 1 до 10, от 11 до 20, от 21 до 30. В каждом раунде можно допускать не болеее2-ух ошибок");

        }
        public static int Read()//метод выбора дейсвия
        {
            string line;
            int res;
            do
            {
                Console.Write("Выберети дейсвие: ");
                line = Console.ReadLine();
            }while ((!int.TryParse(line, out res))||(res<1)||(res>3));
            return res;
        }
        public static int Read2()//метод ввода ответа в игре
        {
            string line;
            int res;
            do
            {
                Console.Write("Введите число n : ");
                line = Console.ReadLine();
            } while (!int.TryParse(line, out res));
            return res;
        }
        public static int OneLevel(int k,int n, int lvl)//реализация игрового процесса
        {
            Console.WriteLine("Вы на {0} уровне", lvl);
            Console.WriteLine();
            int score=0;
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                int value = rnd.Next(k,n);
                Console.WriteLine("квадрат числа n : " + value * value);
                int redvalue = Read2();

                if (redvalue == value)
                {
                    score = score + 1 * lvl;
                    Console.WriteLine("!ответ верный!");
                }

                Console.WriteLine();
            }
            return score;
        }
        public static void Class(int totalscore)//валидирование твоего результата
        {
            Console.Write("Твой ранг: ");

            if (totalscore <= 50) Console.WriteLine("Мгу");
            if ((totalscore <= 53)&&(totalscore>50)) Console.WriteLine("МИЭМ");
            if ((totalscore <= 56) && (totalscore > 53)) Console.WriteLine("Фкн Пи");
            if ((totalscore <= 59) && (totalscore > 56)) Console.WriteLine("Фкн Пми");
            if (totalscore == 60)  Console.WriteLine("МатФак Вшэ");



        }
        public static void PlayGame()//основной метод игры
        {
            Console.WriteLine("!!!Игра началась!!!");
            int k = 1,n=11,totalscore=0,score=0;
            for (int lvl = 1; lvl <= 3; lvl++)
            {
                score = OneLevel(k, n, lvl);
                totalscore += score;
                Console.WriteLine("Ваш счет суммарный: " + totalscore);
                Console.WriteLine();
                if (score < 8*lvl)
                {
                    Console.WriteLine("Вы проиграли!");
                    Console.WriteLine("Чтобы продолжить игру нажмите Enter");
                    break;
                }
                k += 10;
                n += 10;
            }
            if ((totalscore >= 48) && (score > 24))
            {
                Console.WriteLine("!!!Победа!!!");
                Class(totalscore);
                Console.WriteLine("Чтобы вернуть в меню нажмите ENTER");
            }

        }
        static void Main(string[] args)//основной метод программы
        {
            Console.WriteLine("Добро пожаловать в игру!!!");
            ConsoleKeyInfo e;
            do//цикл решения программы
            {
                PrintMenu();
                int read = Read();

                if (read == 2)
                {
                    PrintInfo();
                    Console.WriteLine("Чтобы вернуться в меню нажмите ENTER");
                }

                if (read == 1)
                    PlayGame();

                if (read == 3)
                    Console.WriteLine("Если дейсвительно хотите выйти нажмите любую кнопку кроме ENTER ");

                e = Console.ReadKey(true);
            } while (e.Key == ConsoleKey.Enter);
        }
    }
}
