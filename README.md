# 🏫 Sistema Escolar con Base de Datos

Aplicación de escritorio desarrollada en **C# (Windows Forms)** conectada a **SQL Server**, que permite gestionar la información académica de una institución educativa mediante operaciones CRUD completas.

> Proyecto universitario — Desarrollo de Sistemas 3  
> Universidad de Sonora · Octubre 2025

---

## 👥 Integrantes

| Nombre |
|--------|
| Damian de Jesús Enriquez Solorzano |
| Perla Jazmín Marquez Martinez |
| Brandon Isaac Miranda Montes |
| Sabas Alan Sánchez Enriquez |
| Eduardo Sebastian Sánchez Peralta |
| Natalia Guadalupe Sánchez Valenzuela |
| Fei Fei Wu Zhang |

---

## 🛠️ Tecnologías utilizadas

- **Lenguaje:** C#
- **Framework:** .NET / Windows Forms
- **Base de datos:** SQL Server
- **Herramienta:** Visual Studio

---

## 📋 Funcionalidades

La aplicación cuenta con una **Ventana Principal** que permite navegar entre dos módulos:

### Catálogos
Gestión de tablas de referencia con operaciones de Obtener, Agregar, Editar y Eliminar:

| Catálogo | Descripción |
|----------|-------------|
| Materia | Materias disponibles con créditos |
| Aula | Aulas por edificio, piso y capacidad |
| Académico | Profesores con nombre y grado académico |
| Alumno | Alumnos con estatus (Activo / Egresado) |
| Carrera | Carreras disponibles con siglas |
| Ciudad | Ciudades vinculadas a estados |
| Estado | Estados vinculados a países |
| País | Países registrados |
| Estatus | Tipos de estatus con clave y usuario |

### Tablas
| Tabla | Descripción |
|-------|-------------|
| Grupo | Grupos con maestro, aula, horario y carrera asignados |
| Reinscripción | Inscripciones de alumnos a grupos con calificación |

---

## 🗄️ Base de Datos

La base de datos se llama `DS3_Catalogos` y está compuesta por **11 tablas** relacionadas entre sí.

### Diagrama de relaciones (simplificado)

```
Pais
 └── Estado
       └── Ciudad
             ├── Alumno ──────────────┐
             └── Academico            │
                                      │
Carrera ──── Alumno                   │
             │                        │
Materia ─── Grupo ◄── Reinscripcion ◄─┘
             │
Aula ───────┘
```

### Tablas principales

**Catálogos:** `Pais`, `Estado`, `Ciudad`, `Carrera`, `Aula`, `Estatus`, `Alumno`, `Academico`, `Materia`

**Operacionales:** `Grupo`, `Reinscripcion`

Todas las tablas incluyen el campo `FechaHoraCreacion` con valor por defecto `getdate()`.

---

## 🚀 Cómo ejecutar el proyecto

### Requisitos previos
- Visual Studio 2019 o superior
- SQL Server (local o remoto)
- .NET Framework compatible con Windows Forms

### Pasos

1. Clona el repositorio:
   ```bash
   git clone https://github.com/damianenriquez680/DS3_SistemaEscolarBD.git
   ```

2. Ejecuta el script SQL para crear la base de datos:
   ```
   NuevaBD.sql
   ```
   Ábrelo en SQL Server Management Studio y ejecútalo. Esto crea la base `DS3_Catalogos` con todas sus tablas y relaciones.

3. Abre la solución `.sln` en Visual Studio.

4. Configura la cadena de conexión en el proyecto apuntando a tu instancia de SQL Server.

5. Compila y ejecuta.

---

## 📁 Estructura del repositorio

```
📦 DS3_SistemaEscolarBD
 ┣ 📂 DS3_SistemaEscolarBD/   → Proyecto C# (Windows Forms)
 ┣ 📂 Vistas_Procedimientos/  → Vistas y procedimientos almacenados de SQL
 ┣ 📄 NuevaBD.sql             → Script de creación de la base de datos
 ┗ 📄 README.md
```

---

## 📄 Licencia

Proyecto académico — Universidad de Sonora, 2025.
