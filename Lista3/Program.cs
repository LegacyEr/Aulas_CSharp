namespace LIsta3
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
            Ex1();
            Ex2();
            Ex3();
        }
        //Ex 1
        static void Ex1()
        {
            Cabecalho(1);

            string item1 = "Chocolate";
            string item2 = "Refrigerante";
            string item3 = "Bolo";
            string item4 = "Sorvete";
            string item5 = "Pão";

            Console.WriteLine(" Os produtos: {0}, {1}, {2}, {3} e {4}, tiveram um reajuste de 25% do seu valor para cima.\r\n Veja a tabela a seguir:\r\n", item1, item2, item3, item4, item5);

            float Preco_item1 = 30f;
            float Preco_item2 = 50f;
            float Preco_item3 = 45f;
            float Preco_item4 = 60f;
            float Preco_item5 = 15f;
            
            PrecoFinal(item1,Porcentagem(Preco_item1) ,Preco_item1);
            PrecoFinal(item2, Porcentagem(Preco_item2), Preco_item2);
            PrecoFinal(item3, Porcentagem(Preco_item3), Preco_item3);
            PrecoFinal(item4, Porcentagem(Preco_item4), Preco_item4);
            PrecoFinal(item5, Porcentagem(Preco_item5), Preco_item5);

        }

        static void PrecoFinal(string item, float preco, float preco_ant)
        {
            Console.WriteLine("O item {0} que possuia o valor de R${1}\r\nAgora esta custando R${2}\r\n", item, preco_ant, preco);
        }
        static float Porcentagem(float Preco)
        {
            float Percent25 = Preco / 4;
            float ValorFinal = Preco + Percent25;
            return (float)ValorFinal;
        }
        

        //Ex2
        static void Ex2()
        {
            Cabecalho(2);

            Console.WriteLine("Para calcular a area de um circulo insira a distancia em cm do raio:");
            float Raio = float.Parse(Console.ReadLine());
            double Area = Area_Circ(Raio);
            Console.WriteLine("-------------------- Calculando --------------------");
            Console.WriteLine("\r\nO valor da area e de {0}cm²", Area);


        }

        static double Area_Circ(float Raio)
        {
            double Calculo = Math.Pow(Raio, 2) * Math.PI;
            return Calculo;
        }
        

        //Ex3
        static void Ex3()
        {
            Cabecalho(3);

            Console.WriteLine("Para calcular a area de um triangulo informe inicialmente a base do mesmo em m:");
            float Base = float.Parse(Console.ReadLine());
            Console.WriteLine("\nAgora informe a altura em m:");
            float Altura = float.Parse(Console.ReadLine());
            Console.WriteLine("\nA area deste triangulo e de {0}m²", Area(Base, Altura));
        }

        static double Area(float Base, float Altura)
        {
            return (Base * Altura)/2;
        }
        
    }
}