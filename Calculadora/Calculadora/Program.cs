using static Calculadora.Variaveis;

namespace calculadora
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora iniciada.\nAperte Enter para continuar!");
            Console.ReadKey();
            Console.Clear();
            do
            {
                Console.WriteLine("Digite o primeiro numero.");
                double num1 = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("{0}", num1);
                Console.WriteLine("Agora digite a operação desejada.");
                string op = Console.ReadLine();
                Console.Clear();
                if (op == e[0] || op == e[1] || op == e[2] || op == e[3])
                {
                    Console.WriteLine("{0} {1}", num1, op);
                    Console.WriteLine("Por fim digite o segundo numero.");
                    double num2 = double.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (op)
                    {
                        case "+":
                            SetRes(num1 + num2);
                            Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, GetRes());
                            break;

                        case "-":
                            SetRes(num1 - num2);
                            Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, GetRes());
                            break;

                        case "*":
                            SetRes(num1 * num2);
                            Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, GetRes());
                            break;

                        case "/":
                            SetRes(num1 / num2);
                            Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, GetRes());
                            break;
                        default:
                            Console.WriteLine("Operação incorreta!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Operação incorreta!\nAperte Enter para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                }
                Console.WriteLine("Digite 0 fazer outra operação ou digite 1 para sair!");
                string v = Console.ReadLine();

                if (v == "0")
                {
                    Y = true;
                    Console.Clear();
                    Console.WriteLine("Nova operação.");
                }
                else if (v == "1" || v == "")
                {
                    Y = false;
                    Console.Clear();
                    Console.WriteLine("Calculadora encerrada.");
                }
                else
                {
                    Y = false;
                    Console.Clear();
                    Console.WriteLine("Valor não correspondido calculadora encerrada!");
                }
            }
            while (Y);
            {
            
            }
        }
    }
}