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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblBtnE = new System.Windows.Forms.Label();
            this.lblBtnG = new System.Windows.Forms.Label();
            this.lblBtnH = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblBtnF = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblBtnD = new System.Windows.Forms.Label();
            this.lblBtnC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCambiaD = new System.Windows.Forms.Button();
            this.btnCambiaC = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBtnB = new System.Windows.Forms.Label();
            this.lblBtnA = new System.Windows.Forms.Label();
            this.btnCambiaB = new System.Windows.Forms.Button();
            this.btnCambiaA = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 27);
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
            this.btnInizia.Location = new System.Drawing.Point(8, 31);
            this.btnInizia.Margin = new System.Windows.Forms.Padding(4);
            this.btnInizia.Name = "btnInizia";
            this.btnInizia.Size = new System.Drawing.Size(158, 60);
            this.btnInizia.TabIndex = 1;
            this.btnInizia.Text = "Inizia";
            this.btnInizia.UseVisualStyleBackColor = true;
            this.btnInizia.Click += new System.EventHandler(this.btnInizia_Click);
            // 
            // btnTermina
            // 
            this.btnTermina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTermina.Location = new System.Drawing.Point(172, 31);
            this.btnTermina.Margin = new System.Windows.Forms.Padding(4);
            this.btnTermina.Name = "btnTermina";
            this.btnTermina.Size = new System.Drawing.Size(158, 60);
            this.btnTermina.TabIndex = 2;
            this.btnTermina.Text = "Termina";
            this.btnTermina.UseVisualStyleBackColor = true;
            this.btnTermina.Click += new System.EventHandler(this.btnTermina_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(384, 112);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(340, 113);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inizia / termina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pulsante A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pulsante B";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBtnE);
            this.groupBox2.Controls.Add(this.lblBtnG);
            this.groupBox2.Controls.Add(this.lblBtnH);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblBtnF);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
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
            this.groupBox2.Location = new System.Drawing.Point(156, 233);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(786, 329);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lblBtnE
            // 
            this.lblBtnE.AutoSize = true;
            this.lblBtnE.Location = new System.Drawing.Point(10, 206);
            this.lblBtnE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBtnE.Name = "lblBtnE";
            this.lblBtnE.Size = new System.Drawing.Size(0, 25);
            this.lblBtnE.TabIndex = 30;
            // 
            // lblBtnG
            // 
            this.lblBtnG.AutoSize = true;
            this.lblBtnG.Location = new System.Drawing.Point(428, 212);
            this.lblBtnG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBtnG.Name = "lblBtnG";
            this.lblBtnG.Size = new System.Drawing.Size(0, 25);
            this.lblBtnG.TabIndex = 29;
            // 
            // lblBtnH
            // 
            this.lblBtnH.AutoSize = true;
            this.lblBtnH.Location = new System.Drawing.Point(646, 212);
            this.lblBtnH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBtnH.Name = "lblBtnH";
            this.lblBtnH.Size = new System.Drawing.Size(0, 25);
            this.lblBtnH.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 241);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 56);
            this.button1.TabIndex = 27;
            this.button1.Tag = "7";
            this.button1.Text = "Cambia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCambia_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(428, 241);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 56);
            this.button2.TabIndex = 26;
            this.button2.Tag = "6";
            this.button2.Text = "Cambia";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCambia_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(428, 181);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Pulsante G";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(646, 181);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Pulsante H";
            // 
            // lblBtnF
            // 
            this.lblBtnF.AutoSize = true;
            this.lblBtnF.Location = new System.Drawing.Point(228, 212);
            this.lblBtnF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBtnF.Name = "lblBtnF";
            this.lblBtnF.Size = new System.Drawing.Size(0, 25);
            this.lblBtnF.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(228, 241);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 56);
            this.button3.TabIndex = 22;
            this.button3.Tag = "5";
            this.button3.Text = "Cambia";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnCambia_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 241);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 56);
            this.button4.TabIndex = 21;
            this.button4.Tag = "4";
            this.button4.Text = "Cambia";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnCambia_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 181);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 25);
            this.label13.TabIndex = 19;
            this.label13.Text = "Pulsante E";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(228, 181);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 25);
            this.label14.TabIndex = 20;
            this.label14.Text = "Pulsante F";
            // 
            // lblBtnD
            // 
            this.lblBtnD.AutoSize = true;
            this.lblBtnD.Location = new System.Drawing.Point(650, 65);
            this.lblBtnD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBtnD.Name = "lblBtnD";
            this.lblBtnD.Size = new System.Drawing.Size(0, 25);
            this.lblBtnD.TabIndex = 18;
            // 
            // lblBtnC
            // 
            this.lblBtnC.AutoSize = true;
            this.lblBtnC.Location = new System.Drawing.Point(424, 71);
            this.lblBtnC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBtnC.Name = "lblBtnC";
            this.lblBtnC.Size = new System.Drawing.Size(0, 25);
            this.lblBtnC.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(642, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 16;
            // 
            // btnCambiaD
            // 
            this.btnCambiaD.Location = new System.Drawing.Point(642, 100);
            this.btnCambiaD.Margin = new System.Windows.Forms.Padding(4);
            this.btnCambiaD.Name = "btnCambiaD";
            this.btnCambiaD.Size = new System.Drawing.Size(116, 56);
            this.btnCambiaD.TabIndex = 15;
            this.btnCambiaD.Tag = "3";
            this.btnCambiaD.Text = "Cambia";
            this.btnCambiaD.UseVisualStyleBackColor = true;
            this.btnCambiaD.Click += new System.EventHandler(this.btnCambia_Click);
            // 
            // btnCambiaC
            // 
            this.btnCambiaC.Location = new System.Drawing.Point(424, 100);
            this.btnCambiaC.Margin = new System.Windows.Forms.Padding(4);
            this.btnCambiaC.Name = "btnCambiaC";
            this.btnCambiaC.Size = new System.Drawing.Size(116, 56);
            this.btnCambiaC.TabIndex = 14;
            this.btnCambiaC.Tag = "2";
            this.btnCambiaC.Text = "Cambia";
            this.btnCambiaC.UseVisualStyleBackColor = true;
            this.btnCambiaC.Click += new System.EventHandler(this.btnCambia_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pulsante C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(642, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pulsante D";
            // 
            // lblBtnB
            // 
            this.lblBtnB.AutoSize = true;
            this.lblBtnB.Location = new System.Drawing.Point(224, 71);
            this.lblBtnB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBtnB.Name = "lblBtnB";
            this.lblBtnB.Size = new System.Drawing.Size(0, 25);
            this.lblBtnB.TabIndex = 11;
            // 
            // lblBtnA
            // 
            this.lblBtnA.AutoSize = true;
            this.lblBtnA.Location = new System.Drawing.Point(6, 71);
            this.lblBtnA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBtnA.Name = "lblBtnA";
            this.lblBtnA.Size = new System.Drawing.Size(0, 25);
            this.lblBtnA.TabIndex = 10;
            // 
            // btnCambiaB
            // 
            this.btnCambiaB.Location = new System.Drawing.Point(224, 100);
            this.btnCambiaB.Margin = new System.Windows.Forms.Padding(4);
            this.btnCambiaB.Name = "btnCambiaB";
            this.btnCambiaB.Size = new System.Drawing.Size(116, 56);
            this.btnCambiaB.TabIndex = 9;
            this.btnCambiaB.Tag = "1";
            this.btnCambiaB.Text = "Cambia";
            this.btnCambiaB.UseVisualStyleBackColor = true;
            this.btnCambiaB.Click += new System.EventHandler(this.btnCambia_Click);
            // 
            // btnCambiaA
            // 
            this.btnCambiaA.Location = new System.Drawing.Point(6, 100);
            this.btnCambiaA.Margin = new System.Windows.Forms.Padding(4);
            this.btnCambiaA.Name = "btnCambiaA";
            this.btnCambiaA.Size = new System.Drawing.Size(116, 56);
            this.btnCambiaA.TabIndex = 8;
            this.btnCambiaA.Tag = "0";
            this.btnCambiaA.Text = "Cambia";
            this.btnCambiaA.UseVisualStyleBackColor = true;
            this.btnCambiaA.Click += new System.EventHandler(this.btnCambia_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 590);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "StreamdeckAS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
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
        private System.Windows.Forms.Label lblBtnE;
        private System.Windows.Forms.Label lblBtnG;
        private System.Windows.Forms.Label lblBtnH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBtnF;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

