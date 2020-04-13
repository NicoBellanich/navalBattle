namespace TP4
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Generar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDisparo1 = new System.Windows.Forms.Button();
            this.btnDisparo2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAgua2 = new System.Windows.Forms.Label();
            this.lblAgua1 = new System.Windows.Forms.Label();
            this.lblAciertos2 = new System.Windows.Forms.Label();
            this.lblTiro2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAciertos1 = new System.Windows.Forms.Label();
            this.lblTiro1 = new System.Windows.Forms.Label();
            this.comboJugador1 = new System.Windows.Forms.ComboBox();
            this.comboJugador2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 800);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Generar
            // 
            this.Btn_Generar.Location = new System.Drawing.Point(495, 21);
            this.Btn_Generar.Name = "Btn_Generar";
            this.Btn_Generar.Size = new System.Drawing.Size(135, 23);
            this.Btn_Generar.TabIndex = 1;
            this.Btn_Generar.Text = "Generar ";
            this.Btn_Generar.UseVisualStyleBackColor = true;
            this.Btn_Generar.Click += new System.EventHandler(this.Btn_Generar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(701, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 800);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnDisparo1
            // 
            this.btnDisparo1.Enabled = false;
            this.btnDisparo1.Location = new System.Drawing.Point(495, 61);
            this.btnDisparo1.Name = "btnDisparo1";
            this.btnDisparo1.Size = new System.Drawing.Size(135, 23);
            this.btnDisparo1.TabIndex = 3;
            this.btnDisparo1.Text = "Disparo Jugador 1";
            this.btnDisparo1.UseVisualStyleBackColor = true;
            this.btnDisparo1.Click += new System.EventHandler(this.btnDisparo1_Click);
            // 
            // btnDisparo2
            // 
            this.btnDisparo2.Enabled = false;
            this.btnDisparo2.Location = new System.Drawing.Point(495, 104);
            this.btnDisparo2.Name = "btnDisparo2";
            this.btnDisparo2.Size = new System.Drawing.Size(135, 23);
            this.btnDisparo2.TabIndex = 4;
            this.btnDisparo2.Text = "Disparo Jugador 2";
            this.btnDisparo2.UseVisualStyleBackColor = true;
            this.btnDisparo2.Click += new System.EventHandler(this.btnDisparo2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jugador 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Jugador 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(585, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Agua";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(439, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Agua";
            // 
            // lblAgua2
            // 
            this.lblAgua2.AutoSize = true;
            this.lblAgua2.Location = new System.Drawing.Point(651, 207);
            this.lblAgua2.Name = "lblAgua2";
            this.lblAgua2.Size = new System.Drawing.Size(29, 13);
            this.lblAgua2.TabIndex = 32;
            this.lblAgua2.Text = "label";
            this.lblAgua2.Visible = false;
            // 
            // lblAgua1
            // 
            this.lblAgua1.AutoSize = true;
            this.lblAgua1.Location = new System.Drawing.Point(496, 207);
            this.lblAgua1.Name = "lblAgua1";
            this.lblAgua1.Size = new System.Drawing.Size(29, 13);
            this.lblAgua1.TabIndex = 31;
            this.lblAgua1.Text = "label";
            this.lblAgua1.Visible = false;
            // 
            // lblAciertos2
            // 
            this.lblAciertos2.AutoSize = true;
            this.lblAciertos2.Location = new System.Drawing.Point(651, 185);
            this.lblAciertos2.Name = "lblAciertos2";
            this.lblAciertos2.Size = new System.Drawing.Size(29, 13);
            this.lblAciertos2.TabIndex = 30;
            this.lblAciertos2.Text = "label";
            this.lblAciertos2.Visible = false;
            // 
            // lblTiro2
            // 
            this.lblTiro2.AutoSize = true;
            this.lblTiro2.Location = new System.Drawing.Point(651, 162);
            this.lblTiro2.Name = "lblTiro2";
            this.lblTiro2.Size = new System.Drawing.Size(29, 13);
            this.lblTiro2.TabIndex = 29;
            this.lblTiro2.Text = "label";
            this.lblTiro2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(585, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Aciertos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(585, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tiros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tiros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Aciertos";
            // 
            // lblAciertos1
            // 
            this.lblAciertos1.AutoSize = true;
            this.lblAciertos1.Location = new System.Drawing.Point(496, 185);
            this.lblAciertos1.Name = "lblAciertos1";
            this.lblAciertos1.Size = new System.Drawing.Size(29, 13);
            this.lblAciertos1.TabIndex = 24;
            this.lblAciertos1.Text = "label";
            this.lblAciertos1.Visible = false;
            // 
            // lblTiro1
            // 
            this.lblTiro1.AutoSize = true;
            this.lblTiro1.Location = new System.Drawing.Point(496, 162);
            this.lblTiro1.Name = "lblTiro1";
            this.lblTiro1.Size = new System.Drawing.Size(29, 13);
            this.lblTiro1.TabIndex = 23;
            this.lblTiro1.Text = "label";
            this.lblTiro1.Visible = false;
            // 
            // comboJugador1
            // 
            this.comboJugador1.FormattingEnabled = true;
            this.comboJugador1.Location = new System.Drawing.Point(428, 133);
            this.comboJugador1.Name = "comboJugador1";
            this.comboJugador1.Size = new System.Drawing.Size(121, 21);
            this.comboJugador1.TabIndex = 35;
            this.comboJugador1.SelectedIndexChanged += new System.EventHandler(this.comboJugador1_SelectedIndexChanged);
            // 
            // comboJugador2
            // 
            this.comboJugador2.FormattingEnabled = true;
            this.comboJugador2.Location = new System.Drawing.Point(574, 133);
            this.comboJugador2.Name = "comboJugador2";
            this.comboJugador2.Size = new System.Drawing.Size(121, 21);
            this.comboJugador2.TabIndex = 36;
            this.comboJugador2.SelectedIndexChanged += new System.EventHandler(this.comboJugador2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 749);
            this.Controls.Add(this.comboJugador2);
            this.Controls.Add(this.comboJugador1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblAgua2);
            this.Controls.Add(this.lblAgua1);
            this.Controls.Add(this.lblAciertos2);
            this.Controls.Add(this.lblTiro2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAciertos1);
            this.Controls.Add(this.lblTiro1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisparo2);
            this.Controls.Add(this.btnDisparo1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Btn_Generar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Generar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDisparo1;
        private System.Windows.Forms.Button btnDisparo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAgua2;
        private System.Windows.Forms.Label lblAgua1;
        private System.Windows.Forms.Label lblAciertos2;
        private System.Windows.Forms.Label lblTiro2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAciertos1;
        private System.Windows.Forms.Label lblTiro1;
        private System.Windows.Forms.ComboBox comboJugador1;
        private System.Windows.Forms.ComboBox comboJugador2;
    }
}

