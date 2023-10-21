using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ProveedorDto
    {
        public int Id { get; set;}
        public int Nit { get; set; }
        public string Nombre { get; set; }
        public int IdTipoPersonaFk { get; set; }
        public TipoPersonaDto TipoPersona { get; set; }
    }
}