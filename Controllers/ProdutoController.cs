using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Server
{
    public class ProdutoController : ApiController
    {
        static readonly IProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();

        public IEnumerable<Produto> GetAll()
        {
            return produtoRepositorio.GetAll();
        }

        public Produto Get(int id)
        {
            Produto item = produtoRepositorio.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        public IEnumerable<Produto> GetPorCategoria(string category)
        {
            return produtoRepositorio.GetAll().Where(
                p => string.Equals(p.Categoria, category, StringComparison.OrdinalIgnoreCase));
        }

        public HttpResponseMessage Post(Produto item)
        {
            item = produtoRepositorio.Add(item);
            var response = Request.CreateResponse<Produto>(HttpStatusCode.Created, item);

            string uri = Url.Link("DefaultApi", new { id = item.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        public void Put(int id, Produto product)
        {
            product.Id = id;
            if (!produtoRepositorio.Update(product))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        public void Delete(int id)
        {
            produtoRepositorio.Remove(id);
        }
    }
}