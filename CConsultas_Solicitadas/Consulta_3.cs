﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;

namespace CConsultas_Solicitadas
{
    public class Consulta_3
    {
        private DataClasses1DataContext db = new DataClasses1DataContext();
        public IQueryable Tercera_Consulta()
        {
            return db.tercera_consulta;
        }
    }
}
