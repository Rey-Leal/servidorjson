using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    interface IUsuarioRepositorio
    {
        IEnumerable<Usuario> GetAll();
        Usuario Get(int id);
        Usuario Add(Usuario item);
        void Remove(int id);
        bool Update(Usuario item);
    }
}