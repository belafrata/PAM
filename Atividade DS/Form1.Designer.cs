namespace Atividade_DS
{
    partial class frmsorteio
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
            this.lblsorteio = new System.Windows.Forms.Label();
            this.txtsorteio = new System.Windows.Forms.TextBox();
            this.btnsorteia = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsorteio
            // 
            this.lblsorteio.AutoSize = true;
            this.lblsorteio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsorteio.Location = new System.Drawing.Point(251, 64);
            this.lblsorteio.Name = "lblsorteio";
            this.lblsorteio.Size = new System.Drawing.Size(273, 24);
            this.lblsorteio.TabIndex = 0;
            this.lblsorteio.Text = "Sorteie números de 0 à 100:";
            // 
            // txtsorteio
            // 
            this.txtsorteio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsorteio.Location = new System.Drawing.Point(322, 186);
            this.txtsorteio.Multiline = true;
            this.txtsorteio.Name = "txtsorteio";
            this.txtsorteio.ReadOnly = true;
            this.txtsorteio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtsorteio.Size = new System.Drawing.Size(127, 42);
            this.txtsorteio.TabIndex = 1;
            // 
            // btnsorteia
            // 
            this.btnsorteia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsorteia.Location = new System.Drawing.Point(322, 305);
            this.btnsorteia.Name = "btnsorteia";
            this.btnsorteia.Size = new System.Drawing.Size(127, 65);
            this.btnsorteia.TabIndex = 2;
            this.btnsorteia.Text = "Sortear";
            this.btnsorteia.UseVisualStyleBackColor = true;
            this.btnsorteia.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(139, 305);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(127, 65);
            this.btnlimpar.TabIndex = 3;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(504, 305);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(127, 65);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmsorteio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsorteia);
            this.Controls.Add(this.txtsorteio);
            this.Controls.Add(this.lblsorteio);
            this.Name = "frmsorteio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorteio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsorteio;
        private System.Windows.Forms.TextBox txtsorteio;
        private System.Windows.Forms.Button btnsorteia;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}

