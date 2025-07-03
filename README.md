# 🧾 VentaSys - Sistema de Gestión de Ventas (Frontend)

Este proyecto es un sistema de escritorio desarrollado en **C#** usando **Windows Forms**, que se conecta a un backend hecho en **FastAPI** para gestionar usuarios, personas, inventario, ventas y facturación. El sistema permite registrar usuarios, autenticarse mediante JWT, consultar productos, gestionar inventario, y mucho más.

---

## ⚙️ Tecnologías utilizadas

- C#
- Windows Forms (WinForms)
- .NET Framework
- JSON
- HTTPClient
- Visual Studio
- FastAPI (backend REST API)
- MySQL (base de datos)

---

## 🧩 Estructura del Proyecto (WinForms)

```
postsys/
├── Forms/
│   ├── Bills.cs              # Facturación
│   ├── ClientForm.cs         # Gestión de clientes
│   ├── Inventory.cs          # Inventario
│   ├── Login.cs              # Inicio de sesión
│   ├── RegisterForm.cs       # Registro de usuarios
│   ├── Sales.cs              # Ventas
│   └── UserForm.cs           # Gestión de usuarios
│
├── model/
│   ├── BillsModel.cs
│   ├── BillsProduct.cs
│   ├── Category.cs
│   ├── Client.cs
│   ├── LoginResponse.cs
│   ├── Person.cs
│   └── Product.cs
│
├── services/
│   ├── AuthSession.cs
│   └── BillsExport.cs
│
├── Form1.cs
└── Program.cs
```

---

## 📷 Capturas de Pantalla

### 🔐 Inicio de Sesión
![Login](./images/login.png)

### 📝 Registro de Usuario
![Register](./images/register.png)

### 🏠 Menú Principal
![Dashboard](./images/menu.png)

### 🛒 Módulo de Ventas
![Ventas](./images/ventas.png)

### 📦 Módulo de Inventario
![Inventario](./images/inventario.png)

### 👥 Módulo de Clientes
![Clientes](./images/clientes.png)

### 👤 Módulo de Usuarios
![Usuarios](./images/usuarios.png)

---

## 🔐 Seguridad y Autenticación

- Se consume un endpoint de FastAPI que devuelve un JWT tras el login exitoso.
- El token es almacenado y usado para realizar solicitudes seguras hacia el backend.
- La verificación de credenciales se realiza desde FastAPI.

---

## 📡 Comunicación con el Backend

El sistema se conecta al backend REST desarrollado con FastAPI para:

- Login y autenticación con JWT
- Registro y actualización de usuarios
- Consulta y gestión de productos e inventario
- Registro y consulta de ventas y facturas
- Manejo de clientes

---

## 📫 Contacto

Si tenés dudas o sugerencias, podés escribirme a [tu-email@ejemplo.com](mailto:tu-email@ejemplo.com) o crear un Issue en el repositorio.

---

¡Sistema listo para desplegarse y usarse en puntos de venta! 🚀
