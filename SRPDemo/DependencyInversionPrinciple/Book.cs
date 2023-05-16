using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPDemo.DependencyInversionPrinciple
{
    public interface IPrinter
    {
        void Print(string text);
    }
    public class Book
    {
        public string Text  { get; set; }
        public IPrinter Printer { get; set; }
        public Book(IPrinter printer)
        {
            Printer = printer;
        }
        public void Print()
        {
            Printer.Print(text:Text);
        }
    }
    public class Printer : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine($"Ваш файл {text}");
        }
    }
}
