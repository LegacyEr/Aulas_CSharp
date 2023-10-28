// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

namespace Lista_1{
    class Program
    {
        static void Main(string[] args)
        {
            string Questao1 = "1_\n Um programa de uma determinada empresa tem o objetivo de salvar o nome completo de\r\n" +
                "todos os funcionários que estiveram presentes no trabalho em todos os dias do mês, para que\r\n" +
                "sejam entregues as devidas bonificações. Segundo o enunciado acima, assinale o tipo de dado\r\n" +
                "que corresponda ao armazenamento dessa variável:\r\n";
            string Resposta1 = "\nString\r\n";
            Console.WriteLine(Questao1 + Resposta1);
            
            string Questao2 = "2_\n Um operador de caixa em um mercado utiliza um programa que o informa todos os preços\r\n" +
                "dos produtos disponíveis para a venda, com base nisso, informe quais seriam os tipos de\r\n" +
                "dados que essas variáveis armazenam:\r\n";
            string Resposta2 = "\nFloat - Double\r\n";
            Console.WriteLine(Questao2 + Resposta2);

            string Questao3 = "3_\n Um bibliotecário utiliza um programa que organiza em ordem alfabética os livros por sua letra\r\n" +
                "inicial, que tipo de variável esse programa utiliza?\r\n";
            string Resposta3 = "\nChar\r\n";
            Console.WriteLine(Questao3 + Resposta3);

            string Questao4 = "4_ Em um software de detecção de mentiras, qual tipo de variável pode ser utilizado para\r\n" +
                "armazenar os dados de afirmações verdadeiras e falsas ?\r\n";
            var Resposta4 = "\nBool\r\n";
            Console.WriteLine(Questao4 + Resposta4);

            string Questao5 = "5_\n- Pedro está desenvolvendo um aplicativo que gerencia um grupo de membros nas redes\r\n" +
                "sociais, porém ele não sabe quais tipos de variáveis ele deve usar para armazenar cada dado\r\n" +
                "da aba de cadastro ao qual o app solicita para a entrada de novos membros. Conforme o\r\n" +
                "enunciado acima e os conhecimentos adquiridos na aula, Assinale a alternativa correta\r\n" +
                "referente aos tipos de dados em cada opção:\r\n";
            string Questao5_1 ="● Insira seu Nome.\r\n" +
                "● Informe sua Idade.\r\n" +
                "● Informe o número total de visualizações no app.\r\n" +
                "● Primeira letra do seu nome.\r\n" +
                "● Está de acordo com todas as políticas do grupo? SIM OU NÃO\r\n";
            var Resposta5 = "\nString - Int - Int (Float) - Char - Bool";
            Console.WriteLine(Questao5 + Questao5_1 + Resposta5);
        }
    }
}
