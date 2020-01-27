using System;
namespace ConsoleAppTesting
{
    public interface IPrinter
    {
        void Print();
    }


    public interface IPrinterScanner : IPrinter
    {
        void Scan();
    }

    class HPPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing Using Hp Printer");
        }
    }

    class LGPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing Using LG Printer");
        }
    }


    class Lenova : IPrinterScanner
    {
        public void Print()
        {
            Console.WriteLine("Printing Using Lenova Printer");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning using Lenova Printer");
        }
    }



    public class PrintTheDoc
    {
        public void PrintReport(IPrinter printer)
        {
            printer.Print();
        }

        public void PrintStudentMarksheet(IPrinter printer)
        {
            printer.Print();
        }

        public void ScanTheDoc(IPrinterScanner printer)
        {
            printer.Print();
            printer.Scan();
        }
    }

}
