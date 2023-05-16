using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPDemo.OpenClosedPrinciple
{
    public class Povar
    {
        public string Name { get; set; }
        public Povar(string name)
        {
            Name = name;
        }
       public void MakeDinner(IMeal meal)
       {
            meal.Make();
       }
    }
    public interface IMeal
    {
        void Make();
    }
    public class PotatoMeal : IMeal
    {
        public void Make()
        {
            Console.WriteLine("Кортофель готово");
        }
    }
    public class SaladMeal : IMeal
    {
        public void Make()
        {
            Console.WriteLine("Салад готово . Можете есть !!!");
        }
    }
}
