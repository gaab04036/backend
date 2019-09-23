using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {

           int let1 = 0;
           int let2 = 0;
           string oper;
           
            
            Console.Write("Digite o 1° número:");
            let1 = double.Parse (Console.ReadLine());
            Console.Write("Digite o 2° número:");
            let2 = double.Parse (Console.ReadLine());
            Console.WriteLine ("Digite o operador");
            oper = Console.ReadLine();

            switch (oper) {
                case "+":
                 let1 + let2 ;
            break;
                case "-":
                 let1 - let2 ;
            break; 
                case "*" :
                 let1 * let2 ;
            break;
                case "/" :
                 let1 / let2 ;
            break;
                case "%" :
                result = let1 % let2 ; 
            break ;
            default:
            "Operação Inválida";
            break; 


            }
           
        //    Hello = let1 + let2 + let3 + let4 / 4;
 
        //     Console.WriteLine($"{let1} + {let2} = {let1 + let2}");
        //     Console.WriteLine($"{let1} - {let2} = {let1 - let2}");
        //     Console.WriteLine($"{let1} * {let2} = {let1 * let2}");
        //     Console.WriteLine($"{let1} / {let2} = {let1 / let2}");
        //     Console.WriteLine($"{let1} % {let2} = {let1 % let2}");
        }
    }
}

