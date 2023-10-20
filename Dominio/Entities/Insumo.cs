using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Insumo:BaseEntity
    {
        public string Nombre { get; set; }
        public float ValorUnit { get; set; }
        public int StockMin {   get; set; }
        public int StockMax { get; set; }
        public ICollection<InsumoPrenda> InsumoPrendas { get; set; }
        public ICollection<Prenda> Prendas { get; set; }
        public ICollection<InsumoProveedor> InsumoProveedores { get; set;}
        public ICollection<Proveedor> Proveedores { get; set;}
    }
}