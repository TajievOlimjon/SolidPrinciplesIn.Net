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
            Console.WriteLine("I teaching");
        }

        protected override void Skills()
        {
            Console.WriteLine("I know C#,java script");
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
            Console.WriteLine("I study");
        }

        protected override void Skills()
        {
            Console.WriteLine("I know C#,java script, C++, Html and Css");
        }
    }
    public class Study: EducationCenter
    {
        public Study(string name):base(name)
        {
            
        }
        public void Skils()
        {
        }
        public void Learning()
        {
            Console.WriteLine(Name);
        }
    }
}
