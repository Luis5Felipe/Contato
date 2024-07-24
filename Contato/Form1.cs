using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lista Contatos 1.0\n Crianda Por Luis Felipe");
        }

        private void pessoasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactBDDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contactBDDataSet.pessoas'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoasTableAdapter.Fill(this.contactBDDataSet.pessoas);

        }

        private void contactIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ultima_ligacaoLabel_Click(object sender, EventArgs e)
        {

        }

        private void ultima_ligacaoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
