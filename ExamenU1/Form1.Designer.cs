namespace ExamenU1
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
            txtSueldo = new TextBox();
            label1 = new Label();
            btnCalcular = new Button();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnLimpiar = new Button();
            groupBox2 = new GroupBox();
            lbExecedente = new Label();
            label4 = new Label();
            lbSueldoNet = new Label();
            lbISR = new Label();
            label5 = new Label();
            lbRegistrado = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(82, 94);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(169, 27);
            txtSueldo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Simple Indust Outline", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 178);
            label1.Location = new Point(59, 57);
            label1.Name = "label1";
            label1.Size = new Size(234, 24);
            label1.TabIndex = 1;
            label1.Text = "Sueldo mensual del trabajador:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(24, 156);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 122);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 3;
            label2.Text = "ISR:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 172);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 4;
            label3.Text = "Sueldo Neto:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(txtSueldo);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 233);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(217, 156);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbExecedente);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(lbSueldoNet);
            groupBox2.Controls.Add(lbISR);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(432, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(356, 233);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resultados:";
            // 
            // lbExecedente
            // 
            lbExecedente.AutoSize = true;
            lbExecedente.Location = new Point(172, 67);
            lbExecedente.Name = "lbExecedente";
            lbExecedente.Size = new Size(17, 20);
            lbExecedente.TabIndex = 8;
            lbExecedente.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 68);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 7;
            label4.Text = "Excedente:";
            // 
            // lbSueldoNet
            // 
            lbSueldoNet.AutoSize = true;
            lbSueldoNet.Location = new Point(172, 172);
            lbSueldoNet.Name = "lbSueldoNet";
            lbSueldoNet.Size = new Size(17, 20);
            lbSueldoNet.TabIndex = 6;
            lbSueldoNet.Text = "0";
            // 
            // lbISR
            // 
            lbISR.AutoSize = true;
            lbISR.Location = new Point(172, 122);
            lbISR.Name = "lbISR";
            lbISR.Size = new Size(17, 20);
            lbISR.TabIndex = 5;
            lbISR.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 265);
            label5.Name = "label5";
            label5.Size = new Size(159, 20);
            label5.TabIndex = 7;
            label5.Text = "SUELDO REGISTRADO:";
            // 
            // lbRegistrado
            // 
            lbRegistrado.AutoSize = true;
            lbRegistrado.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbRegistrado.ForeColor = Color.LawnGreen;
            lbRegistrado.Location = new Point(409, 267);
            lbRegistrado.Name = "lbRegistrado";
            lbRegistrado.Size = new Size(28, 21);
            lbRegistrado.TabIndex = 8;
            lbRegistrado.Text = "0$";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 310);
            Controls.Add(lbRegistrado);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSueldo;
        private Label label1;
        private Button btnCalcular;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lbSueldoNet;
        private Label lbISR;
        private Label label4;
        private Label lbExecedente;
        private Button btnLimpiar;
        private Label label5;
        private Label lbRegistrado;
    }
}
