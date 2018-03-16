using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex181GerarEvento
{
    /// <summary>
    /// Esta classe é usada para passar parâmetros ao evento de clique no botão OK do form de diálogo gerado.
    /// </summary>
    public class ButtonOkClickEventArgs : EventArgs
    {
        public string Mensagem { get; set; }
    }
}
