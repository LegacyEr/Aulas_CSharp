namespace Lista2
{
    class Program
    {
        static void Cabecalho(int NumEx)
        {
            Console.WriteLine();
            Console.WriteLine("".PadLeft(25, '*'));
            Console.WriteLine("EXERCICIO {0}".PadLeft(20), NumEx.ToString().PadLeft(2, '0'));
            Console.WriteLine("".PadLeft(25, '*'));
        }
        static void Main(string[] args)
        {
            //1 
            Ex1();

            //2
            Ex2();

            //3
            Ex3();
        }

        static void Ex1()
        {
            Cabecalho(1);

            Console.WriteLine("Insira aqui 3 valores no qual faremos alguns testes");
            var numero1 = Console.ReadLine();
            var numero2 = Console.ReadLine();
            var numero3 = Console.ReadLine();
            float.TryParse(numero1, out float valor1);
            float.TryParse(numero2, out float valor2);
            float.TryParse(numero3, out float valor3);

            if (valor1 < valor2 && valor1 < valor3)
            {
                Console.WriteLine("O primeiro valor dado ({0}) é o menor número entre os demais.", valor1);
            }
            else if (valor2 < valor3 && valor2 < valor1)
            {
                Console.WriteLine("O segundo valor dado ({0}) é o menor número entre os demais.", valor2);
            }
            else if (valor3 < valor1 && valor3 < valor2)
            {
                Console.WriteLine("O terceiro valor dado ({0}) é o menor número entre os demais.", valor3);
            }
            else if (valor1 == valor2 && valor3 == valor1)
            {
                Console.WriteLine("Todos os três valores dados ({0}, {1}, {2}) são iguais.", numero1, numero2, numero3);
            }
            else if (valor1 == valor2 && valor2 < valor3)
            {
                Console.WriteLine("Os dois primeiros valores dados ({0}, {1}) são iguais e menores que o terceiro valor dado ({2}).", numero1, numero2, numero3);
            }
            else if (valor2 == valor3 && valor2 < valor1)
            {
                Console.WriteLine("Os dois ultimos valores dados ({0}, {1}) são iguais e menores que o primeiro valor dado ({2}).", numero2, numero3, numero1);
            }
            else if (valor3 == valor1 && valor1 < valor2)
            {
                Console.WriteLine("Os dois valores dados ({0}, {1}) são iguais e menores que o segundo valor dado ({2}).", numero1, numero3, numero2);
            }
            else
            {
                Console.WriteLine("Os valores inserido estão incorretos.\r\nReinicie e tente adicionar valores númericos.");
            }
        }

        static void Ex2()
        {
            Cabecalho(2);   
            Console.WriteLine("Insira aqui 3 valores no qual faremos alguns testes");
            var numero1 = Console.ReadLine();
            var numero2 = Console.ReadLine();
            var numero3 = Console.ReadLine();
            float.TryParse(numero1, out float valor1);
            float.TryParse(numero2, out float valor2);
            float.TryParse(numero3, out float valor3);
            if (valor1 > valor2 && valor1 > valor3)
            {
                Console.WriteLine("O primeiro valor dado ({0}) é o maior número entre os demais.", valor1);
            }
            else if (valor2 > valor3 && valor2 > valor1)
            {
                Console.WriteLine("O segundo valor dado ({0}) é o maior número entre os demais.", valor2);
            }
            else if (valor3 > valor1 && valor3 > valor2)
            {
                Console.WriteLine("O terceiro valor dado ({0}) é o maior número entre os demais.", valor3);
            }
            else if (valor1 == valor2 && valor3 == valor1)
            {
                Console.WriteLine("Todos os três valores dados ({0}, {1}, {2}) são iguais.", numero1, numero2, numero3);
            }
            else if (valor1 == valor2 && valor2 > valor3)
            {
                Console.WriteLine("Os dois primeiros valores dados ({0}, {1}) são iguais e maiores que o terceiro valor dado ({2}).", numero1, numero2, numero3);
            }
            else if (valor2 == valor3 && valor2 > valor1)
            {
                Console.WriteLine("Os dois ultimos valores dados ({0}, {1}) são iguais e maiores que o primeiro valor dado ({2}).", numero2, numero3, numero1);
            }
            else if (valor3 == valor1 && valor1 > valor2)
            {
                Console.WriteLine("Os dois valores dados ({0}, {1}) são iguais e maiores que o segundo valor dado ({2}).", numero1, numero3, numero2);
            }
            else
            {
                Console.WriteLine("Os valores inserido estão incorretos.\r\nReinicie e tente adicionar valores númericos.");
            }
        }

        static void Ex3()
        {
            Cabecalho(3);
            Console.WriteLine("Informe seu nome:");
            var nome = Console.ReadLine();
            Console.WriteLine("Qual é o seu nivel de urgencia de 0 a 10");
            var nivelUrgencia = Console.ReadLine();

            if (int.TryParse(nivelUrgencia, out int Nivel) && Nivel <= 10 && Nivel >= 0)
            {
                if (Nivel <= 3)
                {
                    Console.WriteLine("O seu nivel de urgencia e Baixo");
                }
                else if (Nivel <= 6)
                {
                    Console.WriteLine("O seu nivel de urgencia e Médio");
                }
                else if (Nivel <= 9)
                {
                    Console.WriteLine("O seu nivel de urgencia e Alto");
                }
                else
                {
                    Console.WriteLine("O seu nivel de urgencia e Grave");
                }
            }
            else
            {
                Console.WriteLine("O valor dado para nivel de urgencia deve ser inteiro entre os valores 1 e 10");
            }
        }
    }
}

