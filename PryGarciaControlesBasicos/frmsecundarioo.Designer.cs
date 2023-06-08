namespace PryGarciaControlesBasicos
{
    partial class frmsecundarioo
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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.optRojo = new System.Windows.Forms.RadioButton();
            this.optAzul = new System.Windows.Forms.RadioButton();
            this.cmdAsignar = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.chkGarcia = new System.Windows.Forms.CheckBox();
            this.chkJasmin = new System.Windows.Forms.CheckBox();
            this.chkLourdes = new System.Windows.Forms.CheckBox();
            this.cmdEscribir = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(162, 35);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(383, 20);
            this.txtTexto.TabIndex = 1;
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
            // 
            // optRojo
            // 
            this.optRojo.AutoSize = true;
            this.optRojo.Checked = true;
            this.optRojo.Location = new System.Drawing.Point(207, 76);
            this.optRojo.Name = "optRojo";
            this.optRojo.Size = new System.Drawing.Size(47, 17);
            this.optRojo.TabIndex = 3;
            this.optRojo.TabStop = true;
            this.optRojo.Text = "Rojo";
            this.optRojo.UseVisualStyleBackColor = true;
            // 
            // optAzul
            // 
            this.optAzul.AutoSize = true;
            this.optAzul.Location = new System.Drawing.Point(374, 76);
            this.optAzul.Name = "optAzul";
            this.optAzul.Size = new System.Drawing.Size(45, 17);
            this.optAzul.TabIndex = 4;
            this.optAzul.TabStop = true;
            this.optAzul.Text = "Azul";
            this.optAzul.UseVisualStyleBackColor = true;
            // 
            // cmdAsignar
            // 
            this.cmdAsignar.Location = new System.Drawing.Point(239, 155);
            this.cmdAsignar.Name = "cmdAsignar";
            this.cmdAsignar.Size = new System.Drawing.Size(136, 24);
            this.cmdAsignar.TabIndex = 5;
            this.cmdAsignar.Text = "Asignar";
            this.cmdAsignar.UseVisualStyleBackColor = true;
            this.cmdAsignar.Click += new System.EventHandler(this.cmdAsignar_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(189, 222);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(259, 25);
            this.lblTexto.TabIndex = 6;
            this.lblTexto.Text = "Su texto aparecera aqui...";
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.chkGarcia);
            this.gbOpciones.Controls.Add(this.chkJasmin);
            this.gbOpciones.Controls.Add(this.chkLourdes);
            this.gbOpciones.Location = new System.Drawing.Point(202, 262);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(173, 100);
            this.gbOpciones.TabIndex = 7;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // chkGarcia
            // 
            this.chkGarcia.AutoSize = true;
            this.chkGarcia.Location = new System.Drawing.Point(52, 65);
            this.chkGarcia.Name = "chkGarcia";
            this.chkGarcia.Size = new System.Drawing.Size(57, 17);
            this.chkGarcia.TabIndex = 2;
            this.chkGarcia.Text = "Garcia";
            this.chkGarcia.UseVisualStyleBackColor = true;
            // 
            // chkJasmin
            // 
            this.chkJasmin.AutoSize = true;
            this.chkJasmin.Location = new System.Drawing.Point(52, 42);
            this.chkJasmin.Name = "chkJasmin";
            this.chkJasmin.Size = new System.Drawing.Size(58, 17);
            this.chkJasmin.TabIndex = 1;
            this.chkJasmin.Text = "Jasmin";
            this.chkJasmin.UseVisualStyleBackColor = true;
            // 
            // chkLourdes
            // 
            this.chkLourdes.AutoSize = true;
            this.chkLourdes.Location = new System.Drawing.Point(52, 19);
            this.chkLourdes.Name = "chkLourdes";
            this.chkLourdes.Size = new System.Drawing.Size(64, 17);
            this.chkLourdes.TabIndex = 0;
            this.chkLourdes.Text = "Lourdes";
            this.chkLourdes.UseVisualStyleBackColor = true;
            // 
            // cmdEscribir
            // 
            this.cmdEscribir.Location = new System.Drawing.Point(239, 383);
            this.cmdEscribir.Name = "cmdEscribir";
            this.cmdEscribir.Size = new System.Drawing.Size(136, 24);
            this.cmdEscribir.TabIndex = 8;
            this.cmdEscribir.Text = "Escribir";
            this.cmdEscribir.UseVisualStyleBackColor = true;
            this.cmdEscribir.Click += new System.EventHandler(this.cmdEscribir_Click);
            // 
            // frmsecundarioo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdEscribir);
            this.Controls.Add(this.gbOpciones);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.cmdAsignar);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.txtTexto);
            this.Name = "frmsecundarioo";
            this.Text = "secundario";
            this.Load += new System.EventHandler(this.frmSecundarioo_Load);
            this.gbOpciones.ResumeLayout(false);
            this.gbOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.Button cmdAsignar;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.CheckBox chkGarcia;
        private System.Windows.Forms.CheckBox chkJasmin;
        private System.Windows.Forms.CheckBox chkLourdes;
        private System.Windows.Forms.Button cmdEscribir;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}