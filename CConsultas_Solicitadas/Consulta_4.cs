using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;

namespace CConsultas_Solicitadas
{
    public class Consulta_4
    {
        private DataClasses1DataContext db = new DataClasses1DataContext();
        public IQueryable Cuarta_Consulta()
        {
            return db.cuarta_consulta;
        }
    }
}
