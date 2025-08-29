namespace Ejercicio1
{
    partial class FormPrincipal
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
            lbxListaFiguras = new ListBox();
            btnCrearFigura = new Button();
            rbEsTipoCuadrado = new RadioButton();
            rbEsTipoCilindro = new RadioButton();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            tbAltoCilindro = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbRadio = new TextBox();
            tbLargo = new TextBox();
            tbAlto = new TextBox();
            tbAncho = new TextBox();
            btnMostrarFiguras = new Button();
            btnMostrarMas = new Button();
            label1 = new Label();
            btnOrdenarFiguras = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbxListaFiguras
            // 
            lbxListaFiguras.FormattingEnabled = true;
            lbxListaFiguras.ItemHeight = 17;
            lbxListaFiguras.Location = new Point(12, 153);
            lbxListaFiguras.Name = "lbxListaFiguras";
            lbxListaFiguras.Size = new Size(336, 208);
            lbxListaFiguras.TabIndex = 0;
            // 
            // btnCrearFigura
            // 
            btnCrearFigura.Location = new Point(483, 56);
            btnCrearFigura.Name = "btnCrearFigura";
            btnCrearFigura.Size = new Size(79, 60);
            btnCrearFigura.TabIndex = 1;
            btnCrearFigura.Text = "Crear Figura";
            btnCrearFigura.UseVisualStyleBackColor = true;
            btnCrearFigura.Click += btnCrearFigura_Click;
            // 
            // rbEsTipoCuadrado
            // 
            rbEsTipoCuadrado.AutoSize = true;
            rbEsTipoCuadrado.Location = new Point(22, 36);
            rbEsTipoCuadrado.Name = "rbEsTipoCuadrado";
            rbEsTipoCuadrado.Size = new Size(81, 21);
            rbEsTipoCuadrado.TabIndex = 2;
            rbEsTipoCuadrado.TabStop = true;
            rbEsTipoCuadrado.Text = "Ortoedro";
            rbEsTipoCuadrado.UseVisualStyleBackColor = true;
            // 
            // rbEsTipoCilindro
            // 
            rbEsTipoCilindro.AutoSize = true;
            rbEsTipoCilindro.Location = new Point(22, 91);
            rbEsTipoCilindro.Name = "rbEsTipoCilindro";
            rbEsTipoCilindro.Size = new Size(71, 21);
            rbEsTipoCilindro.TabIndex = 3;
            rbEsTipoCilindro.TabStop = true;
            rbEsTipoCilindro.Text = "Cilindro";
            rbEsTipoCilindro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbAltoCilindro);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbRadio);
            groupBox1.Controls.Add(tbLargo);
            groupBox1.Controls.Add(tbAlto);
            groupBox1.Controls.Add(tbAncho);
            groupBox1.Controls.Add(rbEsTipoCuadrado);
            groupBox1.Controls.Add(btnCrearFigura);
            groupBox1.Controls.Add(rbEsTipoCilindro);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(568, 135);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Creando una figura";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(245, 93);
            label6.Name = "label6";
            label6.Size = new Size(31, 17);
            label6.TabIndex = 13;
            label6.Text = "Alto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(124, 95);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 12;
            label5.Text = "Radio";
            // 
            // tbAltoCilindro
            // 
            tbAltoCilindro.Location = new Point(294, 90);
            tbAltoCilindro.Name = "tbAltoCilindro";
            tbAltoCilindro.Size = new Size(55, 25);
            tbAltoCilindro.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(359, 38);
            label4.Name = "label4";
            label4.Size = new Size(42, 17);
            label4.TabIndex = 10;
            label4.Text = "Largo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 42);
            label3.Name = "label3";
            label3.Size = new Size(31, 17);
            label3.TabIndex = 9;
            label3.Text = "Alto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 37);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 8;
            label2.Text = "Ancho";
            // 
            // tbRadio
            // 
            tbRadio.Location = new Point(173, 91);
            tbRadio.Name = "tbRadio";
            tbRadio.Size = new Size(55, 25);
            tbRadio.TabIndex = 7;
            // 
            // tbLargo
            // 
            tbLargo.Location = new Point(407, 35);
            tbLargo.Name = "tbLargo";
            tbLargo.Size = new Size(55, 25);
            tbLargo.TabIndex = 6;
            // 
            // tbAlto
            // 
            tbAlto.Location = new Point(281, 34);
            tbAlto.Name = "tbAlto";
            tbAlto.Size = new Size(55, 25);
            tbAlto.TabIndex = 5;
            // 
            // tbAncho
            // 
            tbAncho.Location = new Point(173, 34);
            tbAncho.Name = "tbAncho";
            tbAncho.Size = new Size(55, 25);
            tbAncho.TabIndex = 4;
            // 
            // btnMostrarFiguras
            // 
            btnMostrarFiguras.Location = new Point(356, 152);
            btnMostrarFiguras.Name = "btnMostrarFiguras";
            btnMostrarFiguras.Size = new Size(75, 60);
            btnMostrarFiguras.TabIndex = 4;
            btnMostrarFiguras.Text = "Actualizar Listado";
            btnMostrarFiguras.UseVisualStyleBackColor = true;
            btnMostrarFiguras.Click += btnMostrarFiguras_Click;
            // 
            // btnMostrarMas
            // 
            btnMostrarMas.Location = new Point(356, 232);
            btnMostrarMas.Name = "btnMostrarMas";
            btnMostrarMas.Size = new Size(75, 60);
            btnMostrarMas.TabIndex = 5;
            btnMostrarMas.Text = "Mostrar mas datos";
            btnMostrarMas.UseVisualStyleBackColor = true;
            btnMostrarMas.Click += btnMostrarMas_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(356, 295);
            label1.Name = "label1";
            label1.Size = new Size(218, 65);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // btnOrdenarFiguras
            // 
            btnOrdenarFiguras.Location = new Point(437, 152);
            btnOrdenarFiguras.Name = "btnOrdenarFiguras";
            btnOrdenarFiguras.Size = new Size(79, 60);
            btnOrdenarFiguras.TabIndex = 7;
            btnOrdenarFiguras.Text = "Ordenar por area";
            btnOrdenarFiguras.UseVisualStyleBackColor = true;
            btnOrdenarFiguras.Click += btnOrdenarFiguras_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 367);
            Controls.Add(btnOrdenarFiguras);
            Controls.Add(label1);
            Controls.Add(btnMostrarMas);
            Controls.Add(btnMostrarFiguras);
            Controls.Add(groupBox1);
            Controls.Add(lbxListaFiguras);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbxListaFiguras;
        private Button btnCrearFigura;
        private RadioButton rbEsTipoCuadrado;
        private RadioButton rbEsTipoCilindro;
        private GroupBox groupBox1;
        private Button btnMostrarFiguras;
        private Button btnMostrarMas;
        private Label label1;
        private Button btnOrdenarFiguras;
        private Label label6;
        private Label label5;
        private TextBox tbAltoCilindro;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tbRadio;
        private TextBox tbLargo;
        private TextBox tbAlto;
        private TextBox tbAncho;
    }
}
