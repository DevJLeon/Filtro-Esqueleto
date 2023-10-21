using Aplicacion.Repository;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.UnitOfWork;
public class UnitOfWork  : IUnitOfWork, IDisposable
{
    private readonly ApiContext _context;

    private RolRepository _Rol;
    private UsuarioRepository _usuarios;
    private CargoRepository _Cargo;
    private ClienteRepository _Cliente;
    private DepartamentoRepository _Departamento;
    private ColorRepository _Color;
    private DetalleOrdenRepository _DetalleOrden;
    private DetalleVentaRepository _DetalleVenta;
    private EmpleadoRepository _Empleado;
    private EmpresaRepository _Empresa;
    private EstadoRepository _Estado;
    private FormaPagoRepository _FormaPago;
    private GeneroRepository _Genero;
    private InsumoRepository _Insumo;
    private InventarioRepository _Inventario;
    private MunicipioRepository _Municipio;
    private OrdenRepository _Orden;
    private PaisRepository _Pais;
    private PrendaRepository _Prenda;
    private ProveedorRepository _Proveedor;
    private TallaRepository _Talla;
    private TipoEstadoRepository _TipoEstado;
    private TipoPersonaRepository _TipoPersona;
    private TipoProteccionRepository _TipoProteccion;
    private VentaRepository _Venta;

    public UnitOfWork(ApiContext context)
    {
        _context = context;
    }
    
    public IRol Roles
    {
        get{
            if(_Rol== null)
            {
                _Rol= new RolRepository(_context);
            }
            return _Rol;
        }
    }
    
    public IUsuario Usuarios
    {
        get{
            if(_usuarios== null)
            {
                _usuarios= new UsuarioRepository(_context);
            }
            return _usuarios;
        }
    }
    public ICargo Cargos
    {
        get{
            if(_Cargo== null)
            {
                _Cargo= new CargoRepository(_context);
            }
            return _Cargo;
        }
    }

    public ICliente Clientes
    {
        get{
            if(_Cliente== null)
            {
                _Cliente= new ClienteRepository(_context);
            }
            return _Cliente;
        }
    }
    public IColor Colores
    {
        get{
            if(_Color== null)
            {
                _Color= new ColorRepository(_context);
            }
            return _Color;
        }
    }
    public IDepartamento Departamentos
    {
        get{
            if(_Departamento== null)
            {
                _Departamento= new DepartamentoRepository(_context);
            }
            return _Departamento;
        }
    }
    public IDetalleOrden DetalleOrdenes
    {
        get{
            if(_DetalleOrden== null)
            {
                _DetalleOrden= new DetalleOrdenRepository(_context);
            }
            return _DetalleOrden;
        }
    }
    public IDetalleVenta DetalleVentas
    {
        get{
            if(_DetalleVenta== null)
            {
                _DetalleVenta= new DetalleVentaRepository(_context);
            }
            return _DetalleVenta;
        }
    }
    public IEmpleado Empleados
    {
        get{
            if(_Empleado== null)
            {
                _Empleado= new EmpleadoRepository(_context);
            }
            return _Empleado;
        }
    }

    public IEmpresa Empresas
    {
        get{
            if(_Empresa== null)
            {
                _Empresa= new EmpresaRepository(_context);
            }
            return _Empresa;
        }
    }
    public IEstado Estados
    {
        get{
            if(_Estado== null)
            {
                _Estado= new EstadoRepository(_context);
            }
            return _Estado;
        }
    }
    public IFormaPago FormaPagos
    {
        get{
            if(_FormaPago== null)
            {
                _FormaPago= new FormaPagoRepository(_context);
            }
            return _FormaPago;
        }
    }
    public IGenero Generos
    {
        get{
            if(_Genero== null)
            {
                _Genero= new GeneroRepository(_context);
            }
            return _Genero;
        }
    }
    public IInsumo Insumos
    {
        get{
            if(_Insumo== null)
            {
                _Insumo= new InsumoRepository(_context);
            }
            return _Insumo;
        }
    }
    public IInventario Inventarios
    {
        get{
            if(_Inventario== null)
            {
                _Inventario= new InventarioRepository(_context);
            }
            return _Inventario;
        }
    }
    public IMunicipio Municipios
    {
        get{
            if(_Municipio== null)
            {
                _Municipio= new MunicipioRepository(_context);
            }
            return _Municipio;
        }
    }
    public IOrden Ordenes
    {
        get{
            if(_Orden== null)
            {
                _Orden= new OrdenRepository(_context);
            }
            return _Orden;
        }
    }
    public IPais Paises
    {
        get{
            if(_Pais== null)
            {
                _Pais= new PaisRepository(_context);
            }
            return _Pais;
        }
    }
    public IPrenda Prendas
    {
        get{
            if(_Prenda== null)
            {
                _Prenda= new PrendaRepository(_context);
            }
            return _Prenda;
        }
    }
    public IProveedor Proveedores
    {
        get{
            if(_Proveedor== null)
            {
                _Proveedor= new ProveedorRepository(_context);
            }
            return _Proveedor;
        }
    }
    public ITalla Tallas
    {
        get{
            if(_Talla== null)
            {
                _Talla= new TallaRepository(_context);
            }
            return _Talla;
        }
    }
    public ITipoEstado TipoEstados
    {
        get{
            if(_TipoEstado== null)
            {
                _TipoEstado= new TipoEstadoRepository(_context);
            }
            return _TipoEstado;
        }
    }
    public ITipoPersona TipoPersonas
    {
        get{
            if(_TipoPersona== null)
            {
                _TipoPersona= new TipoPersonaRepository(_context);
            }
            return _TipoPersona;
        }
    }
    public ITipoProteccion TipoProtecciones
    {
        get{
            if(_TipoProteccion== null)
            {
                _TipoProteccion= new TipoProteccionRepository(_context);
            }
            return _TipoProteccion;
        }
    }
    public IVenta Ventas
    {
        get{
            if(_Venta== null)
            {
                _Venta= new VentaRepository(_context);
            }
            return _Venta;
        }
    }
    
    
    

    public void Dispose()
    {
        _context.Dispose();
    }
    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
