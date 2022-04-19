namespace CarrosGetSet
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtVelocidade = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxListaCarros = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numVelocidade = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblVelocidadeMedia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numVelocidade)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(74, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 39);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(206, 239);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 39);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtVelocidade
            // 
            this.txtVelocidade.Location = new System.Drawing.Point(155, 132);
            this.txtVelocidade.Name = "txtVelocidade";
            this.txtVelocidade.PlaceholderText = "Velocidade";
            this.txtVelocidade.Size = new System.Drawing.Size(165, 23);
            this.txtVelocidade.TabIndex = 2;
            this.txtVelocidade.TextChanged += new System.EventHandler(this.txtVelocidade_TextChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.AcceptsReturn = true;
            this.txtMarca.Location = new System.Drawing.Point(155, 67);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PlaceholderText = "Marca";
            this.txtMarca.Size = new System.Drawing.Size(165, 23);
            this.txtMarca.TabIndex = 3;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marca do Carro: ";
            // 
            // lbxListaCarros
            // 
            this.lbxListaCarros.FormattingEnabled = true;
            this.lbxListaCarros.ItemHeight = 15;
            this.lbxListaCarros.Location = new System.Drawing.Point(27, 34);
            this.lbxListaCarros.Name = "lbxListaCarros";
            this.lbxListaCarros.Size = new System.Drawing.Size(207, 244);
            this.lbxListaCarros.TabIndex = 5;
            this.lbxListaCarros.SelectedIndexChanged += new System.EventHandler(this.lbxListaCarros_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Velocidade do Carro: ";
            // 
            // numVelocidade
            // 
            this.numVelocidade.Location = new System.Drawing.Point(319, 415);
            this.numVelocidade.Name = "numVelocidade";
            this.numVelocidade.Size = new System.Drawing.Size(120, 23);
            this.numVelocidade.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtVelocidade);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 310);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbxListaCarros);
            this.groupBox2.Location = new System.Drawing.Point(471, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 310);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lblVelocidadeMedia
            // 
            this.lblVelocidadeMedia.AutoSize = true;
            this.lblVelocidadeMedia.Location = new System.Drawing.Point(471, 376);
            this.lblVelocidadeMedia.Name = "lblVelocidadeMedia";
            this.lblVelocidadeMedia.Size = new System.Drawing.Size(106, 15);
            this.lblVelocidadeMedia.TabIndex = 7;
            this.lblVelocidadeMedia.Text = "Velocidade Média: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVelocidadeMedia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numVelocidade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numVelocidade)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdd;
        private Button btnUpdate;
        private TextBox txtVelocidade;
        private TextBox txtMarca;
        private Label label1;
        private ListBox lbxListaCarros;
        private Label label2;
        private NumericUpDown numVelocidade;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblVelocidadeMedia;
    }
}