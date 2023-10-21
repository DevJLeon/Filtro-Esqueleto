using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Prenda:BaseEntity
    {
        public string Nombre { get; set; }
        public float ValorUnitCop { get; set; }
        public float ValorUnitUsd { get; set; }
        public int IdEstadoFk { get; set; } //
        public Estado Estado { get; set; }
        public int IdTipoProteccionFk { get; set; } //
        public TipoProteccion TipoProteccion { get; set; }
        public int IdGeneroFk { get; set; } // 
        public Genero Genero { get; set; }


        public ICollection<Inventario> Inventarios { get; set; }
        public ICollection<DetalleOrden> DetalleOrdenes { get; set;}
        public ICollection<InsumoPrenda> InsumoPrendas { get; set; }
    }
}