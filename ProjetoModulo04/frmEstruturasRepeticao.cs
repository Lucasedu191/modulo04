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
        private List<int> lista = new List<int>();

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
            //criar variavel para while
            int i = 0;
            //utiliza a estrutura de repetição  for para 11 posições e faz a separação do sinal de vezes e de igual pelas colunas
            /* 
             for(int i =0; i <=10; i++)
             {
                 ListViewItem itmx = listView1.Items.Add(iValorLido.ToString());
                 itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "*"));
                 itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, i.ToString()));
                 itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "="));
                 itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, (iValorLido * i).ToString()));
             }
             */

            // bloco while enquanto ele for dentro do numero que o limita o while ele vai continuar o loop

            /*
            while (i <= 10)
            {
                ListViewItem itmx = listView1.Items.Add(iValorLido.ToString());
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "*"));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, i.ToString()));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "="));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, (iValorLido * i).ToString()));
                // ele soma a variavel e volta ao inicio do bloco
                i++;
            }
            */

            //ele vai fazer o codigo pelo menos uma vez depois ira fazer a verificação
            do
            {
                ListViewItem itmx = listView1.Items.Add(iValorLido.ToString());
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "*"));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, i.ToString()));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "="));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, (iValorLido * i).ToString()));
                // ele soma a variavel e volta ao inicio do bloco
                i++;
            } while (i <= 10);
        }

        private void frmEstruturasRepeticao_Load(object sender, EventArgs e)
        {
            //variavel para o while
            int i = 0;
            //limpa as informaçoes do listview
            listView1.Clear();
            //valor1 sinal valor2 = resultado
            //criação de colunas com tamanho 
            listView1.Columns.Insert(0, " Valor", 40, HorizontalAlignment.Center);
            listView1.Columns.Insert(1, " sinal", 40, HorizontalAlignment.Center);
            listView1.Columns.Insert(2, " Valor", 40, HorizontalAlignment.Center);
            listView1.Columns.Insert(3, " igual", 40, HorizontalAlignment.Center);
            listView1.Columns.Insert(4, " resultado", 40, HorizontalAlignment.Center);
            /*
            for (int i = 0; i <=100; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            */

            /*
            while(i <= 100)
            {
                comboBox1.Items.Add(i.ToString());
                i++;
            }
            */

            do
            {
                comboBox1.Items.Add(i.ToString());
                i++;
            } while (i <= 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você devera informar um valor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }
            lista.Add(Convert.ToInt32(textBox2.Text.Trim()));
            listBox1.Items.Add(textBox2.Text.Trim());
            textBox2.Text = string.Empty;
            textBox2.Focus();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //foreach faz a execução do mesmo codigo diversas vezes sm que precisa mudar o 
            // codigo
            foreach (string item in listBox1.Items)
            {
                listBox2.Items.Add(item);
            }
        }
    }
}
