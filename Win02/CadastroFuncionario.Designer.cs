namespace Win02
{
    partial class CadastroFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.gbTipoContrato = new System.Windows.Forms.GroupBox();
            this.rbAutonomo = new System.Windows.Forms.RadioButton();
            this.rbPj = new System.Windows.Forms.RadioButton();
            this.rbClt = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblErro = new System.Windows.Forms.Label();
            this.gbSexo.SuspendLayout();
            this.gbTipoContrato.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(13, 220);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(50, 16);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salario";
            this.lblSalario.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 65);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(339, 22);
            this.txtNome.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(16, 165);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(339, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(16, 265);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 22);
            this.txtSalario.TabIndex = 5;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbMasculino);
            this.gbSexo.Controls.Add(this.rbFeminino);
            this.gbSexo.Location = new System.Drawing.Point(434, 20);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(354, 120);
            this.gbSexo.TabIndex = 6;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(36, 47);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(89, 20);
            this.rbMasculino.TabIndex = 8;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(188, 47);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(83, 20);
            this.rbFeminino.TabIndex = 0;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // gbTipoContrato
            // 
            this.gbTipoContrato.Controls.Add(this.rbAutonomo);
            this.gbTipoContrato.Controls.Add(this.rbPj);
            this.gbTipoContrato.Controls.Add(this.rbClt);
            this.gbTipoContrato.Location = new System.Drawing.Point(434, 187);
            this.gbTipoContrato.Name = "gbTipoContrato";
            this.gbTipoContrato.Size = new System.Drawing.Size(354, 120);
            this.gbTipoContrato.TabIndex = 7;
            this.gbTipoContrato.TabStop = false;
            this.gbTipoContrato.Text = "Tipo de Contrato";
            // 
            // rbAutonomo
            // 
            this.rbAutonomo.AutoSize = true;
            this.rbAutonomo.Location = new System.Drawing.Point(234, 57);
            this.rbAutonomo.Name = "rbAutonomo";
            this.rbAutonomo.Size = new System.Drawing.Size(89, 20);
            this.rbAutonomo.TabIndex = 3;
            this.rbAutonomo.TabStop = true;
            this.rbAutonomo.Text = "Autonomo";
            this.rbAutonomo.UseVisualStyleBackColor = true;
            // 
            // rbPj
            // 
            this.rbPj.AutoSize = true;
            this.rbPj.Location = new System.Drawing.Point(144, 57);
            this.rbPj.Name = "rbPj";
            this.rbPj.Size = new System.Drawing.Size(44, 20);
            this.rbPj.TabIndex = 2;
            this.rbPj.TabStop = true;
            this.rbPj.Text = "PJ";
            this.rbPj.UseVisualStyleBackColor = true;
            // 
            // rbClt
            // 
            this.rbClt.AutoSize = true;
            this.rbClt.Location = new System.Drawing.Point(45, 57);
            this.rbClt.Name = "rbClt";
            this.rbClt.Size = new System.Drawing.Size(53, 20);
            this.rbClt.TabIndex = 1;
            this.rbClt.TabStop = true;
            this.rbClt.Text = "CLT";
            this.rbClt.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(16, 448);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 40);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.SalvarAction);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(12, 328);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 16);
            this.lblErro.TabIndex = 9;
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbTipoContrato);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastroFuncionario";
            this.Text = "Cadastro de funcionario";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbTipoContrato.ResumeLayout(false);
            this.gbTipoContrato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.GroupBox gbTipoContrato;
        private System.Windows.Forms.RadioButton rbAutonomo;
        private System.Windows.Forms.RadioButton rbPj;
        private System.Windows.Forms.RadioButton rbClt;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblErro;
    }
}