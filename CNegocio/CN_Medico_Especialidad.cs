using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;

namespace CNegocio
{
    public class CN_Medico_Especialidad
    {
        private DataClasses1DataContext db = new DataClasses1DataContext();
        public void ingresar_especialidad_medico(int medicoid, int especialidad)
        {
            db.ingreso_medico_especialidades(especialidad, medicoid);
        }
    }
}
