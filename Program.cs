using System;
using LearningApp.Model;

namespace LearningApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1;

            produto1 = new Produto("TV", 4.500, 40 );
            produto1.RemoverItemEstoque(5);
            Console.WriteLine(produto1);
            produto1.AdicionarItemEstoque(15);
            Console.WriteLine(produto1);
            
        }
    }
}
