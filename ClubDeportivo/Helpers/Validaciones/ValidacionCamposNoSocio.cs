using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Helpers.Validaciones
{
    internal class ValidacionCamposNoSocio
    {
        public static string ValidarCamposPagoNoSocio(
            string actividad,
            string hora,
            string monto
            )
            
        {
            if (string.IsNullOrWhiteSpace(actividad))
                return "Debe seleccionar una actividad.";
            if (string.IsNullOrWhiteSpace(hora))
                return "Horario no puede estar vacio.";
            if (string.IsNullOrWhiteSpace(monto))
                return "Debe ingresar el monto a pagar.";

            return "";
        }
    }
}
