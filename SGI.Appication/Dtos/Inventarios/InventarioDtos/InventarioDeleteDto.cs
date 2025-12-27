using SGI.Appication.Dtos.Inventarios.ProductoDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.Appication.Dtos.Inventarios.InventarioDtos
{
    public class InventarioDeleteDto
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public ProductoDto ProductoDto { get; set; }
    }
}
