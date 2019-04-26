using System;
using System.Threading;


namespace Game1
{
    class Program
    {
        /// <summary>
        /// Это главное меню
        /// </summary>
        static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("\tМеню:");
            Console.WriteLine("1. Начать игру\n2. Прочитать правила\n3. Выйти");
            Console.Write("Выберите действие: ");

            char key;
            while (!char.TryParse(Console.ReadLine(), out key) || key < '1' || key > '3')
            {
                if (key == '4')
                {
                    Console.WriteLine("Ну да, конечно это та кавиша.");
                }
                if (key == '8')
                {
                    Console.WriteLine("Мимо");
                }

                if (key == 'р' || key == 'p')
                {
                    Console.Write("Ррредиска ты! Хватит ломать программу, играй уже, пожалуйста..)");
                }
                else Console.WriteLine("Не та клавиша");
            }

            if (key == '1')
            {
                PlayGame();
            }
            else
            if (key == '2')
            {
                PrintInfo();
            }
            if (key == '3')
            {
                Console.WriteLine("\nПриятно было увидеть тебя! Пока. \nP.S.:Оно само закроется\nP.S.S.: Я не знаю, когда мы перешли на ты");
                //Усыпляет программу на немножко перед переходом к следующему действию
                Thread.Sleep(1500);
                //Закрывает консольное окно
                Environment.Exit(0);
            }


        }


        /// <summary>
        /// отвечает за игру
        /// </summary>
        static void PlayGame()
        {
            Console.Clear();
            Console.WriteLine("Поехали!");

            int res = 0;

            for (int k = 1, n = 10; k <= 21; k += 10, n += 10)
            {
                Console.WriteLine("\t{0} уровень", n / 10);
                res += OneLevel(k, n);

                if (k == 1 && res < 8)
                {
                    Console.WriteLine("Кажется, вы проиграли. У вас меньше 8 правильных ответов :(");
                    break;
                }

                if (k == 11 && res < 24)
                {
                    Console.WriteLine("Кажется, вы проиграли. У вас меньше 24 правильных ответов :(");
                    break;
                }

                if (k == 21 && res < 48)
                {
                    Console.WriteLine("Вы почти выиграли! Но у вас всё равно меньше 48 баллов. Потренируйтесь ещё :)");
                    break;
                }

                if (k == 1 && res >= 8 || k == 11 && res >= 24)
                {
                    Thread.Sleep(100);
                    Console.WriteLine("Поздравляю, вы прошли уровень!\nРезультат - {0}. \nДля выхода в меню нажмите Escape, а для продолжения любую другую клавишу.", res);

                    char cont = Console.ReadKey().KeyChar;
                    if ((int)cont == 27)
                    {
                        Console.WriteLine("Жаль, а до победы оставалось совсем чуть-чуть :(");
                        Thread.Sleep(1500);

                        PrintMenu();
                        break;
                    }


                }

                Console.Clear();
                Console.WriteLine("И снова здравствуйте!");

                if (k == 21 && res >= 48)
                {
                    Console.Clear();
                    Console.WriteLine("Ваш результат {0}! \nА это значит, что.. {1} \nСпасибо за игру!", res, Points(res));
                    Thread.Sleep(1500);
                }



            }
        }

        static string Points(int res)
        {
            string point = "Вероятно, вы что-то невероятное.";
            /*Можно было сделать через switch(res):

            switch (res)
            {
                case 48:
                case 49:
                case 50:
                    point = "Редиска";
                    break;
                case 51:
                case 52:
                case 53:
                    point = "Гумм";
                    break;
                case 54:
                case 55:
                case 56:
                    point = "Ничоси";
                    break;
                case 57:
                case 58:
                case 59:
                    point = "Падаван Пифагора";
                    break;
                case 60:
                    point = "Гуру математики";
                    break;
            }
            */


            if (res >= 48 && res <= 50)
                point = "Вы Редиска";
            if (res >= 51 && res <= 53)
                point = "Вы Гумм";
            if (res >= 54 && res <= 56)
                point = "Ничоси";
            if (res >= 57 && res <= 59)
                point = "Вы Падаван Пифагора";
            if (res == 60)
                point = "Вы Гуру математики";

            return point;
        }


        /// <summary>
        /// Реализовывает игровой процесс одного уровня
        /// </summary>
        /// <param name="k">отвечает за начало диапазона</param>
        /// <param name="n">отвечает за конец диапазона</param>
        /// <returns></returns>

        public static int OneLevel(int k, int n)
        {
            Random gamenum = new Random();

            int mist = 0, success = 0, ans;

            for (int i = 1; i <= 10; i++)
            {
                int rnd = gamenum.Next(k, n + 1);
                Console.Write("{0}. {1}", i, (int)Math.Pow(rnd, 2) + "= ");

                if (Read(out ans) == rnd) success += (n / 10);
                else mist++;
            }
            Console.WriteLine("Баллов за уровень: {0} \nКоличество ошибок: {1}", success, mist);

            return success;
        }

        /// <summary>
        /// Ввод числа пользователем
        /// </summary>
        public static int Read(out int number)
        {

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Возможно, это не совсем число, попробуйте ещё раз..");
            }
            return number;
        }

        /// <summary>
        /// Этот метод реализует выводит инструкции   
        /// </summary>
        static void PrintInfo()
        {
            Console.WriteLine("\nПрограмма загадывает число, возводит его в квадрат и выводит в консоль. " +
                "\nВаша задача: написать исходное число.\n" +
                "Сама игра состоит из трёх уровней. \nЗагадываются числа от 1 до 30, от 11 до 20 и от 21 до 30. " +
                "В каждом раунде можно допустить не более двух ошибок.\nА ещё здесь нет информации об авторе. \n\tУдачи.");

        }


        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                PrintMenu();
                Console.WriteLine("Для повторения нажмите любую клавишу, для выхода Esc.");
            }

            while (Console.ReadKey().Key != ConsoleKey.Escape);

        }

    }
}

