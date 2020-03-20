using System;
using System.Globalization;

namespace ProblemaCadastro {
    class Program {
        static void Main(string[] args) {

            

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int Quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, Quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser adicionado no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser removidos no estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
