using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    /**
     * Clase que contiene los recursos compartidos.
     * Debe ser static para que pueda ser accedida desde cualquier parte de la aplicación.
     */
    static class SharedResources
    {
        // Color de fuente
        public static readonly Color FontColor = Color.FromRgb(0, 0, 0xFF);

        // Color de fondo
        public static readonly Color BackGroundColor = Color.FromRgb(0xFF, 0xF0, 0xAD);
    }
}
