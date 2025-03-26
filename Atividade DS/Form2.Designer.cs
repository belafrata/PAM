namespace Atividade_DS
{
    partial class frmmedia
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
            this.lblnota = new System.Windows.Forms.Label();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.lblmedia = new System.Windows.Forms.Label();
            this.txtmedia = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnota
            // 
            this.lblnota.AutoSize = true;
            this.lblnota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota.Location = new System.Drawing.Point(279, 42);
            this.lblnota.Name = "lblnota";
            this.lblnota.Size = new System.Drawing.Size(240, 24);
            this.lblnota.TabIndex = 0;
            this.lblnota.Text = "Digite a nota dos alunos:";
            // 
            // txtnota
            // 
            this.txtnota.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota.Location = new System.Drawing.Point(336, 108);
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(115, 38);
            this.txtnota.TabIndex = 1;
            // 
            // lblmedia
            // 
            this.lblmedia.AutoSize = true;
            this.lblmedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmedia.Location = new System.Drawing.Point(340, 207);
            this.lblmedia.Name = "lblmedia";
            this.lblmedia.Size = new System.Drawing.Size(111, 24);
            this.lblmedia.TabIndex = 2;
            this.lblmedia.Text = "A média é:";
            // 
            // txtmedia
            // 
            this.txtmedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmedia.Location = new System.Drawing.Point(336, 270);
            this.txtmedia.Name = "txtmedia";
            this.txtmedia.ReadOnly = true;
            this.txtmedia.Size = new System.Drawing.Size(115, 38);
            this.txtmedia.TabIndex = 3;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(440, 346);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(127, 65);
            this.btnlimpar.TabIndex = 4;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(221, 346);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(127, 65);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // frmmedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.txtmedia);
            this.Controls.Add(this.lblmedia);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.lblnota);
            this.Name = "frmmedia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnota;
        private System.Windows.Forms.TextBox txtnota;
        private System.Windows.Forms.Label lblmedia;
        private System.Windows.Forms.TextBox txtmedia;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncalcular;
    }
}