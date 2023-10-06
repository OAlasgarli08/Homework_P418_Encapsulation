using Homework.Controllers;

CalculatorController calculatorController = new();

calculatorController.Calculation();



EmployeeController employeeController = new();

employeeController.EmployeeSalary();



DoctorController doctorController = new();

doctorController.DoctorAges(new DateTime(1993,05,25), new DateTime(2002,12,15));