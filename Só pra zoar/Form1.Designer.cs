
namespace Só_pra_zoar
{
    partial class PrimeiraTela
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titulo = new System.Windows.Forms.Label();
            this.RespostaTxt = new System.Windows.Forms.TextBox();
            this.Perguntas = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnSim = new System.Windows.Forms.Button();
            this.Mensagem = new System.Windows.Forms.Label();
            this.cont = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titulo.Location = new System.Drawing.Point(220, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(448, 44);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Perguntadas";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RespostaTxt
            // 
            this.RespostaTxt.Location = new System.Drawing.Point(137, 295);
            this.RespostaTxt.Name = "RespostaTxt";
            this.RespostaTxt.Size = new System.Drawing.Size(601, 23);
            this.RespostaTxt.TabIndex = 1;
            this.RespostaTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RepostaTxt_KeyUp);
            // 
            // Perguntas
            // 
            this.Perguntas.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Perguntas.Location = new System.Drawing.Point(281, 154);
            this.Perguntas.Name = "Perguntas";
            this.Perguntas.Size = new System.Drawing.Size(330, 82);
            this.Perguntas.TabIndex = 2;
            this.Perguntas.Text = "Vamos começar?";
            this.Perguntas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(207, 358);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(128, 60);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnSim
            // 
            this.BtnSim.Location = new System.Drawing.Point(556, 358);
            this.BtnSim.Name = "BtnSim";
            this.BtnSim.Size = new System.Drawing.Size(112, 60);
            this.BtnSim.TabIndex = 4;
            this.BtnSim.Text = "Sim";
            this.BtnSim.UseVisualStyleBackColor = true;
            this.BtnSim.Click += new System.EventHandler(this.BtnSim_Click);
            // 
            // Mensagem
            // 
            this.Mensagem.AutoSize = true;
            this.Mensagem.ForeColor = System.Drawing.Color.Black;
            this.Mensagem.Location = new System.Drawing.Point(419, 256);
            this.Mensagem.Name = "Mensagem";
            this.Mensagem.Size = new System.Drawing.Size(38, 15);
            this.Mensagem.TabIndex = 5;
            this.Mensagem.Text = "label1";
            // 
            // cont
            // 
            this.cont.AutoSize = true;
            this.cont.Location = new System.Drawing.Point(12, 9);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(38, 15);
            this.cont.TabIndex = 6;
            this.cont.Text = "label1";
            this.cont.Visible = false;
            // 
            // PrimeiraTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 457);
            this.Controls.Add(this.cont);
            this.Controls.Add(this.Mensagem);
            this.Controls.Add(this.BtnSim);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.Perguntas);
            this.Controls.Add(this.RespostaTxt);
            this.Controls.Add(this.Titulo);
            this.Name = "PrimeiraTela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PrimeiraTela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox RepostaTxt;
        private System.Windows.Forms.Label Perguntas;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnSim;
        private System.Windows.Forms.Label Mensagem;
        private System.Windows.Forms.Label cont;
        private System.Windows.Forms.TextBox RespostaTxt;
    }
}

