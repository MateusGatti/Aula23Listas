using System;
using System.Collections.Generic;

namespace Aula23Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto (1, "Iphone X", 4500.90f));
            produtos.Add(new Produto (2, "Notebook Samsung Odyssey", 5000.90f));
            produtos.Add(new Produto (3, "Relógio Casio", 199.90f));
            produtos.Add(new Produto (4, "Samsung Galaxy S10", 2999.90f));
            produtos.Add(new Produto (5, "Smart TV 8k", 11999.90f));

            Produto pc = new Produto();
            pc.Codigo = 6;
            pc.Nome = "PC Gamer ultima geração";
            pc.Preco = 15000f;

            produtos.Add(pc);

            foreach(Produto x in produtos){
                System.Console.WriteLine($"{x.Codigo} - {x.Nome} - {x.Preco}");
            }

            produtos.RemoveAt(1);

            produtos.RemoveAll(z => z.Nome == "Relógio Casio");

            System.Console.WriteLine("Itens foram removidos");
            
            foreach(Produto x in produtos){

                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"{x.Codigo} - {x.Nome} - {x.Preco}");
                Console.ResetColor();
                
            }
            System.Console.WriteLine("------------------------------------------------");

            List<Cartao> cartoes = new List<Cartao>();

            cartoes.Add(new Cartao("Mateus Gatti", 201541087, "Visa", "07/09/2024", 854));
            cartoes.Add(new Cartao("Carlos Pereira", 785421699, "MasterCard", "20/11/2020", 504));
            cartoes.Add(new Cartao("Pedro Lucas Machado", 207458763, "MasterCard", "24/01/2022", 390));
            cartoes.Add(new Cartao("Luan Carvalho", 325478004, "Elo", "12/02/2022", 881));
            cartoes.Add(new Cartao("Felipe Spaziante", 854832069, "Visa", "01/12/2019", 319));
            cartoes.Add(new Cartao("Rodrigo Marcondes", 420120698, "Elo", "07/07/2022", 277));

            Cartao card = new Cartao();
            card.Titular = "Luciano Xavier";
            card.Numero = 195874520;
            card.Bandeira = "Hipercard";
            card.Vencimento = "27/09/2023";
            card.Cvv = 480;
            
            cartoes.Add(card);

            foreach(Cartao y in cartoes){
                System.Console.WriteLine($"{y.Titular} - {y.Numero} - {y.Bandeira} - {y.Vencimento} - {y.Cvv}");
            }

            cartoes.RemoveAt(4);

            cartoes.RemoveAll(x => x.Titular == "Luan Carvalho");

            System.Console.WriteLine("Cartões foram removidos");

            foreach(Cartao y in cartoes){
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"{y.Titular} - {y.Numero} - {y.Bandeira} - {y.Vencimento} - {y.Cvv}");
                Console.ResetColor();
            }

            
        }
    }
}
