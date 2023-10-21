using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;
public class EmpresaRepository : GenericRepo<Empresa>, IEmpresa
{
    protected readonly ApiContext _context;
    
    public EmpresaRepository(ApiContext context) : base (context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<Empresa>> GetAllAsync()
    {
        return await _context.Empresas
            .ToListAsync();
    }

    public override async Task<Empresa> GetByIdAsync(int id)
    {
        return await _context.Empresas
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }
}