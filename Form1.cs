﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //declaração de variáveis, string, float
        string lbl, operação; //lbl para alterar texto da label e operação para tomar decisão de qual operação fazer
        float num1, num2; //números para mandar para a classe cálculo
        bool interruptor; //interruptor para formatar label após operação

        Calculos cal = new Calculos(); //instanciando a classe cálculo

        //lblDisblay.Text
        public string LblD()
        {
            lbl= lblDisplay.Text;

            return lbl;
        }

        //contador, conversão do lblDisplay.text para number
    
       


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //botão de fechar o sistema!
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (interruptor == true)
            {
                lblConta.Text = ("");
                lbl = "0";
                lblDisplay.Text = lbl;
                interruptor = false;
            }
            //teclado numérico
            if (lbl == "0")
            {
                lbl = "4";
                lblDisplay.Text = this.lbl;
            }
            else
            {
                lbl = lbl + "4";
                lblDisplay.Text = this.lbl;
            }
           
        }

        private void lblDisplay_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (interruptor == true)
            {
                lblConta.Text = ("");
                lbl = "0";
                lblDisplay.Text = lbl;
                interruptor = false;
            }
            //teclado numérico
            if (lbl == "0")
            {
                lbl = "7";
                lblDisplay.Text = this.lbl;
            }
            else
            {
                lbl = lbl + "7";
                lblDisplay.Text = this.lbl;
            }
          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //botão de limpar o label
            lbl = "0";
            lblDisplay.Text = this.lbl;
            lblConta.Text = "";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (interruptor == true)
            {
                lblConta.Text = ("");
                lbl = "0";
                lblDisplay.Text = lbl;
                interruptor = false;
            }
            //teclado numérico
            if (lbl == "0")
            {
                lbl = "8";
                lblDisplay.Text = this.lbl;
            }
            else
            {
                lbl = lbl + "8";
                lblDisplay.Text = this.lbl;
            }
       
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (interruptor == true)
            {
                lblConta.Text = ("");
                lbl = "0";
                lblDisplay.Text = lbl;
                interruptor = false;
            }
            //teclado numérico
            if (lbl == "0")
            {
                lbl = "9";
                lblDisplay.Text = this.lbl;
            }
            else
            {
                lbl = lbl + "9";
                lblDisplay.Text = this.lbl;
            }
 
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (interruptor == true)
            {
                lblConta.Text = ("");
                lbl = "0";
                lblDisplay.Text = lbl;
                interruptor = false;
            }
            //teclado numérico
            if (lbl == "0")
            {
                lbl = "5";
                lblDisplay.Text = this.lbl;
            }
            else
            {
                lbl = lbl + "5";
                lblDisplay.Text = this.lbl;
            }
          
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (interruptor == true)
            {
                lblConta.Text = ("");
                lbl = "0";
                lblDisplay.Text = lbl;
                interruptor = false;
            }
            //teclado numérico
            if (lbl == "0")
            {
                lbl = "6";
                lblDisplay.Text = this.lbl;
            }
            else
            {
                lbl = lbl + "6";
                lblDisplay.Text = this.lbl;
            }
      
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (interruptor == true)
            {
                lblConta.Text = ("");
                lbl = "0";
                lblDisplay.Text = lbl;
                interruptor = false;
            }
            //teclado numérico
            if (lbl == "0")
            {
                lbl = "1";
                lblDisplay.Text = this.lbl;
            }
            else
            {
                lbl = lbl + "1";
                lblDisplay.Text = this.lbl;
            }

        }

            private void btn2_Click(object sender, EventArgs e)
            {
            if (interruptor == true)
            {
                lblConta.Text = ("");
                lbl = "0";
                lblDisplay.Text = lbl;
                interruptor = false;
            }
            //teclado numérico
            if (lbl == "0")
                {
                    lbl = "2";
                    lblDisplay.Text = this.lbl;
                }
                else
                {
                    lbl = lbl + "2";
                    lblDisplay.Text = this.lbl;
                }
     
            }

            private void btn3_Click(object sender, EventArgs e)
        {
            if (interruptor == true)
            {
                lblConta.Text = ("");
                lbl = "0";
                lblDisplay.Text = lbl;
                interruptor = false;
            }
            //teclado numérico
            if (lbl == "0")
            {
                lbl = "3";
                lblDisplay.Text = this.lbl;
            }
            else
            {
                lbl = lbl + "3";
                lblDisplay.Text = this.lbl;
            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //interruptor para apagar os label após uma operação já ser efetuada
            if (interruptor == true)
            {
                lblConta.Text = ("");
                lbl = "0";
                lblDisplay.Text = lbl;
                interruptor = false;
            }
            //teclado numérico
            if (lbl == "0")
            {
                lbl = "0";
                lblDisplay.Text = this.lbl;
            }
            else
            {
                lbl = lbl + "0";
                lblDisplay.Text = this.lbl;
            }

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = float.Parse(lblDisplay.Text);
            //interruptor para limpar os labels após uma operação concluída
            interruptor = true;

            if (operação == "soma")
            {
                //operação soma, comunicando com a função soma na classe Calculos
                cal.soma(num1, num2);
                lbl = Convert.ToString(cal.resultado);
                lblDisplay.Text = lbl;
                lblConta.Text = Convert.ToString(num1) + "+" + Convert.ToString(num2) + "=";
                operação = "null";
            }
            else if(operação == "subtrair")
            {
                //operação subtrair, comunicando com a função subtração na classe Calculos
                cal.subtração(num1, num2);
                lbl = Convert.ToString(cal.resultado);
                lblDisplay.Text = lbl;
                lblConta.Text = Convert.ToString(num1) + "-" + Convert.ToString(num2) + "=";
                operação = "null";
            }
            else if (operação == "multiplicação")
            {
                //operação multiplicação, comunicando com a função multiplicação na classe Calculos
                cal.multiplicação(num1, num2);
                lbl = Convert.ToString(cal.resultado);
                lblDisplay.Text = lbl;
                lblConta.Text = Convert.ToString(num1) + "x" + Convert.ToString(num2) + "=";
                operação = "null";
            }
            else if (operação == "divisão")
            {
                //operação divisão, comunicando com a função divisão na classe Calculos
                cal.divisão(num1, num2);
                lbl = Convert.ToString(cal.resultado);
                lblDisplay.Text = lbl;
                lblConta.Text = Convert.ToString(num1) + "÷" + Convert.ToString(num2) + "=";
                operação = "null";
            }

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            //desativando interruptor se o usuário quiser realizar uma operação com o resultado
            if (interruptor == true)
            {
                interruptor = false;
            }
            num1 = float.Parse(lblDisplay.Text);
            lblConta.Text = Convert.ToString(num1) + "-";
            this.operação = "subtrair";
            lbl = "0";
            lblDisplay.Text = lbl;
        }

        private void bbtnMult_Click(object sender, EventArgs e)
        {
            if (interruptor == true)
            {
                interruptor = false;
            }
            num1 = float.Parse(lblDisplay.Text);
            lblConta.Text = Convert.ToString(num1) + "x";
            this.operação = "multiplicação";
            lbl = "0";
            lblDisplay.Text = lbl;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (interruptor == true)
            {
                interruptor = false;
            }
            num1 = float.Parse(lblDisplay.Text);
            lblConta.Text = Convert.ToString(num1) + "÷";
            this.operação = "divisão";
            lbl = "0";
            lblDisplay.Text = lbl;
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            //Alteração de sinal do número, neggativo/positivo
            if (interruptor == true)
            {
                lblConta.Text = ("");
                interruptor = false;
            }
            float display;
            display = float.Parse(lblDisplay.Text);
            lbl = lblDisplay.Text;
            if (display > 0)
            {
                lblDisplay.Text = "-" + lbl;
                lbl = lblDisplay.Text;
            }
            else
            {
                lblDisplay.Text = lbl.TrimStart('-');
                lbl = lblDisplay.Text;
            }

        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            //adicionar decimal no número
            if (interruptor == true)
            {
                lblConta.Text = ("");
                interruptor = false;
            }
            //teclado numérico
            if (lbl == "0" | lbl==" " | lbl==null)
            {
                lbl = "0" + ",";
                lblDisplay.Text =this.lbl;
            }
            else
            {
                lbl = lbl + ",";
                lblDisplay.Text = this.lbl;
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

            //porcentagem realizada sem a necessidade de apertar o botão de igualdade
            if (interruptor == true)
            {
                interruptor = false;
            }
            num1 = float.Parse(lblDisplay.Text);
            cal.porcentagem(num1);
            lbl = Convert.ToString(cal.resultado);
            lblDisplay.Text = lbl;
            lblConta.Text = Convert.ToString(num1) + "%" + " =";
            operação = "null";
            
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            //minimizar a aplicação
            this.WindowState=FormWindowState.Minimized;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
          
                //botão de backspace
                //lbl.Length verifica a quantidade de algorismo no lbl, (-1) remove o último algoritmo, apaga.
                if (lblDisplay.Text =="0" | lbl.Length == 1)
                {
                    //se o label for apenas uma unidade, deixar o label 0
                    lbl = "0";
                    lblDisplay.Text = this.lbl;
                }
                else
                {
                    //apaga o último valor do label
                    lbl = lbl.Substring(0, lbl.Length - 1);
                    lblDisplay.Text = this.lbl;
                }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //botão de soma, ativando o interruptor soma
            if (interruptor == true)
            {
                interruptor = false;
            }
            num1 = float.Parse(lblDisplay.Text);
            lblConta.Text = Convert.ToString(num1) + "+";
            this.operação = "soma";
            lbl = "0";
            lblDisplay.Text = lbl;

        }
    }
}
