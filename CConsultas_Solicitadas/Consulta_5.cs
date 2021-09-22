using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;

namespace CConsultas_Solicitadas
{
    public class Consulta_5
    {
        private DataClasses1DataContext db = new DataClasses1DataContext();
        public System.Data.Linq.ISingleResult<CDatos.quinta_consultaResult> Quinta_Consulta()
        {
            return db.quinta_consulta();
        }
    }
}
