using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SituacaoAluno
{
    public partial class frmSituacaoAluno : Form
    {
        public frmSituacaoAluno()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {


            int VerificadorPreenchimento = 0;

            double PesoNota1, PesoNota2, PesoTrabalho, SomaPesos, NotaCorte,
                Media = 0, PorcetagemPresenca = 0, Aproveitamento = 0;

            PesoNota1 = Convert.ToDouble(cboPesoNota1.Text);
            PesoNota2 = Convert.ToDouble(cboPesoNota2.Text);
            PesoTrabalho = Convert.ToDouble(cboPesoTrabalho.Text);
            NotaCorte = Convert.ToDouble(numNotaCorte.Text);

            var Nota1IsNotNull = Double.TryParse(txtNota1.Text, out double Nota1);
            var Nota2IsNotNull = Double.TryParse(txtNota2.Text, out double Nota2);
            var TrabalhoIsNotNull = Double.TryParse(txtTrabalho.Text, out double Trabalho);
            var QtdeAulasIsNotNull = Double.TryParse(txtTotalAulas.Text, out double QtdeAulas);
            var QtdeFaltasIsNotNull = Double.TryParse(txtTotalFaltas.Text, out double QtdeFaltas);
            var NotaRecuperacaoIsNotNull = Double.TryParse(txtNotaRecuperacao.Text, out double NotaRecuperacao);

            SomaPesos = PesoNota1 + PesoNota2 + PesoTrabalho;
            Media = (Nota1 * PesoNota1) + (Nota2 * PesoNota2) + (Trabalho * PesoTrabalho);
            PorcetagemPresenca = 100 - ((QtdeFaltas / QtdeAulas) * 100);
            Aproveitamento = (((Media * 10) + PorcetagemPresenca) / 2);


            foreach (Control TextBox in this.Controls)
            {
                if (string.IsNullOrWhiteSpace(TextBox.Text))
                {
                    VerificadorPreenchimento++;
                }
            }

            //Não executa sem ter o campos limpos, caso tenha feito uma operação anteriormente
            if (lblSituacao.Text == "Aprovado" || lblSituacao.Text == "Reprovado")
            {
                MessageBox.Show("Clique em Limpar antes de executar outro cálculo",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Sequência de verificadores para confimar se o preenchimento está correto
            else if (VerificadorPreenchimento != 0)
            {
                MessageBox.Show("Preencha todos os dados. " + VerificadorPreenchimento + " dados incompletos!\n" +
                                "Verifique se a nota de corte está correta!\n" +
                                "Verifique se a somátoria dos pesos está correta!\n",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VerificadorPreenchimento = 0;
            }

            else if (!Nota1IsNotNull || !Nota2IsNotNull || !TrabalhoIsNotNull || !QtdeAulasIsNotNull || !QtdeFaltasIsNotNull)
            {
                MessageBox.Show("Digite apenas números!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (0 > Nota1 || Nota1 > 10
                    || 0 > Nota2 || Nota2 > 10
                    || 0 > Trabalho || Trabalho > 10)
            {
                MessageBox.Show("Digite apenas notas entre zero e dez",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (SomaPesos != 1)
            {
                MessageBox.Show("O valor da somatória dos pesos das notas e trabalho precisa ser igual a um",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (PorcetagemPresenca < 0)
            {
                MessageBox.Show("Quantidade de faltas excendendo a quantidade de aulas",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (NotaRecuperacaoIsNotNull && lblSituacao.Text == "")
            {
                MessageBox.Show("A nota de recuperação deve ser digitada após os cálculos!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Inicio da execução dos comandos
            else if (!NotaRecuperacaoIsNotNull)
            {
                lblValorMedia.Text = Media.ToString("N1");
                lblValorAproveitamento.Text = Aproveitamento.ToString("N2") + "%";

                if (PorcetagemPresenca >= 75)
                {
                    if (Media >= NotaCorte)
                    {
                        lblSituacao.Text = "Aprovado";
                        lblSituacao.ForeColor = Color.Green;
                    }

                    else if (2.5 < Media && Media < NotaCorte)
                    {
                        lblSituacao.Text = "Recuperação";
                        lblSituacao.ForeColor = Color.Firebrick;
                        MessageBox.Show("Digite a nota de recuperação!", "Aviso",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grpRecuperacao.Visible = true;
                    }

                }

                else if (Media <= 2.5 || PorcetagemPresenca < 75)
                {
                    lblSituacao.Text = "Reprovado";
                    lblSituacao.ForeColor = Color.Firebrick;
                }
            }

            else if (lblSituacao.Text == "Recuperação")
            {

                Media = (NotaRecuperacao + Media) / 2;

                if (Media >= NotaCorte)
                {
                    lblSituacao.Text = "Aprovado";
                    lblSituacao.ForeColor = Color.Green;
                    lblValorMedia.Text = Media.ToString("N2");
                }
                else
                {
                    lblSituacao.Text = "Reprovado";
                    lblSituacao.ForeColor = Color.Firebrick;
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblSituacao.Text = "";
            lblValorMedia.Text = "";
            lblValorAproveitamento.Text = "";
            txtNotaRecuperacao.Text = string.Empty;
            grpRecuperacao.Visible = false;


            foreach (Control Componente in this.Controls)
            {
                if (Componente is System.Windows.Forms.TextBox)
                {
                    (Componente as System.Windows.Forms.TextBox).Clear();
                }
                else
                {
                    if (Componente is System.Windows.Forms.ComboBox)
                    {
                        (Componente as System.Windows.Forms.ComboBox).SelectedIndex = 0;
                    }
                    else
                    {
                        if (Componente is NumericUpDown)
                        {
                            (Componente as NumericUpDown).Value = 5;
                        }
                    }
                }
            }
        }
    }
}
