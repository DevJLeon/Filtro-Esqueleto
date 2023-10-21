using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class PrendaDto
    {
        public int Id { get; set;}
        public string Nombre { get; set; }
        public float ValorUnitCop { get; set; }
        public float ValorUnitUsd { get; set; }
        public int IdEstadoFk { get; set; } //
        public EstadoDto Estado { get; set; }
        public int IdTipoProteccionFk { get; set; } //
        public TipoProteccionDto TipoProteccion { get; set; }
        public int IdGeneroFk { get; set; } // 
        public GeneroDto Genero { get; set; }
    }
}