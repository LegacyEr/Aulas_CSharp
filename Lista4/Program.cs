using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace Lista4
{
    class Program
    {

        static void Main(string[] args)
        {
            Ex1();
            Ex2();
            Ex3();
            Ex4();
            Ex5();
        }
        //Ex1

        static void Cabecalho(int NumEx)
        {
            Console.WriteLine();
            Console.WriteLine("".PadLeft(25, '*'));
            Console.WriteLine("EXERCICIO {0}".PadLeft(20), NumEx.ToString().PadLeft(2, '0'));
            Console.WriteLine("".PadLeft(25, '*'));
        }
        static void Ex1()
        {
            string[] Alunos = new string[10];
            int contador = 0;

            Cabecalho(1);


            Console.WriteLine("Informe aqui o nome de seus novos 10 Alunos:");
            foreach (string s in Alunos)
            {
                Alunos[contador] = RespostaAluno();
                contador++;
            }
            Console.WriteLine();

            foreach (string aluno in Alunos) { Console.WriteLine("\nBem Vindo(a) a Escola, {0}, tenha um bom dia!\n", aluno); }

        }

        static string RespostaAluno()
        {
            string RespostaAlunos = null;
            int contador2 = 0;

            while (string.IsNullOrWhiteSpace(RespostaAlunos))
            {
                RespostaAlunos = Console.ReadLine();
                contador2++;
                if (contador2 >= 1 && string.IsNullOrWhiteSpace(RespostaAlunos))
                {
                    Console.WriteLine("Infomre um valor valido, não pode dar valores vazios");
                }
            }
            return RespostaAlunos;
        }

        //Ex2
        static void Ex2()
        {
            //repetição - velocidade de um carro - sem ultrapassar 200 Km / h - exiba chegou no limite.
            int velocidade = 0;

            Cabecalho(2);

            while(velocidade <= 200)

            {
                Console.WriteLine("A velocidade atual do carro e igual a {0}\n", velocidade);
                Console.WriteLine("Informe a nova velocidade do veiculo\n");

                string velocidade1 = Console.ReadLine();
                if (int.TryParse(velocidade1, out velocidade)) { }
                else
                {
                    Console.WriteLine("Erro na conversão. Certifique-se de digitar um número inteiro válido.");}

            }
            Console.WriteLine("Chegou no limite de velocidade!!!");

        }

        //Ex3
        static void Ex3()
        {
           DateTime Dia = DateTime.Now;
            int Horas = Dia.Hour;
            int Minutos = Dia.Minute;
            int RestanteHorasA = 0;

            Cabecalho(3);

            Console.WriteLine("Agora são {0} Horas.\nO mercado fica aberto de segunda a domingo das 7 horas da manhã até 17 horas.", Horas);
            if (Horas <= 17 && Horas >=7) {
                int RestanteHorasF = 17 - Horas;
                int RestanteMinutosF = 60 - Minutos;
                Console.WriteLine("O Mercado esta ABERTO!!!\nEle fechara daqui á {0}:{1}", RestanteHorasF, RestanteMinutosF);
            }

            else
            {
                if (Horas == 24 || Horas == 0)
                {
                    RestanteHorasA = Horas + 7;
                }
                else if(Horas > 17){
                    int Calculo = 24-Horas;
                    RestanteHorasA = Calculo + 7;
                }
                else
                {
                    RestanteHorasA = 7 - Horas;
                }
                Console.WriteLine("O Mercado esta FECHADO!!!\nEle abrira daqui á aproximadamente {0} horas\n", RestanteHorasA);
            }
        }

        //Ex4
        
        static void Ex4()
        {

            
            string[] Cardapio = new string[10];
            int contador = 0;

            Cabecalho(4);

            Console.WriteLine("Informe aqui o nome de seus 10 pratos:");
            foreach (string cardapio in Cardapio)
            {
                Cardapio[contador] = ItemCardapio();
                contador++;
            }

            Console.WriteLine("\n");

            foreach (string cardapio in Cardapio)
            {
                Console.WriteLine("Temos o sabor {0}. Aproveiteaa refeição!", cardapio);
            }


        }

        static string ItemCardapio()
        {
            string Cardapio = null;

            while (string.IsNullOrWhiteSpace(Cardapio))
            {
                Cardapio = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(Cardapio))
                    Console.WriteLine("Infomre um valor valido, não pode dar valores vazios");
            }

            return Cardapio;
        }
        

        //Ex5
        
        static void Ex5()
        {
            Console.WriteLine("Contagem regressiva para lançamento de foguete:");

            Cabecalho(5);
            
            for(int i = 1000;i!=-1;i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }

    }

}

