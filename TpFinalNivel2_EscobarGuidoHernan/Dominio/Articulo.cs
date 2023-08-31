using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        [DisplayName("Código")]
        public string Codigo { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        public string ImagenUrl { get; set; }

        public decimal Precio { get; set; }

        public Marca Marca { get; set; }

        public Categoria Categoria { get; set; }


    }
}
