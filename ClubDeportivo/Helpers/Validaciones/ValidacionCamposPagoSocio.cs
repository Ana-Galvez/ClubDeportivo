using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Helpers.Validaciones
{
    internal class ValidacionCamposPagoSocio
    {
        public static string ValidarCamposPagoSocio(
            string monto,
            string cuota,
            string modoPago,
            string numTarjeta,
            string numVerificacion,
            string numCuotas,
            DateTime fechaVencimiento)
        {
            if (string.IsNullOrWhiteSpace(monto))
                return "Debe ingresar el monto a pagar.";

            if (string.IsNullOrWhiteSpace(cuota))
                return "Debe seleccionar una cuota a pagar.";

            if (string.IsNullOrWhiteSpace(modoPago))
                return "Debe ingresar el modo de pago.";

            if (modoPago == "Tarjeta")
            {
                if (fechaVencimiento.Date <= DateTime.Today)
                    return "La fecha de vencimiento de la tarjeta debe ser futura.";

                if (string.IsNullOrWhiteSpace(numCuotas))
                    return "Debe ingresar la cantidad de cuotas.";

                if (string.IsNullOrWhiteSpace(numTarjeta))
                    return "Debe ingresar el N° de tarjeta.";

                if (string.IsNullOrWhiteSpace(numVerificacion))
                    return "Debe ingresar el N° de verificación de la tarjeta.";
            }

            return "";
        }
    }
}
