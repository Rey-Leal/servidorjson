using System;
using System.Collections.Generic;

namespace Server
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private List<Usuario> usuarios = new List<Usuario>();
        private int _nextId = 1;

        public UsuarioRepositorio()
        {
            Add(new Usuario(1, "reyLeal", "Reinaldo Leal de Souza", "06744668617", "reinaldo@mgfinformatica.com.br", true, "jhk&45Lsad45", "4664617",
                new EntesAutorizados[] {
                    new EntesAutorizados(1, "22719918000128", "MGF Informática Ltda"),
                    new EntesAutorizados(2, "64480643000162", "Camara Passos"),
                    new EntesAutorizados(3, "02318396000145", "DEMSUR Muriae")}));
            Add(new Usuario(2, "vida", "Vidakele Borges", "06744668617", "vidakelce@campassos.com.br", false, "46hgka978", "654616",
                new EntesAutorizados[] {
                    new EntesAutorizados(1, "64480643000162", "Camara Passos") }));
            Add(new Usuario(3, "marcos", "Marcos Barcaro", "06744668617", "marcos@demsur.com.br", false, "asd68765jfg5", "194616",
                new EntesAutorizados[] {
                    new EntesAutorizados(1, "02318396000145", "DEMSUR Muriae") }));
        }

        public IEnumerable<Usuario> GetAll()
        {
            return usuarios;
        }

        public Usuario Get(int id)
        {
            return usuarios.Find(p => p.Id == id);
        }

        public Usuario Add(Usuario item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            item.Id = _nextId++;
            usuarios.Add(item);
            return item;
        }

        public void Remove(int id)
        {
            usuarios.RemoveAll(p => p.Id == id);
        }

        public bool Update(Usuario item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = usuarios.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return false;
            }
            usuarios.RemoveAt(index);
            usuarios.Add(item);
            return true;
        }
    }
}