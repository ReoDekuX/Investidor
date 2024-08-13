namespace Investidor.View
{
    partial class TelaAdicionarTransação
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
            DTP_Data = new DateTimePicker();
            tbx_custos = new TextBox();
            tbx_Preco = new TextBox();
            tbx_qtd = new TextBox();
            cbx_TipoAtivo = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbx_Ativo = new ComboBox();
            btn_Salvar = new Button();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            btn_Calcular = new Button();
            lbl_Total = new TextBox();
            label7 = new Label();
            btn_Cancelar = new Button();
            tabPage4 = new TabPage();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // DTP_Data
            // 
            DTP_Data.Format = DateTimePickerFormat.Short;
            DTP_Data.Location = new Point(32, 195);
            DTP_Data.Name = "DTP_Data";
            DTP_Data.Size = new Size(114, 29);
            DTP_Data.TabIndex = 10;
            // 
            // tbx_custos
            // 
            tbx_custos.Location = new Point(189, 278);
            tbx_custos.Name = "tbx_custos";
            tbx_custos.Size = new Size(100, 29);
            tbx_custos.TabIndex = 9;
            // 
            // tbx_Preco
            // 
            tbx_Preco.Location = new Point(32, 278);
            tbx_Preco.Name = "tbx_Preco";
            tbx_Preco.Size = new Size(100, 29);
            tbx_Preco.TabIndex = 8;
            // 
            // tbx_qtd
            // 
            tbx_qtd.Location = new Point(189, 195);
            tbx_qtd.Name = "tbx_qtd";
            tbx_qtd.Size = new Size(100, 29);
            tbx_qtd.TabIndex = 7;
            // 
            // cbx_TipoAtivo
            // 
            cbx_TipoAtivo.FormattingEnabled = true;
            cbx_TipoAtivo.Items.AddRange(new object[] { "ACÕES", "FUNDOS DE INVESTIMENTOS", "FIIS", "CRIPTOMOEDAS", "STOCK", "REIT", "BDRS", "ETFS", "ETFS INTERNACIONAIS", "TESOURO DIRETO", "RENDA FIXA", "OUTROS" });
            cbx_TipoAtivo.Location = new Point(40, 58);
            cbx_TipoAtivo.Name = "cbx_TipoAtivo";
            cbx_TipoAtivo.Size = new Size(246, 29);
            cbx_TipoAtivo.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(189, 247);
            label6.Name = "label6";
            label6.Size = new Size(109, 21);
            label6.TabIndex = 5;
            label6.Text = "Outros custos:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 247);
            label5.Name = "label5";
            label5.Size = new Size(101, 21);
            label5.TabIndex = 4;
            label5.Text = "Preço em R$:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(195, 171);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 3;
            label4.Text = "Quantidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 171);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 2;
            label3.Text = "Data da compra:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 91);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Ativo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 30);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 0;
            label1.Text = "Tipo de ativo:";
            // 
            // cbx_Ativo
            // 
            cbx_Ativo.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cbx_Ativo.FormattingEnabled = true;
            cbx_Ativo.Location = new Point(40, 119);
            cbx_Ativo.Name = "cbx_Ativo";
            cbx_Ativo.Size = new Size(246, 23);
            cbx_Ativo.TabIndex = 11;
            cbx_Ativo.Text = "CÓDIGO OU NOME DO ATIVO";
            // 
            // btn_Salvar
            // 
            btn_Salvar.Location = new Point(225, 447);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(87, 40);
            btn_Salvar.TabIndex = 12;
            btn_Salvar.Text = "Salvar";
            btn_Salvar.UseVisualStyleBackColor = true;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Location = new Point(74, 50);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(380, 549);
            tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btn_Calcular);
            tabPage3.Controls.Add(lbl_Total);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(btn_Cancelar);
            tabPage3.Controls.Add(btn_Salvar);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(cbx_Ativo);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(DTP_Data);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(tbx_custos);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(tbx_Preco);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(tbx_qtd);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(cbx_TipoAtivo);
            tabPage3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(372, 521);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Comprar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_Calcular
            // 
            btn_Calcular.Location = new Point(204, 324);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(85, 37);
            btn_Calcular.TabIndex = 16;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // lbl_Total
            // 
            lbl_Total.BackColor = SystemColors.Control;
            lbl_Total.Location = new Point(161, 367);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(128, 29);
            lbl_Total.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(32, 367);
            label7.Name = "label7";
            label7.Size = new Size(105, 25);
            label7.TabIndex = 14;
            label7.Text = "Valor Total:";
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(40, 447);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(86, 40);
            btn_Cancelar.TabIndex = 13;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(372, 521);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // TelaAdicionarTransação
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 661);
            Controls.Add(tabControl2);
            Name = "TelaAdicionarTransação";
            Text = "TelaAdicionarTransação";
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbx_TipoAtivo;
        private Label label6;
        private Label label5;
        private TextBox tbx_custos;
        private TextBox tbx_Preco;
        private TextBox tbx_qtd;
        private DateTimePicker DTP_Data;
        private Button btn_Salvar;
        private ComboBox cbx_Ativo;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button btn_Cancelar;
        private Label label7;
        private TextBox lbl_Total;
        private Button btn_Calcular;
    }
}