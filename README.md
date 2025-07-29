# 📱 ProFinder — Conecta talentos con oportunidades

ProFinder es una app móvil construida con .NET MAUI que busca conectar personas con habilidades destacadas con oportunidades laborales o de colaboración.

---

## 🚀 Estado del desarrollo

| Componente        | Estado      | Descripción                              |
|-------------------|-------------|------------------------------------------|
| Splash Page       | ✅ Completo | Animación inicial moderna y fluida       |
| Bienvenida Page   | ✅ Completo | Interfaz limpia y bienvenida contextual  |
| Marketplace Page  | 🛠️ En curso | Presentación dinámica de talentos o productos |
| Shell Navigation  | 🔜 Pendiente| Migración a Shell en planificación       |
| Animaciones       | 🧪 En pruebas| Efectos de transición entre páginas      |

---

## 🛠️ Tecnologías utilizadas

- [.NET MAUI](https://learn.microsoft.com/es-es/dotnet/maui/)  
- **C#** y **XAML** para UI responsiva  
- **Git + GitHub** para control de versiones  
- Visual Studio 2022 como entorno de desarrollo

---

## ✨ Características clave

- 📱 Estructura modular por páginas
- 🎨 Animaciones suaves en transición
- 🧹 `.gitignore` personalizado para mantener el proyecto limpio
- 💬 Diseño pensado para ser intuitivo y acogedor

---

## 🧩 Próximos pasos

- Implementar navegación con Shell para escalabilidad
- Incorporar perfil de usuario y favoritos
- Agregar efectos visuales para destacar elementos
- Preparar versión beta para publicación

---

## 📦 Organización del repositorio

Profinder## ✨ Mejoras recientes

- Refactor de navegación Splash → AppShell
- Animación táctil en botón "Volver" con `ScaleTo` + `FadeTo`
- Navegación directa hacia `MainPage` con `GoToAsync("main")`
- `.gitignore` personalizado implementado
- Flujo de Git desde Visual Studio para guardar cambios y sincronizar con GitHub
/ ├── Models/ ├── Views/ ├── Pages/ ├── Resources/ ├── Platforms/ ├── App.xaml & AppShell.xaml ├── MauiProgram.cs ├── README.md └── .gitignore

## 🌟 Mejoras en MarketplacePage

- Se refinó la apariencia visual con márgenes, sombras suaves, colores elegantes y separación visual en cada card.
- Se implementó un header personalizado que reemplaza la barra de navegación de Shell, logrando control total sobre la cabecera.
- Los filtros por especialidad y ciudad fueron estilizados con frames y colores coherentes con la interfaz.
- Se agregó la funcionalidad de **agregar nuevas ciudades y especialidades desde la UI**, permitiendo un sistema colaborativo y extensible.
- La lógica de filtrado se mantiene reactiva y clara, documentada para futuros colaboradores.

Esta página ya funciona como componente independiente, visualmente atractivo y listo para escalar.
