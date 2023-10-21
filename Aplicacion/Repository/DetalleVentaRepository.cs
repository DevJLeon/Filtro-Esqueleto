using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class DetalleVentaRepository : GenericRepo<DetalleVenta>, IDetalleVenta
{
    protected readonly ApiContext _context;
    
    public DetalleVentaRepository(ApiContext context) : base (context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<DetalleVenta>> GetAllAsync()
    {
        return await _context.DetalleVentas
            .ToListAsync();
    }

    public override async Task<DetalleVenta> GetByIdAsync(int id)
    {
        return await _context.DetalleVentas
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }
}