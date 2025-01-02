namespace StreamdeckAS
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnInizia = new System.Windows.Forms.Button();
            this.btnTermina = new System.Windows.Forms.Button();
            this.btnProgram = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCambiaA = new System.Windows.Forms.Button();
            this.btnCambiaB = new System.Windows.Forms.Button();
            this.lblBtnA = new System.Windows.Forms.Label();
            this.lblBtnB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "StreamdeckAS";
            // 
            // btnInizia
            // 
            this.btnInizia.Enabled = false;
            this.btnInizia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInizia.Location = new System.Drawing.Point(7, 31);
            this.btnInizia.Margin = new System.Windows.Forms.Padding(4);
            this.btnInizia.Name = "btnInizia";
            this.btnInizia.Size = new System.Drawing.Size(158, 59);
            this.btnInizia.TabIndex = 1;
            this.btnInizia.Text = "Inizia";
            this.btnInizia.UseVisualStyleBackColor = true;
            this.btnInizia.Click += new System.EventHandler(this.btnInizia_Click);
            // 
            // btnTermina
            // 
            this.btnTermina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTermina.Location = new System.Drawing.Point(173, 31);
            this.btnTermina.Margin = new System.Windows.Forms.Padding(4);
            this.btnTermina.Name = "btnTermina";
            this.btnTermina.Size = new System.Drawing.Size(158, 59);
            this.btnTermina.TabIndex = 2;
            this.btnTermina.Text = "Termina";
            this.btnTermina.UseVisualStyleBackColor = true;
            this.btnTermina.Click += new System.EventHandler(this.btnTermina_Click);
            // 
            // btnProgram
            // 
            this.btnProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgram.Location = new System.Drawing.Point(677, 362);
            this.btnProgram.Name = "btnProgram";
            this.btnProgram.Size = new System.Drawing.Size(238, 81);
            this.btnProgram.TabIndex = 3;
            this.btnProgram.Text = "Scegli programma\r\n";
            this.btnProgram.UseVisualStyleBackColor = true;
            this.btnProgram.Click += new System.EventHandler(this.btnProgram_Click);
            // 
            // openFileDialogMain
            // 
            this.openFileDialogMain.Filter = "(*.exe)|*.exe|Tutti i file (*.*)|*.*";
            this.openFileDialogMain.InitialDirectory = "C:\\\\";
            this.openFileDialogMain.RestoreDirectory = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInizia);
            this.groupBox1.Controls.Add(this.btnTermina);
            this.groupBox1.Location = new System.Drawing.Point(383, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 114);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inizia / termina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pulsante A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pulsante B";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBtnB);
            this.groupBox2.Controls.Add(this.lblBtnA);
            this.groupBox2.Controls.Add(this.btnCambiaB);
            this.groupBox2.Controls.Add(this.btnCambiaA);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(273, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 198);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnCambiaA
            // 
            this.btnCambiaA.Location = new System.Drawing.Point(6, 100);
            this.btnCambiaA.Name = "btnCambiaA";
            this.btnCambiaA.Size = new System.Drawing.Size(116, 56);
            this.btnCambiaA.TabIndex = 8;
            this.btnCambiaA.Text = "Cambia";
            this.btnCambiaA.UseVisualStyleBackColor = true;
            this.btnCambiaA.Click += new System.EventHandler(this.btnCambiaA_Click);
            // 
            // btnCambiaB
            // 
            this.btnCambiaB.Location = new System.Drawing.Point(225, 100);
            this.btnCambiaB.Name = "btnCambiaB";
            this.btnCambiaB.Size = new System.Drawing.Size(116, 56);
            this.btnCambiaB.TabIndex = 9;
            this.btnCambiaB.Text = "Cambia";
            this.btnCambiaB.UseVisualStyleBackColor = true;
            this.btnCambiaB.Click += new System.EventHandler(this.btnCambiaB_Click);
            // 
            // lblBtnA
            // 
            this.lblBtnA.AutoSize = true;
            this.lblBtnA.Location = new System.Drawing.Point(6, 72);
            this.lblBtnA.Name = "lblBtnA";
            this.lblBtnA.Size = new System.Drawing.Size(0, 25);
            this.lblBtnA.TabIndex = 10;
            // 
            // lblBtnB
            // 
            this.lblBtnB.AutoSize = true;
            this.lblBtnB.Location = new System.Drawing.Point(225, 72);
            this.lblBtnB.Name = "lblBtnB";
            this.lblBtnB.Size = new System.Drawing.Size(0, 25);
            this.lblBtnB.TabIndex = 11;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 590);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnProgram);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "StreamdeckAS";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInizia;
        private System.Windows.Forms.Button btnTermina;
        private System.Windows.Forms.Button btnProgram;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBtnB;
        private System.Windows.Forms.Label lblBtnA;
        private System.Windows.Forms.Button btnCambiaB;
        private System.Windows.Forms.Button btnCambiaA;
    }
}

