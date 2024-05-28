namespace Jogo_Genius_Simon
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
            components = new System.ComponentModel.Container();
            btCiano = new Button();
            btRoxo = new Button();
            btIniciar = new Button();
            lbNivel = new Label();
            label1 = new Label();
            btAzul = new Button();
            btVermelho = new Button();
            btAmarelo = new Button();
            btVerde = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btLaranja = new Button();
            btRosa = new Button();
            SuspendLayout();
            // 
            // btCiano
            // 
            btCiano.FlatStyle = FlatStyle.Flat;
            btCiano.Location = new Point(401, 215);
            btCiano.Name = "btCiano";
            btCiano.Size = new Size(132, 125);
            btCiano.TabIndex = 17;
            btCiano.UseVisualStyleBackColor = true;
            btCiano.Click += bt_Click;
            // 
            // btRoxo
            // 
            btRoxo.BackColor = SystemColors.Control;
            btRoxo.FlatStyle = FlatStyle.Flat;
            btRoxo.Location = new Point(401, 70);
            btRoxo.Name = "btRoxo";
            btRoxo.Size = new Size(132, 127);
            btRoxo.TabIndex = 16;
            btRoxo.UseVisualStyleBackColor = false;
            btRoxo.Click += bt_Click;
            // 
            // btIniciar
            // 
            btIniciar.Font = new Font("Segoe UI", 16F);
            btIniciar.Location = new Point(324, 443);
            btIniciar.Name = "btIniciar";
            btIniciar.Size = new Size(108, 50);
            btIniciar.TabIndex = 15;
            btIniciar.Text = "Iniciar";
            btIniciar.UseVisualStyleBackColor = true;
            btIniciar.Click += btIniciar_Click;
            // 
            // lbNivel
            // 
            lbNivel.AutoSize = true;
            lbNivel.Font = new Font("Segoe UI", 20F);
            lbNivel.Location = new Point(379, 368);
            lbNivel.Name = "lbNivel";
            lbNivel.Size = new Size(0, 37);
            lbNivel.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(243, 368);
            label1.Name = "label1";
            label1.Size = new Size(91, 37);
            label1.TabIndex = 13;
            label1.Text = "Nível :";
            label1.Click += label1_Click;
            // 
            // btAzul
            // 
            btAzul.FlatStyle = FlatStyle.Flat;
            btAzul.Location = new Point(250, 215);
            btAzul.Name = "btAzul";
            btAzul.Size = new Size(132, 125);
            btAzul.TabIndex = 12;
            btAzul.UseVisualStyleBackColor = true;
            btAzul.Click += bt_Click;
            // 
            // btVermelho
            // 
            btVermelho.FlatStyle = FlatStyle.Flat;
            btVermelho.Location = new Point(105, 215);
            btVermelho.Name = "btVermelho";
            btVermelho.Size = new Size(128, 125);
            btVermelho.TabIndex = 11;
            btVermelho.UseVisualStyleBackColor = true;
            btVermelho.Click += bt_Click;
            // 
            // btAmarelo
            // 
            btAmarelo.BackColor = SystemColors.Control;
            btAmarelo.FlatStyle = FlatStyle.Flat;
            btAmarelo.Location = new Point(250, 70);
            btAmarelo.Name = "btAmarelo";
            btAmarelo.Size = new Size(132, 127);
            btAmarelo.TabIndex = 10;
            btAmarelo.UseVisualStyleBackColor = false;
            btAmarelo.Click += bt_Click;
            // 
            // btVerde
            // 
            btVerde.FlatStyle = FlatStyle.Flat;
            btVerde.Location = new Point(105, 70);
            btVerde.Name = "btVerde";
            btVerde.Size = new Size(130, 127);
            btVerde.TabIndex = 9;
            btVerde.UseVisualStyleBackColor = true;
            btVerde.Click += bt_Click;
            // 
            // timer1
            // 
            timer1.Interval = 250;
            timer1.Tick += timer1_Tick;
            // 
            // btLaranja
            // 
            btLaranja.FlatStyle = FlatStyle.Flat;
            btLaranja.Location = new Point(554, 215);
            btLaranja.Name = "btLaranja";
            btLaranja.Size = new Size(132, 125);
            btLaranja.TabIndex = 19;
            btLaranja.UseVisualStyleBackColor = true;
            btLaranja.Click += bt_Click;
            // 
            // btRosa
            // 
            btRosa.BackColor = SystemColors.Control;
            btRosa.FlatStyle = FlatStyle.Flat;
            btRosa.Location = new Point(554, 70);
            btRosa.Name = "btRosa";
            btRosa.Size = new Size(132, 127);
            btRosa.TabIndex = 18;
            btRosa.UseVisualStyleBackColor = false;
            btRosa.Click += bt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 556);
            Controls.Add(btLaranja);
            Controls.Add(btRosa);
            Controls.Add(btCiano);
            Controls.Add(btRoxo);
            Controls.Add(btIniciar);
            Controls.Add(lbNivel);
            Controls.Add(label1);
            Controls.Add(btAzul);
            Controls.Add(btVermelho);
            Controls.Add(btAmarelo);
            Controls.Add(btVerde);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCiano;
        private Button btRoxo;
        private Button btIniciar;
        private Label lbNivel;
        private Label label1;
        private Button btAzul;
        private Button btVermelho;
        private Button btAmarelo;
        private Button btVerde;
        private System.Windows.Forms.Timer timer1;
        private Button btLaranja;
        private Button btRosa;
    }
}
