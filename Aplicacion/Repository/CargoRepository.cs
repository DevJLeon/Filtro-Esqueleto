using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class CargoRepository : GenericRepo<Cargo>, ICargo
{
    protected readonly ApiContext _context;
    
    public CargoRepository(ApiContext context) : base (context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<Cargo>> GetAllAsync()
    {
        return await _context.Cargos
            .ToListAsync();
    }

    public override async Task<Cargo> GetByIdAsync(int id)
    {
        return await _context.Cargos
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }
}