namespace SRPDemo.OpenClosedPrinciple
{
    public class Cook2
    {
        public string Name { get; set; }
        public Cook2(string name)
        {
            Name = name;
        }
        public void MakeDinner(Mealbase[] mealbases)
        {
            foreach (var mealbase in mealbases)
            {
                mealbase.Make();
            }
        }
    }
    public abstract class Mealbase
    {
        protected abstract void Prepare();
        protected abstract void Cook();
        protected abstract void FinalSteps();
        public void Make()
        {
            Prepare();
            Cook();
            FinalSteps();
        }
    }
    public class PotatoMeal2 : Mealbase
    {
        protected override void Cook()
        {
            Console.WriteLine("Поставим очишенную картошку на огонь !!!");
        }

        protected override void FinalSteps()
        {
            Console.WriteLine("Кортофелное пюре готово !!!");
        }

        protected override void Prepare()
        {
            Console.WriteLine("Чистим и моем картошку !!!");
        }
    }
    public class SaladMeal2 : Mealbase
    {
        protected override void Cook()
        {
            Console.WriteLine("Нарезаем помидоры и огурцы !!");
        }

        protected override void FinalSteps()
        {
            Console.WriteLine("Салат готов !!!");
        }

        protected override void Prepare()
        {
            Console.WriteLine("Моем помидоры и огурцы");
        }
    }
}
