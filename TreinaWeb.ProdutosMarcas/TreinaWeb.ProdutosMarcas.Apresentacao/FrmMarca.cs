using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreinaWeb.ProdutosMarcas.Dominio;
using TreinaWeb.ProdutosMarcas.Repos.EF;
using TreinaWeb.Repositorio.Comum;

namespace TreinaWeb.ProdutosMarcas.Apresentacao
{
    public partial class FrmMarca : Form
    {
        private Marca marcaAEditar;

        public FrmMarca(Marca marca = null)
        {
            marcaAEditar = marca;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            IRepositorioGenerico<Marca> repositorioMarcas = new RepositorioMarca();
            if (marcaAEditar == null)
            {
                Marca novaMarca = new Marca()
                {
                    Nome = txbMarca.Text.Trim()
                };
                repositorioMarcas.Inserir(novaMarca);
            }
            else
            {
                marcaAEditar.Nome = txbMarca.Text.Trim();
                repositorioMarcas.Atualizar(marcaAEditar);
            }
            Close();
        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            if (marcaAEditar != null)
            {
                txbMarca.Text = marcaAEditar.Nome;
            }
            else
            {
                txbMarca.Text = string.Empty;
            }
        }
    }
}
