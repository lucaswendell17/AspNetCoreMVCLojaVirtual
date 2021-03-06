using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Visualizar()
        {
            var produto = GetProduto();
            return View(produto);
        }

        private Produto GetProduto()
        {
            return new Produto()
            {
                id = 1,
                Nome = "Xbox One X",
                Descricao = "Jogue em 4K",
                Valor = 2000.00M
            };
        }
        
    }
}
