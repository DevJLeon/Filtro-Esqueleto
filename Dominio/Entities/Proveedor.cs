using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Proveedor:BaseEntity
    {
        public int Nit { get; set; }
        public string Nombre { get; set; }
        public int IdTipoPersonaFk { get; set; }
        public TipoPersona TipoPersona { get; set; }
        public ICollection<InsumoProveedor> InsumoProveedores { get; set;}
        public ICollection<Insumo> Insumos { get; set; }
    }
}