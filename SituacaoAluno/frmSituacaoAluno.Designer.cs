using System.Windows.Forms;

namespace SituacaoAluno
{
    partial class frmSituacaoAluno
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cboPesoNota1 = new System.Windows.Forms.ComboBox();
            this.cboPesoNota2 = new System.Windows.Forms.ComboBox();
            this.cboPesoTrabalho = new System.Windows.Forms.ComboBox();
            this.grpSituacao = new System.Windows.Forms.GroupBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.grpRecuperacao = new System.Windows.Forms.GroupBox();
            this.txtNotaRecuperacao = new System.Windows.Forms.TextBox();
            this.grpMediaFinal = new System.Windows.Forms.GroupBox();
            this.lblValorMedia = new System.Windows.Forms.Label();
            this.grpAproveitamento = new System.Windows.Forms.GroupBox();
            this.lblValorAproveitamento = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblTrabalho = new System.Windows.Forms.Label();
            this.lblTotalAulas = new System.Windows.Forms.Label();
            this.lblTotalFaltas = new System.Windows.Forms.Label();
            this.lblNotaCorte = new System.Windows.Forms.Label();
            this.lblBotelim = new System.Windows.Forms.Label();
            this.numNotaCorte = new System.Windows.Forms.NumericUpDown();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtTrabalho = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtTotalAulas = new System.Windows.Forms.TextBox();
            this.txtTotalFaltas = new System.Windows.Forms.TextBox();
            this.grpSituacao.SuspendLayout();
            this.grpRecuperacao.SuspendLayout();
            this.grpMediaFinal.SuspendLayout();
            this.grpAproveitamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNotaCorte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.AccessibleName = "btnCalcular";
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.ForeColor = System.Drawing.Color.SeaShell;
            this.btnCalcular.Location = new System.Drawing.Point(274, 452);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(114, 49);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AccessibleName = "btnLimpar";
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.Color.SeaShell;
            this.btnLimpar.Location = new System.Drawing.Point(400, 452);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(114, 49);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cboPesoNota1
            // 
            this.cboPesoNota1.AccessibleName = "cboPesoNota1";
            this.cboPesoNota1.BackColor = System.Drawing.SystemColors.Window;
            this.cboPesoNota1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesoNota1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboPesoNota1.FormattingEnabled = true;
            this.cboPesoNota1.Items.AddRange(new object[] {
            "0,1",
            "0,2",
            "0,3",
            "0,4",
            "0,5",
            "0,6",
            "0,7",
            "0,8"});
            this.cboPesoNota1.Location = new System.Drawing.Point(30, 140);
            this.cboPesoNota1.Name = "cboPesoNota1";
            this.cboPesoNota1.Size = new System.Drawing.Size(104, 21);
            this.cboPesoNota1.TabIndex = 1;
            this.cboPesoNota1.SelectedIndex = 0;
            // 
            // cboPesoNota2
            // 
            this.cboPesoNota2.AccessibleName = "cboPesoNota2";
            this.cboPesoNota2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesoNota2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboPesoNota2.FormattingEnabled = true;
            this.cboPesoNota2.Items.AddRange(new object[] {
            "0,1",
            "0,2",
            "0,3",
            "0,4",
            "0,5",
            "0,6",
            "0,7",
            "0,8"});
            this.cboPesoNota2.Location = new System.Drawing.Point(153, 140);
            this.cboPesoNota2.Name = "cboPesoNota2";
            this.cboPesoNota2.Size = new System.Drawing.Size(104, 21);
            this.cboPesoNota2.TabIndex = 3;
            this.cboPesoNota2.SelectedIndex = 0;
            // 
            // cboPesoTrabalho
            // 
            this.cboPesoTrabalho.AccessibleName = "cboPesoTrabalho";
            this.cboPesoTrabalho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPesoTrabalho.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboPesoTrabalho.FormattingEnabled = true;
            this.cboPesoTrabalho.Items.AddRange(new object[] {
            "0,1",
            "0,2",
            "0,3",
            "0,4",
            "0,5",
            "0,6",
            "0,7",
            "0,8"});
            this.cboPesoTrabalho.Location = new System.Drawing.Point(271, 140);
            this.cboPesoTrabalho.Name = "cboPesoTrabalho";
            this.cboPesoTrabalho.Size = new System.Drawing.Size(104, 21);
            this.cboPesoTrabalho.TabIndex = 5;
            this.cboPesoTrabalho.SelectedIndex = 0;
            // 
            // grpSituacao
            // 
            this.grpSituacao.AccessibleName = "grpSituacao";
            this.grpSituacao.Controls.Add(this.lblSituacao);
            this.grpSituacao.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold);
            this.grpSituacao.Location = new System.Drawing.Point(442, 310);
            this.grpSituacao.Name = "grpSituacao";
            this.grpSituacao.Size = new System.Drawing.Size(200, 90);
            this.grpSituacao.TabIndex = 17;
            this.grpSituacao.TabStop = false;
            this.grpSituacao.Text = "Situação";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AccessibleName = "lblSituacao";
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblSituacao.Location = new System.Drawing.Point(3, 29);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(0, 31);
            this.lblSituacao.TabIndex = 0;
            // 
            // grpRecuperacao
            // 
            this.grpRecuperacao.AccessibleName = "grpRecuperacao";
            this.grpRecuperacao.Controls.Add(this.txtNotaRecuperacao);
            this.grpRecuperacao.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold);
            this.grpRecuperacao.ForeColor = System.Drawing.Color.Firebrick;
            this.grpRecuperacao.Location = new System.Drawing.Point(551, 89);
            this.grpRecuperacao.Name = "grpRecuperacao";
            this.grpRecuperacao.Size = new System.Drawing.Size(171, 87);
            this.grpRecuperacao.TabIndex = 17;
            this.grpRecuperacao.TabStop = false;
            this.grpRecuperacao.Text = "Recuperação";
            this.grpRecuperacao.Visible = false;
            // 
            // txtNotaRecuperacao
            // 
            this.txtNotaRecuperacao.AccessibleName = "txtNotaRecuperacao";
            this.txtNotaRecuperacao.Location = new System.Drawing.Point(33, 42);
            this.txtNotaRecuperacao.Name = "txtNotaRecuperacao";
            this.txtNotaRecuperacao.Size = new System.Drawing.Size(104, 33);
            this.txtNotaRecuperacao.TabIndex = 2;
            this.txtNotaRecuperacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpMediaFinal
            // 
            this.grpMediaFinal.AccessibleName = "grpMediaFinal";
            this.grpMediaFinal.Controls.Add(this.lblValorMedia);
            this.grpMediaFinal.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold);
            this.grpMediaFinal.Location = new System.Drawing.Point(30, 310);
            this.grpMediaFinal.Name = "grpMediaFinal";
            this.grpMediaFinal.Size = new System.Drawing.Size(200, 90);
            this.grpMediaFinal.TabIndex = 23;
            this.grpMediaFinal.TabStop = false;
            this.grpMediaFinal.Text = "Média Final";
            // 
            // lblValorMedia
            // 
            this.lblValorMedia.AccessibleName = "lblValorMedia";
            this.lblValorMedia.AutoSize = true;
            this.lblValorMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValorMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMedia.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblValorMedia.Location = new System.Drawing.Point(3, 29);
            this.lblValorMedia.Name = "lblValorMedia";
            this.lblValorMedia.Size = new System.Drawing.Size(0, 31);
            this.lblValorMedia.TabIndex = 21;
            // 
            // grpAproveitamento
            // 
            this.grpAproveitamento.AccessibleName = "grpAproveitamento";
            this.grpAproveitamento.Controls.Add(this.lblValorAproveitamento);
            this.grpAproveitamento.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold);
            this.grpAproveitamento.Location = new System.Drawing.Point(236, 310);
            this.grpAproveitamento.Name = "grpAproveitamento";
            this.grpAproveitamento.Size = new System.Drawing.Size(200, 90);
            this.grpAproveitamento.TabIndex = 23;
            this.grpAproveitamento.TabStop = false;
            this.grpAproveitamento.Text = "Aproveitamento";
            // 
            // lblValorAproveitamento
            // 
            this.lblValorAproveitamento.AccessibleName = "lblValorAproveitamento";
            this.lblValorAproveitamento.AutoSize = true;
            this.lblValorAproveitamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValorAproveitamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAproveitamento.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblValorAproveitamento.Location = new System.Drawing.Point(3, 29);
            this.lblValorAproveitamento.Name = "lblValorAproveitamento";
            this.lblValorAproveitamento.Size = new System.Drawing.Size(0, 31);
            this.lblValorAproveitamento.TabIndex = 22;
            // 
            // lblNota1
            // 
            this.lblNota1.AccessibleName = "lblNota1";
            this.lblNota1.AutoSize = true;
            this.lblNota1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblNota1.Location = new System.Drawing.Point(50, 88);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(57, 21);
            this.lblNota1.TabIndex = 19;
            this.lblNota1.Text = "Nota 1";
            // 
            // lblNota2
            // 
            this.lblNota2.AccessibleName = "lblNota2";
            this.lblNota2.AutoSize = true;
            this.lblNota2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblNota2.Location = new System.Drawing.Point(173, 89);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(57, 21);
            this.lblNota2.TabIndex = 19;
            this.lblNota2.Text = "Nota 2";
            // 
            // lblTrabalho
            // 
            this.lblTrabalho.AccessibleName = "lblTrabalho";
            this.lblTrabalho.AutoSize = true;
            this.lblTrabalho.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabalho.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblTrabalho.Location = new System.Drawing.Point(285, 88);
            this.lblTrabalho.Name = "lblTrabalho";
            this.lblTrabalho.Size = new System.Drawing.Size(77, 21);
            this.lblTrabalho.TabIndex = 19;
            this.lblTrabalho.Text = "Trabalho";
            // 
            // lblTotalAulas
            // 
            this.lblTotalAulas.AccessibleName = "lblTotalAulas";
            this.lblTotalAulas.AutoSize = true;
            this.lblTotalAulas.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAulas.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblTotalAulas.Location = new System.Drawing.Point(26, 206);
            this.lblTotalAulas.Name = "lblTotalAulas";
            this.lblTotalAulas.Size = new System.Drawing.Size(116, 21);
            this.lblTotalAulas.TabIndex = 19;
            this.lblTotalAulas.Text = "Total de Aulas";
            // 
            // lblTotalFaltas
            // 
            this.lblTotalFaltas.AccessibleName = "lblTotalFaltas";
            this.lblTotalFaltas.AutoSize = true;
            this.lblTotalFaltas.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFaltas.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblTotalFaltas.Location = new System.Drawing.Point(26, 232);
            this.lblTotalFaltas.Name = "lblTotalFaltas";
            this.lblTotalFaltas.Size = new System.Drawing.Size(116, 21);
            this.lblTotalFaltas.TabIndex = 19;
            this.lblTotalFaltas.Text = "Total de Faltas";
            // 
            // lblNotaCorte
            // 
            this.lblNotaCorte.AccessibleName = "lblNotaCorte";
            this.lblNotaCorte.AutoSize = true;
            this.lblNotaCorte.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaCorte.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblNotaCorte.Location = new System.Drawing.Point(396, 89);
            this.lblNotaCorte.Name = "lblNotaCorte";
            this.lblNotaCorte.Size = new System.Drawing.Size(111, 21);
            this.lblNotaCorte.TabIndex = 19;
            this.lblNotaCorte.Text = "Nota de Corte";
            // 
            // lblBotelim
            // 
            this.lblBotelim.AccessibleName = "lblBotelim";
            this.lblBotelim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBotelim.AutoSize = true;
            this.lblBotelim.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBotelim.Font = new System.Drawing.Font("CountryBlueprint", 26.25F, System.Drawing.FontStyle.Bold);
            this.lblBotelim.Location = new System.Drawing.Point(77, 9);
            this.lblBotelim.Name = "lblBotelim";
            this.lblBotelim.Size = new System.Drawing.Size(611, 48);
            this.lblBotelim.TabIndex = 20;
            this.lblBotelim.Text = "    Verificação de Status do Aluno    ";
            // 
            // numNotaCorte
            // 
            this.numNotaCorte.AccessibleName = "numNotaCorte";
            this.numNotaCorte.Location = new System.Drawing.Point(400, 114);
            this.numNotaCorte.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numNotaCorte.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numNotaCorte.Name = "numNotaCorte";
            this.numNotaCorte.Size = new System.Drawing.Size(103, 20);
            this.numNotaCorte.TabIndex = 8;
            this.numNotaCorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numNotaCorte.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // txtNota1
            // 
            this.txtNota1.AcceptsReturn = true;
            this.txtNota1.AccessibleName = "txtNota1";
            this.txtNota1.Location = new System.Drawing.Point(30, 114);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(104, 20);
            this.txtNota1.TabIndex = 0;
            this.txtNota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTrabalho
            // 
            this.txtTrabalho.AccessibleName = "txtTrabalho";
            this.txtTrabalho.Location = new System.Drawing.Point(271, 114);
            this.txtTrabalho.Name = "txtTrabalho";
            this.txtTrabalho.Size = new System.Drawing.Size(104, 20);
            this.txtTrabalho.TabIndex = 4;
            this.txtTrabalho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNota2
            // 
            this.txtNota2.AcceptsReturn = true;
            this.txtNota2.AccessibleName = "txtNota2";
            this.txtNota2.Location = new System.Drawing.Point(153, 114);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(104, 20);
            this.txtNota2.TabIndex = 2;
            this.txtNota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalAulas
            // 
            this.txtTotalAulas.AccessibleName = "txtTotalAulas";
            this.txtTotalAulas.Location = new System.Drawing.Point(153, 206);
            this.txtTotalAulas.Name = "txtTotalAulas";
            this.txtTotalAulas.Size = new System.Drawing.Size(104, 20);
            this.txtTotalAulas.TabIndex = 6;
            this.txtTotalAulas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalFaltas
            // 
            this.txtTotalFaltas.AccessibleName = "txtTotalFaltas";
            this.txtTotalFaltas.Location = new System.Drawing.Point(153, 232);
            this.txtTotalFaltas.Name = "txtTotalFaltas";
            this.txtTotalFaltas.Size = new System.Drawing.Size(104, 20);
            this.txtTotalFaltas.TabIndex = 7;
            this.txtTotalFaltas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmSituacaoAluno
            // 
            this.AccessibleName = "frmSituacaoAluno";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(779, 549);
            this.Controls.Add(this.grpAproveitamento);
            this.Controls.Add(this.lblBotelim);
            this.Controls.Add(this.lblTotalFaltas);
            this.Controls.Add(this.lblTotalAulas);
            this.Controls.Add(this.lblTrabalho);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNotaCorte);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grpRecuperacao);
            this.Controls.Add(this.grpSituacao);
            this.Controls.Add(this.numNotaCorte);
            this.Controls.Add(this.txtTotalFaltas);
            this.Controls.Add(this.txtTotalAulas);
            this.Controls.Add(this.cboPesoNota2);
            this.Controls.Add(this.cboPesoTrabalho);
            this.Controls.Add(this.cboPesoNota1);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtTrabalho);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.grpMediaFinal);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSituacaoAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Situação Aluno";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSituacao.ResumeLayout(false);
            this.grpSituacao.PerformLayout();
            this.grpRecuperacao.ResumeLayout(false);
            this.grpRecuperacao.PerformLayout();
            this.grpMediaFinal.ResumeLayout(false);
            this.grpMediaFinal.PerformLayout();
            this.grpAproveitamento.ResumeLayout(false);
            this.grpAproveitamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNotaCorte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtNota1;
        private TextBox txtTrabalho;
        private TextBox txtNota2;
        private ComboBox cboPesoNota1;
        private ComboBox cboPesoTrabalho;
        private ComboBox cboPesoNota2;
        private TextBox txtTotalAulas;
        private TextBox txtTotalFaltas;
        private NumericUpDown numNotaCorte;
        private GroupBox grpSituacao;
        private Label lblSituacao;
        private GroupBox grpRecuperacao;
        private TextBox txtNotaRecuperacao;
        private Button btnCalcular;
        private Button btnLimpar;
        private Label lblNota1;
        private Label lblNota2;
        private Label lblTrabalho;
        private Label lblTotalAulas;
        private Label lblTotalFaltas;
        private Label lblNotaCorte;
        private Label lblBotelim;
        private Label lblValorMedia;
        private Label lblValorAproveitamento;
        private GroupBox grpMediaFinal;
        private GroupBox grpAproveitamento;
    }
}

