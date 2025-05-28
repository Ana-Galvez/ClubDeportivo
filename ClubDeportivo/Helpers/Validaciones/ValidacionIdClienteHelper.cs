using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Helpers.Validaciones
{
    internal class ValidacionIdClienteHelper
    {
        public static bool ValidarIdCliente(TextBox textBox, out int idCliente)
        {
            idCliente = 0;
            string textoId = textBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(textoId))
            {
                MessageBox.Show("Debe ingresar ID del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(textoId, out idCliente))
            {
                MessageBox.Show("El ID del cliente debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
