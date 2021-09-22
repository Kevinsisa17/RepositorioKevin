using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;
using CNegocio;

namespace CConsultas_Solicitadas
{
    public class Consulta_2
    {
        private DataClasses1DataContext db = new DataClasses1DataContext();
        public IQueryable Segunda_Consulta()
        {
            return db.segunda_consulta;
        }
    }
}
