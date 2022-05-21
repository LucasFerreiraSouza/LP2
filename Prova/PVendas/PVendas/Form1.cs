using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PVendas
{
    public partial class frmPVendas : Form
    {
        public frmPVendas()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string auxiliar1;
            double[,] dados = new double[2, 4];
            double[] totalMes = new double[4];
            double total;
            double totalm;
            double totalFinal;

            total = 0;
            totalm = 0;
            totalFinal = 0;
            totalMes[0] = 0;

            for (var l = 0; l < 2; l++)
            {
                for (var c = 0; c < 4; c++)//Faz primeiro, (0,0) (0,1) (0,2)
                {
                    auxiliar1 = Interaction.InputBox("Mês " + (l + 1) + " semana " + (c + 1), "Entrada de Dados");
                    if (!double.TryParse(auxiliar1, out dados[l, c]))
                    {
                        MessageBox.Show("Valor inválido");
                        c = c - 1;
                    }
                    else
                    {
                        if (dados[l, c] < 0 || c == -1) // Se der alguma coisa errada
                        {
                            c = 0;
                            totalMes[l] = dados[l, c];// Variável acumuladora
                            MessageBox.Show("Digite um número maior que zero");
                            c = c - 1;

                        }
                        else
                        {
                            c = c + 0;//não muda
                            totalMes[l] = dados[l, c];// Variável acumuladora

                            lstbxDados.Items.Add("Total do mês: " + (l + 1) + " Semana: " + (c + 1) + " " + totalMes[l].ToString("C2"));

                            if (l == 0)
                            {
                                total = total + totalMes[l];
                            }
                            total = 0;

                            total = total + totalMes[l];
                            totalm = totalm+total;


                            totalFinal = totalFinal + total;
                        }
                    }
                }
                lstbxDados.Items.Add("Total mês: " + totalm.ToString("C2"));
            }
            lstbxDados.Items.Add("Total Geral: " + totalFinal.ToString("C2"));

            auxiliar1 = "";
        }
    }
}
