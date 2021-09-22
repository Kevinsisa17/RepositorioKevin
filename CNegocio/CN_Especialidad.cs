using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;

namespace CNegocio
{
    public class CN_Especialidad
    {
        private DataClasses1DataContext db = new DataClasses1DataContext();
        public IQueryable desplegar_especialidades()
        {
            var Especialidad = from m in db.Especialidades
                               select m.Especialidad;
            return Especialidad;
        }
        public Especialidades buscar_especialidad(string especialidad)
        {
            Especialidades espec = new Especialidades();
            var espe= from m in db.Especialidades
                         where m.Especialidad==especialidad
                         select m;
            espec = (Especialidades)espe.FirstOrDefault();
            return espec;
        }
        
    }
}
