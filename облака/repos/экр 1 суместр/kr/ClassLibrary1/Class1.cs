using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr
{
    public abstract class Soldier
    {
        protected int age;
        protected double height;
        protected String rank;

        public int Age { get { return age; } }           //автореализуемые свойства для достпу а к переменный чтобы не делать их паблик(для инкапсуляции)
        public double Height { get { return height; } }        //автореализуемые свойства для достпу а к переменный чтобы не делать их паблик(для инкапсуляции)
        public string Rank { get { return rank; } }          //автореализуемые свойства для достпу а к переменный чтобы не делать их паблик(для инкапсуляции)
        protected Soldier()
        {
        }

        /// <summary>
        /// абстарктный класс котрый мы перелпределим
        /// </summary>
        public abstract void Report();

        /// <summary>
        /// переодпределенный ту стринг
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"age: {age} " +
                $"height= {height} " +
                $"rank= {rank} ";
        }

    }

    public class Squaddie : Soldier
    {
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Squaddie()
        {
            Random rnd = new Random();
            age = rnd.Next(18, 27);
            height = rnd.Next(165, 200);
            rank = "S" + rnd.Next(0, 2);
        }

        /// <summary>
        /// перопределенный репорт
        /// </summary>
        public override void Report()
        {
            Console.WriteLine($"{ToString()}"+"Report: SNAFU!");
        }

        /// <summary>
        /// переодпределенный ту стринг
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"I'm Squaddie " +
                $"age: {age} " +
                $"height= {height} " +
                $"rank= {rank} ";
        }
    }

    public class Commander : Soldier
    {
        int squadVolume;

        /// <summary>
        /// конструктор с 1 параметром
        /// </summary>
        /// <param name="squadVolume"></param>
        public Commander(int squadVolume)
        {
            Random rnd = new Random();
            age = rnd.Next(25, 35);
            height = rnd.Next(175, 210);
            rank = "R" + rnd.Next(0, 3);
            this.squadVolume = squadVolume;
        }

        /// <summary>
        /// перопределенный реппорт
        /// </summary>
        public override void Report()
        {
            Console.WriteLine($"All my {$"{ToString()}"} squaddies, listen to my report: TARFU");
        }

        /// <summary>
        /// переодпределенный ту стринг
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"I'm Commander " +
                $"age: {age} " +
                $"height= {height} " +
                $"rank= {rank} ";
        }
    }
}
