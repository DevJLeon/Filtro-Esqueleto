using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class EstadoRepository : GenericRepo<Estado>, IEstado
{
    protected readonly ApiContext _context;
    
    public EstadoRepository(ApiContext context) : base (context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<Estado>> GetAllAsync()
    {
        return await _context.Estados
            .ToListAsync();
    }

    public override async Task<Estado> GetByIdAsync(int id)
    {
        return await _context.Estados
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }
}