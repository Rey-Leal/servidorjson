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
            Add(new Produto(1, "Molho de tomate", "Molhos", 5.39M));
            Add(new Produto(2, "Doce de Pêssego", "Enlatados", 13.75M));
            Add(new Produto(3, "Feijão", "Grãos", 26.99M));
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