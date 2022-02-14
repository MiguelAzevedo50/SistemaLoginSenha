using ProjetoLogin.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLogin.Apresentacao
{
    public partial class CadastreSe : Form
        
    {
        public CadastreSe()
        {
            InitializeComponent();
        }
       
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            controle controle = new controle();

            String mensagem = controle.cadastrar(txbLoginCadastro.Text, txbSenhaCadastro.Text, txbConfirmarSenhaCadastro.Text);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
