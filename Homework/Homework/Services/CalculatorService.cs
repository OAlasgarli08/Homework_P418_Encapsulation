using Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Services
{
    internal class CalculatorService
    {
        public void Calculate(int a, int b)
        {
            CalculatorModel model = new CalculatorModel();
           
            Console.WriteLine("What calculation method do you want to use?");
            model.calculationMethod = Console.ReadLine();

            if (model.calculationMethod == "substraction" || model.calculationMethod == "Substraction")
            {
                Console.WriteLine(a - b);
            }
            if(model.calculationMethod == "addition" || model.calculationMethod == "Addition")
            {
                Console.WriteLine(a + b);
            }
            if(model.calculationMethod == "division" || model.calculationMethod == "Division")
            {
                Console.WriteLine(a / b);
            }
            if (model.calculationMethod == "multiplication" || model.calculationMethod == "Multiplication")
            {
                Console.WriteLine(a * b);
            }
           
        }
    }
}
