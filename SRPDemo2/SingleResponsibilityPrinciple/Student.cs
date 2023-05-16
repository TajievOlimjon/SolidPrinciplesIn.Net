namespace SRPDemo2.SingleResponsibilityPrinciple
{
    public class Student
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        
        public Student(string fullName,int age)
        {
            FullName = fullName;
            Age = age;
        }

    }
    public class StudentService
    {
        public List<Student> Students { get; set; }
        public StudentCreate StudentCreate { get; set; }
        public StudentInput StudentInput { get; set; }
        public StudentValidator StudentValidator { get; set; }
        public StudentService(StudentCreate studentCreate,StudentInput studentInput,StudentValidator studentValidator)
        {
            StudentCreate = studentCreate;
            StudentInput = studentInput;
            StudentValidator = studentValidator;
        }
        public bool Process()
        {
            bool add = true;
            var student = StudentInput.GetInputData();
            var result = StudentValidator.IsValid(student);
            if (result == false) { Console.WriteLine("Некорректное данные !!!"); add = false; }
            Console.WriteLine("Данные успешно обработаны !!!");
            Console.WriteLine("");
            StudentCreate.Create(student);
            StudentCreate.GetInfo();
            return add;
        }
    }
    public class StudentInput
    {
        public Student GetInputData()
        {
            Console.Write("Введите фио=");
            string fullName = Console.ReadLine();
            Console.Write("Введите возрасть=");
            int age = Convert.ToInt32(Console.ReadLine());
            var student = new Student(fullName,  age );
            return student;
        }
    }
    public class StudentValidator
    {
        public bool IsValid(Student student)
        {
            return student.FullName != null && student.FullName is string && student.Age != 0 && student.Age is int;
        }
    }
    public class StudentCreate
    {
        List<Student> students = new List<Student>();
        public void Create(Student student)
        {
            Console.WriteLine("Student successfully created !!!!!!!!");
            students.Add(student);
        }
        public void GetInfo()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"FullName={student.FullName}, Age={student.Age}");
            }
        }
    }
}
