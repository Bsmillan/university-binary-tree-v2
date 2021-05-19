using System;

namespace BinaryTreeUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            Position rectorPosition = new Position();
            rectorPosition.Name = "Rector";
            rectorPosition.Salary = 1000;
            rectorPosition.Taxes = 30;

            Position vicFinPosition = new Position();
            vicFinPosition.Name = "Vice Rector Financiero";
            vicFinPosition.Salary = 750;
            vicFinPosition.Taxes = 10;

            Position contadorPosition = new Position();
            contadorPosition.Name = "Contador";
            contadorPosition.Salary = 500;
            contadorPosition.Taxes = 15;

            Position secFin1Position = new Position();
            secFin1Position.Name = "Secretaria Financiera 1";
            secFin1Position.Salary = 350;
            secFin1Position.Taxes = 20;

            Position secFin2Position = new Position();
            secFin2Position.Name = "Secretaria Financiera 2";
            secFin2Position.Salary = 310;
            secFin2Position.Taxes = 22;

            Position jefeFinPosition = new Position();
            jefeFinPosition.Name = "Jefe Financiero";
            jefeFinPosition.Salary = 610;
            jefeFinPosition.Taxes = 8;

            Position vicAcadPosition = new Position();
            vicAcadPosition.Name = "Vice Rector Academico";
            vicAcadPosition.Salary = 780;
            vicAcadPosition.Taxes = 18;

            Position jefeRegPosition = new Position();
            jefeRegPosition.Name = "Jefe registro";
            jefeRegPosition.Salary = 640;
            jefeRegPosition.Taxes = 28;

            Position secReg2Position = new Position();
            secReg2Position.Name = "Secretaria Registro 2";
            secReg2Position.Salary = 360;
            secReg2Position.Taxes = 21;

            Position secReg1Position = new Position();
            secReg1Position.Name = "Secretaria Registro 1";
            secReg1Position.Salary = 400;
            secReg1Position.Taxes = 5;

            Position asistSecReg2Position = new Position();
            asistSecReg2Position.Name = "Asistente de Secretaria Registro 2";
            asistSecReg2Position.Salary = 170;
            asistSecReg2Position.Taxes = 3;

            Position mensajeroPosition = new Position();
            mensajeroPosition.Name = "Mensajero";
            mensajeroPosition.Salary = 90;
            mensajeroPosition.Taxes = 2;

            Position asistSecReg1Position = new Position();
            asistSecReg1Position.Name = "Asistente de Secretaria Registro 1";
            asistSecReg1Position.Salary = 250;
            asistSecReg1Position.Taxes = 13;

            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition(universityTree.Root, vicFinPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin2Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, vicAcadPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeRegPosition, vicAcadPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secReg2Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secReg1Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asistSecReg2Position, secReg1Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensajeroPosition, asistSecReg2Position.Name);
            universityTree.CreatePosition(universityTree.Root, asistSecReg1Position, secReg1Position.Name);

            universityTree.PrintTree(universityTree.Root);

            universityTree.LongestSalary(universityTree.Root);

            universityTree.HighestSalary(universityTree.Root);
            

            universityTree.CountNode(universityTree.Root);
            
            float averages = universityTree.AverageSalaries(universityTree.Root);
            Console.WriteLine($"Average salaries is ${averages}");

            universityTree.PrintSalary(jefeFinPosition);

            float totalSalary = universityTree.AddSalaries(universityTree.Root);
            Console.WriteLine($"Total salaries: ${totalSalary}");

            float totalTaxes = universityTree.AddTaxes(universityTree.Root);
            Console.WriteLine($"Total taxes: ${totalTaxes}");

            Console.ReadLine();
        }
    }
}