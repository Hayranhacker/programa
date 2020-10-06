namespace prjLanchonete
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPedido = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.Label();
            this.txtLanche = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxPedido = new System.Windows.Forms.TextBox();
            this.boxCliente = new System.Windows.Forms.TextBox();
            this.cboLanche = new System.Windows.Forms.ComboBox();
            this.cboBatata = new System.Windows.Forms.ComboBox();
            this.cboRefrigerante = new System.Windows.Forms.ComboBox();
            this.Limpar = new System.Windows.Forms.Button();
            this.Finalizar = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPedido
            // 
            this.txtPedido.AutoSize = true;
            this.txtPedido.BackColor = System.Drawing.Color.White;
            this.txtPedido.Location = new System.Drawing.Point(255, 54);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(95, 13);
            this.txtPedido.TabIndex = 0;
            this.txtPedido.Text = "Número do Pedido";
            // 
            // txtCliente
            // 
            this.txtCliente.AutoSize = true;
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.Location = new System.Drawing.Point(255, 98);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(85, 13);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.Text = "Nome do Cliente";
            // 
            // txtLanche
            // 
            this.txtLanche.AutoSize = true;
            this.txtLanche.BackColor = System.Drawing.Color.White;
            this.txtLanche.Location = new System.Drawing.Point(255, 154);
            this.txtLanche.Name = "txtLanche";
            this.txtLanche.Size = new System.Drawing.Size(102, 13);
            this.txtLanche.TabIndex = 2;
            this.txtLanche.Text = "Selecione o Lanche";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(255, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Selecione Batata";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(255, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Selecione o Refrigerante";
            // 
            // boxPedido
            // 
            this.boxPedido.Location = new System.Drawing.Point(384, 54);
            this.boxPedido.Name = "boxPedido";
            this.boxPedido.Size = new System.Drawing.Size(100, 20);
            this.boxPedido.TabIndex = 0;
            // 
            // boxCliente
            // 
            this.boxCliente.Location = new System.Drawing.Point(384, 98);
            this.boxCliente.Name = "boxCliente";
            this.boxCliente.Size = new System.Drawing.Size(100, 20);
            this.boxCliente.TabIndex = 6;
            // 
            // cboLanche
            // 
            this.cboLanche.FormattingEnabled = true;
            this.cboLanche.Items.AddRange(new object[] {
            "x-salada",
            "x-tudo",
            "especial da casa"});
            this.cboLanche.Location = new System.Drawing.Point(384, 154);
            this.cboLanche.Name = "cboLanche";
            this.cboLanche.Size = new System.Drawing.Size(121, 21);
            this.cboLanche.TabIndex = 7;
            // 
            // cboBatata
            // 
            this.cboBatata.FormattingEnabled = true;
            this.cboBatata.Items.AddRange(new object[] {
            "batata recheada",
            "batata com frango"});
            this.cboBatata.Location = new System.Drawing.Point(384, 206);
            this.cboBatata.Name = "cboBatata";
            this.cboBatata.Size = new System.Drawing.Size(121, 21);
            this.cboBatata.TabIndex = 8;
            // 
            // cboRefrigerante
            // 
            this.cboRefrigerante.FormattingEnabled = true;
            this.cboRefrigerante.Items.AddRange(new object[] {
            "pepsi 600ML",
            "COCA-COLA 600ML",
            "guarana antardica"});
            this.cboRefrigerante.Location = new System.Drawing.Point(384, 251);
            this.cboRefrigerante.Name = "cboRefrigerante";
            this.cboRefrigerante.Size = new System.Drawing.Size(121, 21);
            this.cboRefrigerante.TabIndex = 9;
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(212, 317);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(75, 23);
            this.Limpar.TabIndex = 10;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Finalizar
            // 
            this.Finalizar.Location = new System.Drawing.Point(335, 317);
            this.Finalizar.Name = "Finalizar";
            this.Finalizar.Size = new System.Drawing.Size(75, 23);
            this.Finalizar.TabIndex = 11;
            this.Finalizar.Text = "Finalizar Pedido";
            this.Finalizar.UseVisualStyleBackColor = true;
            this.Finalizar.Click += new System.EventHandler(this.Finalizar_Click);
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(466, 317);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(75, 23);
            this.Sair.TabIndex = 12;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "LANCHONETE DA ROÇA (VERSÃO ABANDONADA)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prjLanchonete.Properties.Resources._28_IMG_3586;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Finalizar);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.cboRefrigerante);
            this.Controls.Add(this.cboBatata);
            this.Controls.Add(this.cboLanche);
            this.Controls.Add(this.boxCliente);
            this.Controls.Add(this.boxPedido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLanche);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtPedido);
            this.Name = "Form1";
            this.Text = "Lanchonete da roça";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPedido;
        private System.Windows.Forms.Label txtCliente;
        private System.Windows.Forms.Label txtLanche;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxPedido;
        private System.Windows.Forms.TextBox boxCliente;
        private System.Windows.Forms.ComboBox cboLanche;
        private System.Windows.Forms.ComboBox cboBatata;
        private System.Windows.Forms.ComboBox cboRefrigerante;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Finalizar;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Label label1;
    }
}

