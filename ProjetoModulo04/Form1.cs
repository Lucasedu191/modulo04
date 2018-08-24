﻿using System;
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
    public partial class Form1 : Form
    {
        //variaveis de tipo global, definir se é privado e pode acessar de fora a variavel
        // tipo public ou private
        public const double pi = 3.1415;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            int numero1 = 12;
            int numero2 = 20;
            int soma = numero1 + numero2;
            int soma2 = 12 + 20;
            //é colocado o f no fim do numero para evidenciar que é flutuante
            float var1 = 1.5f;
            double var2 = 1.5;
            //é colocado constante antes do tipo da variavel para evidenciar 
            //que não pode alterar o valor antes da execução
            const double pi = 3.1415;
            //tipo caracter colocar tipo aspas simples
            char var3 = 'b';
            //tipo palavras colocar aspas duplas
            // String é alias (apelido) de string
            string var4 = "teste";

            //consegue guardar numeros maiores 32 bits (2 bilhoes ou 4 se nao utilizar o negativo
            // int é alias (apelido) do int32
            Int32 soma4 = 23;

            //numeros curtos vai de 32767 de positivo a negativo
            // short é alias (apelido) do int16
            short soma5 = 5;

            Int16 soma6 = 6;

            // variaveis do tipo booleana que escolhe entre duas opções verdadeiro ou falso
            // custuma chamar esse tipo de flag´s, utiliza em estruturas de repetição ou seleção
            //para testar ou guardar uma condicional    
            bool flag = true;

            // OPERADORES ARITMETICOS


            /*      + ==> SOMA
             *      - ==> SUBTRAÇÃO
             *      / ==> DIVISÃO
             *      * ==> MULTIPLICAÇÃO
            */




        }

        private void button1_Click(object sender, EventArgs e)
        {
            // realizar a as contas de tipo inteiros

            int numero3, numero4;
            // testa o resultado se o campo for vazio e pode apresentar o erro
            Boolean result1 = textBox1.Text.Trim().Equals(string.Empty);
            Boolean result2 = textBox2.Text.Trim().Equals(string.Empty);

            // realiza a verificação dos textbox para ver se nao está vazio o campo
            if (result1 == true || result2 == true)
            {
                MessageBox.Show("Insira todos os valores", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //realizar a leitura do text box convertendo em numero e retirando os espaços
            numero3 = Convert.ToInt32(textBox1.Text.Trim());
            numero4 = Convert.ToInt32(textBox2.Text.Trim());

            label1.Text = (numero3 + numero4).ToString();
            label2.Text = (numero3 - numero4).ToString();
            label3.Text = (numero3 / numero4).ToString();
            label4.Text = (numero3 * numero4).ToString();
        }
    }
}
