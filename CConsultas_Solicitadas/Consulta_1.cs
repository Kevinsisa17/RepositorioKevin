using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;
using CNegocio;

namespace CConsultas_Solicitadas
{
    public class Consulta_1
    {
        private DataClasses1DataContext db = new DataClasses1DataContext();

        public IQueryable Primera_Consulta()
        {
            return db.primera_consulta;
        }

    }
}
