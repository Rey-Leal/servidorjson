using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private List<Produto> produtos = new List<Produto>();
        private int _nextId = 1;

        public ProdutoRepositorio()
        {
            Add(new Produto(1, "Arroz", "Grãos", 29.90M));
            Add(new Produto(2, "Feijão", "Grãos", 15.50M));
            Add(new Produto(3, "Macarrão", "Massas", 6.50M));
            Add(new Produto(4, "Extrato", "Molhos", 3.20M));
            Add(new Produto(5, "Pão", "Padaria", 8.50M));
            Add(new Produto(6, "Leite", "Laticínios", 5.50M));
            Add(new Produto(7, "Queijo", "Laticínios", 20.90M));
            Add(new Produto(8, "Frango", "Carnes", 26.90M));
            Add(new Produto(9, "Maçã", "Frutas", 5.99M));
            Add(new Produto(10, "Alface", "Hortifruti", 3.99M));
        }

        public IEnumerable<Produto> GetAll()
        {
            return produtos;
        }

        public Produto Get(int id)
        {
            return produtos.Find(p => p.Id == id);
        }

        public Produto Add(Produto item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            item.Id = _nextId++;
            produtos.Add(item);
            return item;
        }

        public void Remove(int id)
        {
            produtos.RemoveAll(p => p.Id == id);
        }

        public bool Update(Produto item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = produtos.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return false;
            }
            produtos.RemoveAt(index);
            produtos.Add(item);
            return true;
        }
    }
}