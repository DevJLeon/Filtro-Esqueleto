using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class DetalleOrdenRepository : GenericRepo<DetalleOrden>, IDetalleOrden
{
    protected readonly ApiContext _context;
    
    public DetalleOrdenRepository(ApiContext context) : base (context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<DetalleOrden>> GetAllAsync()
    {
        return await _context.DetalleOrdenes
            .ToListAsync();
    }

    public override async Task<DetalleOrden> GetByIdAsync(int id)
    {
        return await _context.DetalleOrdenes
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }
}