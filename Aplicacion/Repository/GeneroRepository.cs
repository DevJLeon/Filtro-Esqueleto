using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class GeneroRepository : GenericRepo<Genero>, IGenero
{
    protected readonly ApiContext _context;
    
    public GeneroRepository(ApiContext context) : base (context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<Genero>> GetAllAsync()
    {
        return await _context.Generos
            .ToListAsync();
    }

    public override async Task<Genero> GetByIdAsync(int id)
    {
        return await _context.Generos
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }
}