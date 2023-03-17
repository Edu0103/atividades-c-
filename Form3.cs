using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPagina18
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            int mes = int.Parse(txtMes.Text);

            switch (mes)
            {
                case 1:
                    MessageBox.Show("Janeiro - 31 dias");
                    break;
                case 2:
                    MessageBox.Show("Fevereiro - 28/29 dias");
                    break;
                case 3:
                    MessageBox.Show("Março - 31 dias");
                    break;
                case 4:
                    MessageBox.Show("Abril - 30 dias");
                    break;
                case 5:
                    MessageBox.Show("Maio - 31 dias");
                    break;
                case 6:
                    MessageBox.Show("Junho - 30 dias");
                    break;
                case 7:
                    MessageBox.Show("Julho - 31 dias");
                    break;
                case 8:
                    MessageBox.Show("Agosto - 31 dias");
                    break;
                case 9:
                    MessageBox.Show("Setembro - 30 dias");
                    break;
                case 10:
                    MessageBox.Show("Outubro - 31 dias");
                    break;
                case 11:
                    MessageBox.Show("Novembro - 30 dias");
                    break;
                case 12:
                    MessageBox.Show("Dezembro - 31 dias");
                    break;
                default:
                    MessageBox.Show("Mês Inexistente");
                    break;
            }
        }

        private void txtMes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
