using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoModulo04
{
    public partial class frmEstruturasRepeticao : Form
    {
        public frmEstruturasRepeticao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mensagem de erro quando esta vazio o txt box
            if (txtTabuada.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você devera informar um valor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTabuada.Focus();
                return;
            }
            //pega o valor do textbox 
            int iValorLido = Convert.ToInt32(txtTabuada.Text.Trim());
            //limpa o listview 
            listView1.Items.Clear();
            //utiliza a estrutura de repetição  for para 11 posições e faz a separação do sinal de vezes e de igual pelas colunas
            for(int i =0; i <=10; i++)
            {
                ListViewItem itmx = listView1.Items.Add(iValorLido.ToString());
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "*"));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, i.ToString()));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "="));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, (iValorLido * i).ToString()));
            }

        }

        private void frmEstruturasRepeticao_Load(object sender, EventArgs e)
        {
            //limpa as informaçoes do listview
            listView1.Clear();
            //valor1 sinal valor2 = resultado
            //criação de colunas com tamanho 
            listView1.Columns.Insert(0, " Valor", 40, HorizontalAlignment.Center);
            listView1.Columns.Insert(1, " sinal", 40, HorizontalAlignment.Center);
            listView1.Columns.Insert(2, " Valor", 40, HorizontalAlignment.Center);
            listView1.Columns.Insert(3, " igual", 40, HorizontalAlignment.Center);
            listView1.Columns.Insert(4, " resultado", 40, HorizontalAlignment.Center);
        }
    }
}
