namespace API.Dtos
{
    public class DetalleVentaDto
    {
        public int Id { get; set;}
        public int Cantidad { get; set; }
        public double ValorUnit { get; set; }

        public int IdVentaFk { get; set; }
        public VentaDto Venta { get; set; }
        public int IdProductoFk { get; set; }
        public InventarioDto Inventario { get; set; }
        public int IdTallaFk { get; set; }
        public TallaDto Talla { get; set; }
    }
}