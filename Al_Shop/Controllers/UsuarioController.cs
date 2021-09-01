using Al_Shop.Models;
using Al_Shop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Al_Shop.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            List<ListUsuarioViewModel> lista;

            using (Al_shopEntities bd = new Al_shopEntities())
            {
                lista = (from u in bd.Usuarios
                         select new ListUsuarioViewModel
                         {
                             Id = u.id,
                             Nombre = u.nombre,
                             Email = u.email,
                             Telefono = u.telefono,
                             Fechan = u.fechan,
                             Pass = u.pass
                         }).ToList();
            }
                return View(lista);
        }
    }
}