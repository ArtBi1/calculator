using System;

namespace ConsoleCalculator
{
    public class Calculator
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Ошибка: Деление на ноль.");
            return a / b;
        }
        // Можно добавить другие методы для расширенных операций здесь.
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Введите операцию (+, -, *, /) или 'exit' для выхода:");
                string operation = Console.ReadLine();

                if (operation.ToLower() == "exit")
                {
                    exit = true;
                    continue;
                }

                Console.WriteLine("Введите первое число:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                try
                {
                    double result = 0;
                    switch (operation)
                    {
                        case "+":
                            result = calculator.Add(num1, num2);
                            break;
                        case "-":
                            result = calculator.Subtract(num1, num2);
                            break;
                        case "*":
                            result = calculator.Multiply(num1, num2);
                            break;
                        case "/":
                            result = calculator.Divide(num1, num2);
                            break;
                        default:
                            Console.WriteLine("Ошибка: Неверная операция.");
                            continue;
                    }
                    Console.WriteLine($"Результат: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}