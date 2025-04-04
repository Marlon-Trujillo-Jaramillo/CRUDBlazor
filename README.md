# 🛒 CRUD de Productos en Blazor  

Aplicación web desarrollada en **en WEB API con Blazor y .NET 9** que implementa un **CRUD** (Crear, Leer, Actualizar, Eliminar) para la gestión de productos. Se comunica con una API REST mediante un servicio `IRepository` que maneja las solicitudes HTTP.

---

## 🚀 Características  
✅ Listado de productos con paginación.  
✅ Creación, edición y eliminación de productos.  
✅ Interfaz con Bootstrap para una experiencia mejorada.  
✅ Conexión con API REST usando `HttpClient`.  

---

## 🛠 Tecnologías Usadas  
- **Blazor WebAssembly**  
- **.NET 9**  
- **C#**  
- **Bootstrap**  
- **JSON y HTTPClient**  

---

## 📌 Requisitos  
🔹 **.NET SDK** (versión 7 o superior).  
🔹 Editor de código (Visual Studio).  
🔹 Una API REST funcional para interactuar con el sistema.  

---

## 📥 Instalación y Uso  

### 1️⃣ Clonar el repositorio  
```bash
git clone [https://github.com/tu-usuario/tu-repositorio.git](https://github.com/Marlon-Trujillo-Jaramillo/CRUDBlazor.git)
cd tu-repositorio
```

### 2️⃣ Restaurar paquetes  
```bash
dotnet restore
```

### 3️⃣ Ejecutar la aplicación  
```bash
dotnet run
```
Luego, abre el navegador en **`http://localhost:5000`**  

---

## 📌 Estructura del Proyecto  
```
/CRUD.Frontend
│── /Pages
│   ├── Productos.razor  # Página principal con lista de productos
│   ├── ProductoForm.razor  # Formulario de creación y edición
│── /Services
│   ├── IRepository.cs  # Interfaz de repositorio
│   ├── Repository.cs   # Implementación del repositorio
│── wwwroot/  # Archivos estáticos (CSS, JS, imágenes)
│── Program.cs  # Configuración de la aplicación
│── App.razor  # Componente principal
│── README.md  # Documentación
```

---

## 🛠 Mejoras Futuras  
✅ Agregar autenticación y autorización.  
✅ Implementar una mejor validación de formularios.  
✅ Optimizar la UI con más estilos y efectos visuales.  
✅ Integrar almacenamiento en base de datos.  

---

