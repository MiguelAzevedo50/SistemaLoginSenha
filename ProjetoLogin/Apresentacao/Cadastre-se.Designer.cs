
namespace ProjetoLogin.Apresentacao
{
    partial class CadastreSe
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
            this.lblLoginCadastro = new System.Windows.Forms.Label();
            this.lblLoginSenha = new System.Windows.Forms.Label();
            this.lblLoginConfirmarSenha = new System.Windows.Forms.Label();
            this.txbLoginCadastro = new System.Windows.Forms.TextBox();
            this.txbConfirmarSenhaCadastro = new System.Windows.Forms.TextBox();
            this.txbSenhaCadastro = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginCadastro
            // 
            this.lblLoginCadastro.AutoSize = true;
            this.lblLoginCadastro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginCadastro.Location = new System.Drawing.Point(26, 34);
            this.lblLoginCadastro.Name = "lblLoginCadastro";
            this.lblLoginCadastro.Size = new System.Drawing.Size(44, 19);
            this.lblLoginCadastro.TabIndex = 0;
            this.lblLoginCadastro.Text = "Login";
            // 
            // lblLoginSenha
            // 
            this.lblLoginSenha.AutoSize = true;
            this.lblLoginSenha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginSenha.Location = new System.Drawing.Point(26, 115);
            this.lblLoginSenha.Name = "lblLoginSenha";
            this.lblLoginSenha.Size = new System.Drawing.Size(48, 19);
            this.lblLoginSenha.TabIndex = 1;
            this.lblLoginSenha.Text = "Senha";
            // 
            // lblLoginConfirmarSenha
            // 
            this.lblLoginConfirmarSenha.AutoSize = true;
            this.lblLoginConfirmarSenha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginConfirmarSenha.Location = new System.Drawing.Point(26, 198);
            this.lblLoginConfirmarSenha.Name = "lblLoginConfirmarSenha";
            this.lblLoginConfirmarSenha.Size = new System.Drawing.Size(115, 19);
            this.lblLoginConfirmarSenha.TabIndex = 2;
            this.lblLoginConfirmarSenha.Text = "Confirmar Senha";
            // 
            // txbLoginCadastro
            // 
            this.txbLoginCadastro.Location = new System.Drawing.Point(29, 64);
            this.txbLoginCadastro.Name = "txbLoginCadastro";
            this.txbLoginCadastro.Size = new System.Drawing.Size(266, 20);
            this.txbLoginCadastro.TabIndex = 3;
            // 
            // txbConfirmarSenhaCadastro
            // 
            this.txbConfirmarSenhaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConfirmarSenhaCadastro.Location = new System.Drawing.Point(29, 236);
            this.txbConfirmarSenhaCadastro.Name = "txbConfirmarSenhaCadastro";
            this.txbConfirmarSenhaCadastro.PasswordChar = '*';
            this.txbConfirmarSenhaCadastro.Size = new System.Drawing.Size(172, 22);
            this.txbConfirmarSenhaCadastro.TabIndex = 4;
            // 
            // txbSenhaCadastro
            // 
            this.txbSenhaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenhaCadastro.Location = new System.Drawing.Point(29, 149);
            this.txbSenhaCadastro.Name = "txbSenhaCadastro";
            this.txbSenhaCadastro.PasswordChar = '*';
            this.txbSenhaCadastro.Size = new System.Drawing.Size(172, 22);
            this.txbSenhaCadastro.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(103, 289);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(135, 48);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // CadastreSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 365);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbSenhaCadastro);
            this.Controls.Add(this.txbConfirmarSenhaCadastro);
            this.Controls.Add(this.txbLoginCadastro);
            this.Controls.Add(this.lblLoginConfirmarSenha);
            this.Controls.Add(this.lblLoginSenha);
            this.Controls.Add(this.lblLoginCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastreSe";
            this.Text = "Cadastre_se";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginCadastro;
        private System.Windows.Forms.Label lblLoginSenha;
        private System.Windows.Forms.Label lblLoginConfirmarSenha;
        private System.Windows.Forms.TextBox txbLoginCadastro;
        private System.Windows.Forms.TextBox txbConfirmarSenhaCadastro;
        private System.Windows.Forms.TextBox txbSenhaCadastro;
        private System.Windows.Forms.Button btnCadastrar;
    }
}