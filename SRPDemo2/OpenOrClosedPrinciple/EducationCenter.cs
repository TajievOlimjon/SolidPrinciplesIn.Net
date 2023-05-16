namespace SRPDemo2.OpenOrClosedPrinciple
{
    /// <summary>
    // 
    // Принцип открытости/закрытости (Open/Closed Principle) можно сформулировать так:

    //  Сущности программы должны быть открыты для расширения, но закрыты для изменения.
        
    //  Суть этого принципа состоит в том, что система должна быть построена таким образом,
    //  что все ее последующие изменения должны быть реализованы с помощью добавления нового кода, а не изменения уже существующего.
    //
    /// </summary>
    public class EducationCenter
    {
        public string Name { get; set; } = "";
        public EducationCenter(string name)
        {
            Name = name;
        }
        public void GetInfo(BaseLearningSkill[] skills)
        {
            foreach (var item in skills)
            {
                item.GetAllInfoInEduactionCenter();
            }
        }
    }
    public abstract class BaseLearningSkill
    {
        public void GetAllInfoInEduactionCenter()
        {
            Learning();
            Skills();
        }
      protected abstract void Learning();
      protected abstract void Skills();
      protected abstract void GetInfo(string name);
    }
    public class Teacher : BaseLearningSkill
    {
        protected override void GetInfo(string name)
        {
            Console.WriteLine($"My name is : {name}");
        }

        protected override void Learning()
        {
            Console.WriteLine("I am currently the teacher of this educational course SoftClub !");
        }

        protected override void Skills()
        {
            Console.WriteLine("I know C#,java script, C++, Html and Css and lerning golang");
        }
    }
    public class Pupil : BaseLearningSkill
    {
        protected override void GetInfo(string name)
        {
            Console.WriteLine($"My name is : {name}");
        }

        protected override void Learning()
        {
            Console.WriteLine("I am currently studying");
        }

        protected override void Skills()
        {
            Console.WriteLine("I know C#,java script, C++, Html and Css");
        }
    }
    public class Study: BaseLearningSkill
    {
        protected override void Skills()
        {
            Console.WriteLine("Education center have a : C#,java script,Golang,Html&Css,git,.Net,React and C++");
        }
        protected override void Learning()
        {
            Console.WriteLine("Training takes place in a week of 6 days and you will learn how to create projects and layout sites");
        }

        protected override void GetInfo(string name)
        {
            Console.WriteLine("Study in CoftClub !");
        }
    }
}
