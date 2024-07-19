using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Server
{
    public class UsuarioController : ApiController
    {
        static readonly IUsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

        public IEnumerable<Usuario> GetAll()
        {
            return usuarioRepositorio.GetAll();
        }

        public Usuario Get(int id)
        {
            Usuario item = usuarioRepositorio.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        public IEnumerable<Usuario> GetPorLogin(string login)
        {
            return usuarioRepositorio.GetAll().Where(
                p => string.Equals(p.Login, login, StringComparison.OrdinalIgnoreCase));
        }

        public HttpResponseMessage Post(Usuario item)
        {
            item = usuarioRepositorio.Add(item);
            var response = Request.CreateResponse<Usuario>(HttpStatusCode.Created, item);

            string uri = Url.Link("DefaultApi", new { id = item.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        public void Put(int id, Usuario product)
        {
            product.Id = id;
            if (!usuarioRepositorio.Update(product))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        public void Delete(int id)
        {
            usuarioRepositorio.Remove(id);
        }
    }
}