using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class VentaRepository : GenericRepo<Venta>, IVenta
{
    protected readonly ApiContext _context;
    
    public VentaRepository(ApiContext context) : base (context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<Venta>> GetAllAsync()
    {
        return await _context.Ventas
            .ToListAsync();
    }

    public override async Task<Venta> GetByIdAsync(int id)
    {
        return await _context.Ventas
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }
    /*public override async Task<(int totalRegistros, IEnumerable<Venta> registros)> GetAllAsync(int pageIndez, int pageSize, string search)
    {
        var query = _context.Ventas as IQueryable<Venta>;

        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(p => p.Nombre.ToLower().Contains(search));
        }

        query = query.OrderBy(p => p.Id);
        var totalRegistros = await query.CountAsync();
        var registros = await query
            .Skip((pageIndez - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (totalRegistros, registros);
    }*/
}