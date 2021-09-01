using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Al_Shop.Models.ViewModels
{
    public class ListUsuarioViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public long Telefono { get; set; }
        public System.DateTime Fechan { get; set; }
        public byte[] Pass { get; set; }
    }
}