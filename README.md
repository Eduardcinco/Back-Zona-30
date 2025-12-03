# VentifyAPI - Sistema POS Multi-Tenant

Backend API para sistema de punto de venta con gestión de inventario, ventas, caja y reportes.

## 🚀 Características

- **Multi-tenant** - Múltiples negocios en una sola instancia
- **Autenticación JWT** - Con refresh tokens y gestión de sesiones
- **Gestión de Inventario** - Productos, categorías, variantes, descuentos
- **Punto de Venta** - Ventas, tickets, métodos de pago
- **Caja** - Apertura/cierre con movimientos automáticos y manuales
- **Reportes** - Excel y PDF con filtros avanzados
- **Empleados** - Roles (Dueño, Gerente, Almacenista, Cajero)

## 📋 Requisitos

- .NET 8.0 SDK
- MySQL 8.0+
- Node.js (para frontend)

## 🔧 Instalación Local

```bash
# Clonar repositorio
git clone https://github.com/Eduardcinco/Back-Zona-30.git
cd Back-Zona-30

# Restaurar dependencias
dotnet restore

# Configurar base de datos en appsettings.json
# DefaultConnection: "Server=localhost;Database=zona30;User=root;Password=root;"

# Aplicar migraciones
dotnet ef database update

# Ejecutar
dotnet run
```

La API estará disponible en `http://localhost:5129`

## 🌐 Deploy en Railway

### Base de Datos
1. Crear proyecto en [Railway](https://railway.app)
2. Agregar servicio MySQL
3. Copiar credenciales de conexión

### Backend
1. Conectar repositorio GitHub
2. Configurar variables de entorno:
```
ConnectionStrings__DefaultConnection=Server={MYSQL_HOST};Port={MYSQL_PORT};Database={MYSQL_DATABASE};User={MYSQL_USER};Password={MYSQL_PASSWORD};
Jwt__Key=tu-clave-secreta-super-segura-minimo-32-caracteres
Jwt__Issuer=VentifyAPI
Jwt__Audience=VentifyClient
```

## 📡 Endpoints Principales

### Autenticación
- `POST /api/auth/register` - Registrar negocio
- `POST /api/auth/login` - Iniciar sesión
- `POST /api/auth/refresh` - Renovar token

### Productos
- `GET /api/producto` - Listar productos
- `POST /api/producto` - Crear producto
- `POST /api/producto/{id}/reabastecer` - Reabastecer stock
- `PUT /api/producto/{id}/descuento` - Aplicar descuento

### Ventas
- `GET /api/venta` - Listar ventas
- `POST /api/venta` - Registrar venta (auto-registra en caja)
- `DELETE /api/venta/{id}` - Cancelar venta

### Caja
- `POST /api/caja/abrir` - Abrir caja
- `POST /api/caja/cerrar` - Cerrar caja
- `POST /api/caja/movimiento` - Registrar ingreso/egreso
- `GET /api/caja/movimientos` - Listar movimientos
- `GET /api/caja/resumen` - Resumen por categorías

### Reportes
- `GET /api/reportes/ventas` - Reporte de ventas (filtros)
- `GET /api/reportes/ventas/pdf` - Exportar PDF
- `GET /api/reportes/ventas/excel` - Exportar Excel

## 🔐 Roles y Permisos

- **Dueño** - Acceso total
- **Gerente** - Gestión de empleados, productos, reportes
- **Almacenista** - Productos, inventario, proveedores
- **Cajero** - Ventas, caja, clientes

## 🛠️ Tecnologías

- ASP.NET Core 8.0
- Entity Framework Core
- MySQL
- JWT Authentication
- iTextSharp (PDF)
- ClosedXML (Excel)

## 📝 Licencia

Proyecto privado - Zona 30

## 👥 Autor

Eduardo Cinco - [GitHub](https://github.com/Eduardcinco)
