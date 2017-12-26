﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class FormularioDAL
    {
        public Formulario obtenerFormulario(String codigo, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var query = (
                                    from c in db.Formulario
                                    where c.codigo == codigo
                                    select c
                                ).Single();
                    return query;
                }
                catch (Exception ex)
                {
                    error = true;
                    mensaje = ex.Message;
                }
                return null;
            }
        }
    }
}