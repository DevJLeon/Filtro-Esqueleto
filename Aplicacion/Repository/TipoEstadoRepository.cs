using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class TipoEstadoRepository : GenericRepo<TipoEstado>, ITipoEstado
{
    protected readonly ApiContext _context;
    
    public TipoEstadoRepository(ApiContext context) : base (context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<TipoEstado>> GetAllAsync()
    {
        return await _context.TipoEstados
            .ToListAsync();
    }

    public override async Task<TipoEstado> GetByIdAsync(int id)
    {
        return await _context.TipoEstados
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }
    public override async Task<(int totalRegistros, IEnumerable<TipoEstado> registros)> GetAllAsync(int pageIndez, int pageSize, string search)
    {
        var query = _context.TipoEstados as IQueryable<TipoEstado>;

        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(p => p.Descripcion.ToLower().Contains(search));
        }

        query = query.OrderBy(p => p.Id);
        var totalRegistros = await query.CountAsync();
        var registros = await query
            .Skip((pageIndez - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (totalRegistros, registros);
    }
}