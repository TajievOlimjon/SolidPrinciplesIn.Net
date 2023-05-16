using SRPDemo2.OpenOrClosedPrinciple;
using SRPDemo2.SingleResponsibilityPrinciple;
public class Program
{
    private static void Main(string[] args)
    {

        //GetEducationService();
        /*var study = new Study();
        study.Learning();*/
        DriveInfo[] drives = DriveInfo.GetDrives();

        foreach (DriveInfo drive in drives)
        {
            Console.WriteLine($"Название: {drive.Name}");
            Console.WriteLine($"Тип: {drive.DriveType}");
            if (drive.IsReady)
            {
                Console.WriteLine($"Объем диска: {drive.TotalSize}");
                Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace}");
                Console.WriteLine($"Метка диска: {drive.VolumeLabel}");
                Console.WriteLine($"Корневой каталог {drive.RootDirectory}");
            }
            Console.WriteLine();
        }
        string dirName = "C";
        var driv = new DriveInfo(dirName);
        var dir = new DirectoryInfo(driv.Name);
        var file = dir.GetFiles();
        Console.WriteLine(file);
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
        BaseLearningSkill[] skills = new BaseLearningSkill[] { new Puple(), new Teacher() };
        center.GetInfo(skills);
    }
}
