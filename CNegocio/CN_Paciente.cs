using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;

namespace CNegocio
{
    class CN_Paciente
    {
        public void crearPaciente(string id, string nombre, string apellido, string direccion, string codpostal, string provincia, string telefono, DateTime fechanacimiento)
        {
            DataClinicaDataContext db = new DataClinicaDataContext(); 
            db.ingresar_paciente(int.Parse(id), nombre, apellido, direccion, codpostal, provincia, telefono, fechanacimiento);
        }

    }
}
