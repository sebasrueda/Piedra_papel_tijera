namespace Piedra_papel_tijera
{
    partial class Form1
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
            btnPiedra = new Button();
            btnPapel = new Button();
            btnTijeras = new Button();
            btnJugar = new Button();
            pbxTu = new PictureBox();
            label1 = new Label();
            pbxComputador = new PictureBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pbxTu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxComputador).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPiedra
            // 
            btnPiedra.Location = new Point(85, 259);
            btnPiedra.Name = "btnPiedra";
            btnPiedra.Size = new Size(75, 23);
            btnPiedra.TabIndex = 0;
            btnPiedra.Text = "Piedra";
            btnPiedra.UseVisualStyleBackColor = true;
            btnPiedra.Click += btnPiedra_Click;
            // 
            // btnPapel
            // 
            btnPapel.Location = new Point(85, 288);
            btnPapel.Name = "btnPapel";
            btnPapel.Size = new Size(75, 23);
            btnPapel.TabIndex = 1;
            btnPapel.Text = "Papel";
            btnPapel.UseVisualStyleBackColor = true;
            btnPapel.Click += btnPapel_Click;
            // 
            // btnTijeras
            // 
            btnTijeras.Location = new Point(85, 317);
            btnTijeras.Name = "btnTijeras";
            btnTijeras.Size = new Size(75, 23);
            btnTijeras.TabIndex = 2;
            btnTijeras.Text = "Tijeras";
            btnTijeras.UseVisualStyleBackColor = true;
            btnTijeras.Click += btnTijeras_Click;
            // 
            // btnJugar
            // 
            btnJugar.Location = new Point(227, 387);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(75, 23);
            btnJugar.TabIndex = 3;
            btnJugar.Text = "Jugar";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += btnJugar_Click;
            // 
            // pbxTu
            // 
            pbxTu.BackgroundImageLayout = ImageLayout.Stretch;
            pbxTu.BorderStyle = BorderStyle.FixedSingle;
            pbxTu.Location = new Point(24, 37);
            pbxTu.Name = "pbxTu";
            pbxTu.Size = new Size(214, 216);
            pbxTu.TabIndex = 4;
            pbxTu.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 19);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 5;
            label1.Text = "Tú";
            // 
            // pbxComputador
            // 
            pbxComputador.BackgroundImageLayout = ImageLayout.Stretch;
            pbxComputador.BorderStyle = BorderStyle.FixedSingle;
            pbxComputador.Location = new Point(272, 37);
            pbxComputador.Name = "pbxComputador";
            pbxComputador.Size = new Size(213, 216);
            pbxComputador.TabIndex = 6;
            pbxComputador.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 19);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 7;
            label2.Text = "Computador";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnTijeras);
            groupBox1.Controls.Add(pbxComputador);
            groupBox1.Controls.Add(btnPapel);
            groupBox1.Controls.Add(pbxTu);
            groupBox1.Controls.Add(btnPiedra);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 369);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Juego";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 427);
            Controls.Add(groupBox1);
            Controls.Add(btnJugar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pieda, papel o tijera";
            ((System.ComponentModel.ISupportInitialize)pbxTu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxComputador).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPiedra;
        private Button btnPapel;
        private Button btnTijeras;
        private Button btnJugar;
        private PictureBox pbxTu;
        private Label label1;
        private PictureBox pbxComputador;
        private Label label2;
        private GroupBox groupBox1;
    }
}