namespace Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResultado2 = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValor1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblValor1.Location = new System.Drawing.Point(53, 64);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(118, 35);
            this.lblValor1.TabIndex = 0;
            this.lblValor1.Text = "Valor 1: ";
            this.lblValor1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Font = new System.Drawing.Font("Microsoft YaHei UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValor2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblValor2.Location = new System.Drawing.Point(53, 159);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(118, 35);
            this.lblValor2.TabIndex = 1;
            this.lblValor2.Text = "Valor 2: ";
            this.lblValor2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtValor1
            // 
            this.txtValor1.BackColor = System.Drawing.SystemColors.Window;
            this.txtValor1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtValor1.Location = new System.Drawing.Point(169, 75);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.PlaceholderText = "Digite o valor 1";
            this.txtValor1.Size = new System.Drawing.Size(334, 23);
            this.txtValor1.TabIndex = 2;
            this.txtValor1.TextChanged += new System.EventHandler(this.txtValor1_TextChanged);
            // 
            // txtValor2
            // 
            this.txtValor2.BackColor = System.Drawing.SystemColors.Window;
            this.txtValor2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtValor2.Location = new System.Drawing.Point(169, 170);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.PlaceholderText = "Digite o valor 2";
            this.txtValor2.Size = new System.Drawing.Size(334, 23);
            this.txtValor2.TabIndex = 3;
            this.txtValor2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft YaHei UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblResultado.Location = new System.Drawing.Point(53, 369);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(162, 35);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado:  ";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // lblResultado2
            // 
            this.lblResultado2.AutoSize = true;
            this.lblResultado2.Font = new System.Drawing.Font("SERomand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblResultado2.Location = new System.Drawing.Point(251, 376);
            this.lblResultado2.Name = "lblResultado2";
            this.lblResultado2.Size = new System.Drawing.Size(0, 24);
            this.lblResultado2.TabIndex = 5;
            // 
            // btnSomar
            // 
            this.btnSomar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSomar.Location = new System.Drawing.Point(547, 64);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(97, 58);
            this.btnSomar.TabIndex = 6;
            this.btnSomar.Text = "SOMAR";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubtrair.Location = new System.Drawing.Point(665, 64);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(97, 58);
            this.btnSubtrair.TabIndex = 7;
            this.btnSubtrair.Text = "SUBTRAIR";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDividir.Location = new System.Drawing.Point(665, 136);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(97, 58);
            this.btnDividir.TabIndex = 9;
            this.btnDividir.Text = "DIVIDIR";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiplicar.Location = new System.Drawing.Point(547, 136);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(97, 58);
            this.btnMultiplicar.TabIndex = 8;
            this.btnMultiplicar.Text = "MULTIPLICAR";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.lblResultado2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblValor1;
        private Label lblValor2;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private Label lblResultado;
        private Label lblResultado2;
        private Button btnSomar;
        private Button btnSubtrair;
        private Button btnDividir;
        private Button btnMultiplicar;
    }
}