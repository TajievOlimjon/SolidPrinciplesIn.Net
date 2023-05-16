using SRPDemo2.OpenOrClosedPrinciple;
using SRPDemo2.SingleResponsibilityPrinciple;
public class Program
{
    private static void Main(string[] args)
    {

        //GetEducationService();
        /*var study = new Study();
        study.Learning();*/
       
        Console.ReadLine();
    }
    static void GetStudentService()
    {
       var studentService = new StudentService(new StudentCreate(), new StudentInput(), new StudentValidator());
       bool add = true;
       while (add)
       {
           add = studentService.Process();
           Console.Write(new string('=', 120)); Console.Write(new string('>', 1));
       }
    }
    static void GetEducationService()
    {
        var center = new EducationCenter("Olim");
        BaseLearningSkill[] skills = new BaseLearningSkill[] { new Pupil(), new Teacher(),new Study()};
        center.GetInfo(skills);
    }
}
