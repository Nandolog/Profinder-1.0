using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profinder_1._0.Models
{
    public class PerfilProfesional
    {
        public string? Nombre { get; set; }
        public string? Especialidad { get; set; }
        public string? Ubicacion { get; set; }
        public string? Descripcion { get; set; }

        // 🖼️ Foto de perfil (URL local o externa)
        public string? FotoUrl { get; set; }

        // 📞 Datos de contacto
        public string? Correo { get; set; }
        public string? Telefono { get; set; }

        // 📆 Disponibilidad (texto o enum, según prefieras)
        public string? Disponibilidad { get; set; }

        // 🌟 Experiencia en años (útil para filtros)
        public int? AñosExperiencia { get; set; }
    }
}
