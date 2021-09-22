using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;

namespace CNegocio
{
    public class CN_Doctor
    {
        private DataClasses1DataContext db = new DataClasses1DataContext();
       
        public void crear_medico(string _nombre, string _apellido,string _telefono)
        {
            db.ingreso_medicos(_nombre, _apellido, _telefono);
        }
        public IQueryable<Medicos> desplegar_registro_medicos()
        {
            var registro = from m in db.Medicos
                           select m;
            return registro;
        }
        public Medicos buscar_medico(int id)
        {
            Medicos doc = new Medicos();
            var medico = from m in db.Medicos
                         where m.MedicoId == id
                         select m;
            doc = (Medicos)medico.First();
            return doc;
        }
        public Medicos buscar_medico_(string nombre, string apellido, string telefono)
        {
            Medicos doc = new Medicos();
            var medico = from m in db.Medicos
                         where m.Nombre==nombre && m.Apellidos==apellido && m.Telefono==telefono
                         select m;
            doc = (Medicos)medico.First();
            return doc;
        }
        public void editar_medico(Medicos med,string nombre, string apellido, string telefono)
        {
            Medicos medico = db.Medicos.Where(m => m.MedicoId == med.MedicoId).FirstOrDefault();
            medico.Nombre = nombre;
            medico.Apellidos = apellido;
            medico.Telefono = telefono;
            db.SubmitChanges();
        }
        public void eliminar_medico(Medicos med)
        {
            eliminar_especialidad(med.MedicoId);
            Medicos medic = db.Medicos.Where(e => e.MedicoId == med.MedicoId).FirstOrDefault();
            db.Medicos.DeleteOnSubmit(medic);
            db.SubmitChanges();
        }
        public void eliminar_especialidad(int id)
        {
            var registro_medico = from aux in db.MedicosEspecialidades
                                  where aux.MedicoId == id
                                  select aux;
            foreach (MedicosEspecialidades esp in registro_medico)
            {
                db.MedicosEspecialidades.DeleteOnSubmit(esp);
                db.SubmitChanges();
            }
        }

    }
}
