
# Sistema Administracion Tienda de Ropa 👔👕
Sistema de administración de tienda de ropa que permite llevar el control, registro y seguimiento de la producción de prendas de seguridad industrial, la empresa cuenta con diferentes tipos de prendas entre las cuales están las prendas resistentes al fuego (Ignifugas), resistentes a altos voltajes (Arco eléctrico).

## 🚧 Se alcanzó a realizar hasta CRUD 🚧

## Características 🌟

- Registro de usuarios.
- Autenticación con usuario y contraseña.
- Generación y utilización del token.
- CRUD completo para cada entidad.

## 1. Generación del token 🔑:

**Endpoint**: `http://localhost:5272/api/usuario/token`

**Método**: `POST`

**Payload**:

`{
    "Nombre": "Admin",
    "Contraseña": "123"
}`

Se obtendrá el token y se concede el acceso a los métodos correspondientes ✅
## 2. Registro de Usuarios 📝:

**Endpoint**: `http://localhost:5272/api/usuario/register`

**Método**: `POST`

**Payload**:

json
`{
    "Usuario": "<usuario>",
    "Contraseña": "<contraseña>",
    "CorreoElectronico": "<correo>"
}`

Este endpoint permite a los usuarios registrarse en el sistema.

Una vez registrado el usuario tendrá que ingresar para recibir un token, este será ingresado al siguiente Endpoint que es el de Refresh Token.

## 3. Refresh Token 🔄:

**Endpoint**: `http://localhost:5272/api/usuario/refresh-token`

**Método**: `POST`

**Payload Token**:

`{
    "Nombre": "<usuario>",
    "Contraseña": "<contraseña>"
}`

Se dejan los mismos datos en el Body y luego se ingresa al "Auth", "Bearer", allí se ingresa el token obtenido en el anterior Endpoint.

**Otros Endpoints Usuario👤**

Obtener Todos los Usuarios: GET `http://localhost:5272/api/usuario`

Obtener Usuario por ID: GET `http://localhost:5272/api/usuario/{id}`

Actualizar Usuario: PUT `http://localhost:5272/api/usuario/{id}`

Eliminar Usuario: DELETE `http://localhost:5272/api/usuario/{id}`

- Datos Usuario:
```
  {
      "id": 1,
      "username": "admin",
      "email": "admin@example.com",
      "password": "AQAAAAIAAYagAAAAEGi0FjrgCdfzlsJOcti7rJQq1k5DB4Cpr6ICusQEnePc6f78PE1IhgVuIzm6rwMeDA"
    }
```




## Uso 🕹
**Métodos GET de cada tabla🟢**
http://localhost:5272/api/Cargo
http://localhost:5272/api/Cliente
http://localhost:5272/api/Color
http://localhost:5272/api/Departamento
http://localhost:5272/api/DetalleOrden
http://localhost:5272/api/DetalleVenta
http://localhost:5272/api/Empleado
http://localhost:5272/api/Empresa
http://localhost:5272/api/Estado
http://localhost:5272/api/FormaPago
http://localhost:5272/api/Genero
http://localhost:5272/api/Insumo
http://localhost:5272/api/Inventario
http://localhost:5272/api/Municipio
http://localhost:5272/api/Orden
http://localhost:5272/api/Pais
http://localhost:5272/api/Prenda
http://localhost:5272/api/Proveedor
http://localhost:5272/api/Talla
http://localhost:5272/api/TipoEstado
http://localhost:5272/api/TipoPersona
http://localhost:5272/api/TipoProteccion
http://localhost:5272/api/Venta

## CRUD: 

