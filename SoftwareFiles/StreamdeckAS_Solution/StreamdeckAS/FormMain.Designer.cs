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
            this.lblBtnB = new System.Windows.Forms.Label();
            this.lblBtnA = new System.Windows.Forms.Label();
            this.btnCambiaB = new System.Windows.Forms.Button();
            this.btnCambiaA = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCambiaD = new System.Windows.Forms.Button();
            this.btnCambiaC = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBtnC = new System.Windows.Forms.Label();
            this.lblBtnD = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "StreamdeckAS";
            // 
            // btnInizia
            // 
            this.btnInizia.Enabled = false;
            this.btnInizia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInizia.Location = new System.Drawing.Point(4, 16);
            this.btnInizia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInizia.Name = "btnInizia";
            this.btnInizia.Size = new System.Drawing.Size(79, 31);
            this.btnInizia.TabIndex = 1;
            this.btnInizia.Text = "Inizia";
            this.btnInizia.UseVisualStyleBackColor = true;
            this.btnInizia.Click += new System.EventHandler(this.btnInizia_Click);
            // 
            // btnTermina
            // 
            this.btnTermina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTermina.Location = new System.Drawing.Point(86, 16);
            this.btnTermina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTermina.Name = "btnTermina";
            this.btnTermina.Size = new System.Drawing.Size(79, 31);
            this.btnTermina.TabIndex = 2;
            this.btnTermina.Text = "Termina";
            this.btnTermina.UseVisualStyleBackColor = true;
            this.btnTermina.Click += new System.EventHandler(this.btnTermina_Click);
            // 
            // btnProgram
            // 
            this.btnProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgram.Location = new System.Drawing.Point(410, 37);
            this.btnProgram.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProgram.Name = "btnProgram";
            this.btnProgram.Size = new System.Drawing.Size(119, 42);
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
            this.groupBox1.Location = new System.Drawing.Point(192, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(170, 59);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inizia / termina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pulsante A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pulsante B";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBtnD);
            this.groupBox2.Controls.Add(this.lblBtnC);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnCambiaD);
            this.groupBox2.Controls.Add(this.btnCambiaC);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblBtnB);
            this.groupBox2.Controls.Add(this.lblBtnA);
            this.groupBox2.Controls.Add(this.btnCambiaB);
            this.groupBox2.Controls.Add(this.btnCambiaA);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(79, 154);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(393, 103);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lblBtnB
            // 
            this.lblBtnB.AutoSize = true;
            this.lblBtnB.Location = new System.Drawing.Point(112, 37);
            this.lblBtnB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBtnB.Name = "lblBtnB";
            this.lblBtnB.Size = new System.Drawing.Size(0, 13);
            this.lblBtnB.TabIndex = 11;
            // 
            // lblBtnA
            // 
            this.lblBtnA.AutoSize = true;
            this.lblBtnA.Location = new System.Drawing.Point(3, 37);
            this.lblBtnA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBtnA.Name = "lblBtnA";
            this.lblBtnA.Size = new System.Drawing.Size(0, 13);
            this.lblBtnA.TabIndex = 10;
            // 
            // btnCambiaB
            // 
            this.btnCambiaB.Location = new System.Drawing.Point(112, 52);
            this.btnCambiaB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCambiaB.Name = "btnCambiaB";
            this.btnCambiaB.Size = new System.Drawing.Size(58, 29);
            this.btnCambiaB.TabIndex = 9;
            this.btnCambiaB.Text = "Cambia";
            this.btnCambiaB.UseVisualStyleBackColor = true;
            this.btnCambiaB.Click += new System.EventHandler(this.btnCambiaB_Click);
            // 
            // btnCambiaA
            // 
            this.btnCambiaA.Location = new System.Drawing.Point(3, 52);
            this.btnCambiaA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCambiaA.Name = "btnCambiaA";
            this.btnCambiaA.Size = new System.Drawing.Size(58, 29);
            this.btnCambiaA.TabIndex = 8;
            this.btnCambiaA.Text = "Cambia";
            this.btnCambiaA.UseVisualStyleBackColor = true;
            this.btnCambiaA.Click += new System.EventHandler(this.btnCambiaA_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 16;
            // 
            // btnCambiaD
            // 
            this.btnCambiaD.Location = new System.Drawing.Point(321, 52);
            this.btnCambiaD.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiaD.Name = "btnCambiaD";
            this.btnCambiaD.Size = new System.Drawing.Size(58, 29);
            this.btnCambiaD.TabIndex = 15;
            this.btnCambiaD.Text = "Cambia";
            this.btnCambiaD.UseVisualStyleBackColor = true;
            this.btnCambiaD.Click += new System.EventHandler(this.btnCambiaD_Click);
            // 
            // btnCambiaC
            // 
            this.btnCambiaC.Location = new System.Drawing.Point(212, 52);
            this.btnCambiaC.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiaC.Name = "btnCambiaC";
            this.btnCambiaC.Size = new System.Drawing.Size(58, 29);
            this.btnCambiaC.TabIndex = 14;
            this.btnCambiaC.Text = "Cambia";
            this.btnCambiaC.UseVisualStyleBackColor = true;
            this.btnCambiaC.Click += new System.EventHandler(this.btnCambiaC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pulsante C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pulsante D";
            // 
            // lblBtnC
            // 
            this.lblBtnC.AutoSize = true;
            this.lblBtnC.Location = new System.Drawing.Point(212, 37);
            this.lblBtnC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBtnC.Name = "lblBtnC";
            this.lblBtnC.Size = new System.Drawing.Size(0, 13);
            this.lblBtnC.TabIndex = 17;
            // 
            // lblBtnD
            // 
            this.lblBtnD.AutoSize = true;
            this.lblBtnD.Location = new System.Drawing.Point(325, 34);
            this.lblBtnD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBtnD.Name = "lblBtnD";
            this.lblBtnD.Size = new System.Drawing.Size(0, 13);
            this.lblBtnD.TabIndex = 18;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 307);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnProgram);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCambiaD;
        private System.Windows.Forms.Button btnCambiaC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBtnD;
        private System.Windows.Forms.Label lblBtnC;
    }
}

