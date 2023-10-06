using Homework.Models;
using Homework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Homework.Controllers
{
    internal class CalculatorController
    {
        public void Calculation()
        {
            CalculatorService calculatorService = new CalculatorService();
            calculatorService.Calculate(10, 6);            
        }
    }
}
