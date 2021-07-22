using System;
namespace LearningApp.Model
{
    public class Produto
    {
        private string _nome;
        private double _preco;
        private int _estoque; //atributos privadoss

        public Produto() //contrutor normaal
        {
            Console.WriteLine("Contrutor 1");
            Console.WriteLine(this);

        }

        public Produto(string nome, double preco, int quantidade) //Sobrecarga, utilizando mais de u, construtor
        {
            _nome = nome;
            _preco = preco;
            _estoque = quantidade;

            Console.WriteLine("Executando o construtor 2");
            Console.WriteLine(this);
        }

        public Produto(string nome ){  //construtor 3
            _nome = nome;
            Console.WriteLine("Contrutor 3");
            Console.WriteLine(this);
        }

        public override string ToString() // __str__
        {
            return $"Produto:{_nome} - Valor:{_preco} R$ - em estoque {_estoque}";
        }

        public int RemoverItemEstoque(int qtdRemoved)
        {
            _estoque -= qtdRemoved;
            return _estoque;
        }

        public void AdicionarItemEstoque(int qtd)
        {
            _estoque += qtd;
        }

    }
}
