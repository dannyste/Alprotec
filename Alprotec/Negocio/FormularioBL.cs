using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class FormularioBL
    {
        public static Formulario obtenerFormulario(String codigo, ref bool error, ref String mensaje)
        {
            FormularioDAL formularioDAL = new FormularioDAL();
            return formularioDAL.obtenerFormulario(codigo, ref error, ref mensaje);
        }
    }
}
