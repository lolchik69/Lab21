﻿namespace Lab21;

class Program {
    static double a;
    static double b;
    public delegate double MathOperator(double a, double b);

    public static void Main(string[] args) {
        System.Console.WriteLine("Привет всем");
        EnterA();
        EnterB();
        Console.WriteLine(ExecuteOperation(a, b, ChooseOperator()));
    } 

    public static void EnterA() {
        Console.WriteLine("Введите a: ");
        string str_a = Console.ReadLine()!;
        while (!double.TryParse(str_a, out a)) {
            Console.WriteLine("Try again");
            str_a = Console.ReadLine()!;
        }
    }
        public static void EnterB() {
        Console.WriteLine("Введите b: ");
        string str_b = Console.ReadLine()!;
        while (!double.TryParse(str_b, out b)) {
            Console.WriteLine("Try again");
            str_b = Console.ReadLine()!;
        }
    }
    public static double ExecuteOperation(double a, double b, MathOperator func) {
        return func(a, b);
    }

    public static MathOperator ChooseOperator() {
        Console.WriteLine("Choose one of four operation(+,-,*,/): ");
        string choice = Console.ReadLine()!;
        while (true) {
            switch (choice) {
                case "+":
                    return Add;
                case "-":
                    return Subtract;
                case "*":
                    return Multiply;
                case "/":
                    return Divide;
                default:
                    Console.WriteLine("Try again");
                    break;
            }
        }
    }
    public static double Add(double a, double b) => a + b;
    public static double Subtract(double a, double b) => a - b;

    public static double Multiply(double a, double b) => a * b;
    
    public static double Divide(double a, double b) {
        if (b == 0) 
            throw new DivideByZeroException("can't divide by zero");

        return a / b;
    }

}