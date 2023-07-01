namespace WindowsFormsExemplos.Forms.Pedidos
{
    partial class CadastroPedidoForm
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
            labelCliente = new Label();
            comboBoxClientes = new ComboBox();
            buttonCriarOrcamento = new Button();
            labelCodigo = new Label();
            labelCodigoValor = new Label();
            comboBoxProdutos = new ComboBox();
            labelProduto = new Label();
            numericUpDownQuantidade = new NumericUpDown();
            labelQuantidade = new Label();
            labelPrecoUnitarioValor = new Label();
            labelPrecoUnitario = new Label();
            labelTotalValor = new Label();
            labelTotal = new Label();
            dataGridViewCarrinho = new DataGridView();
            labelCarrinho = new Label();
            buttonAdicionar = new Button();
            labelTotalPedido = new Label();
            labelTotalPedidoValor = new Label();
            buttonFecharPedido = new Button();
            buttonCancelarPedido = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrinho).BeginInit();
            SuspendLayout();
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(12, 36);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(55, 20);
            labelCliente.TabIndex = 0;
            labelCliente.Text = "Cliente";
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.DisplayMember = "Nome";
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(12, 59);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(344, 28);
            comboBoxClientes.TabIndex = 1;
            // 
            // buttonCriarOrcamento
            // 
            buttonCriarOrcamento.Location = new Point(192, 109);
            buttonCriarOrcamento.Name = "buttonCriarOrcamento";
            buttonCriarOrcamento.Size = new Size(164, 29);
            buttonCriarOrcamento.TabIndex = 2;
            buttonCriarOrcamento.Text = "Criar Orçamento";
            buttonCriarOrcamento.UseVisualStyleBackColor = true;
            buttonCriarOrcamento.Click += buttonCriarOrcamento_Click;
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Location = new Point(12, 9);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(58, 20);
            labelCodigo.TabIndex = 3;
            labelCodigo.Text = "Código";
            // 
            // labelCodigoValor
            // 
            labelCodigoValor.AutoSize = true;
            labelCodigoValor.Location = new Point(76, 9);
            labelCodigoValor.Name = "labelCodigoValor";
            labelCodigoValor.Size = new Size(17, 20);
            labelCodigoValor.TabIndex = 4;
            labelCodigoValor.Text = "0";
            // 
            // comboBoxProdutos
            // 
            comboBoxProdutos.DisplayMember = "Nome";
            comboBoxProdutos.FormattingEnabled = true;
            comboBoxProdutos.Location = new Point(484, 59);
            comboBoxProdutos.Name = "comboBoxProdutos";
            comboBoxProdutos.Size = new Size(514, 28);
            comboBoxProdutos.TabIndex = 5;
            // 
            // labelProduto
            // 
            labelProduto.AutoSize = true;
            labelProduto.Location = new Point(484, 36);
            labelProduto.Name = "labelProduto";
            labelProduto.Size = new Size(62, 20);
            labelProduto.TabIndex = 6;
            labelProduto.Text = "Produto";
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Location = new Point(616, 116);
            numericUpDownQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(150, 27);
            numericUpDownQuantidade.TabIndex = 7;
            numericUpDownQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(616, 90);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(87, 20);
            labelQuantidade.TabIndex = 8;
            labelQuantidade.Text = "Quantidade";
            // 
            // labelPrecoUnitarioValor
            // 
            labelPrecoUnitarioValor.AutoSize = true;
            labelPrecoUnitarioValor.Location = new Point(484, 118);
            labelPrecoUnitarioValor.Name = "labelPrecoUnitarioValor";
            labelPrecoUnitarioValor.Size = new Size(17, 20);
            labelPrecoUnitarioValor.TabIndex = 10;
            labelPrecoUnitarioValor.Text = "0";
            // 
            // labelPrecoUnitario
            // 
            labelPrecoUnitario.AutoSize = true;
            labelPrecoUnitario.Location = new Point(484, 90);
            labelPrecoUnitario.Name = "labelPrecoUnitario";
            labelPrecoUnitario.Size = new Size(101, 20);
            labelPrecoUnitario.TabIndex = 9;
            labelPrecoUnitario.Text = "Preço unitário";
            // 
            // labelTotalValor
            // 
            labelTotalValor.AutoSize = true;
            labelTotalValor.Location = new Point(800, 118);
            labelTotalValor.Name = "labelTotalValor";
            labelTotalValor.Size = new Size(17, 20);
            labelTotalValor.TabIndex = 12;
            labelTotalValor.Text = "0";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(800, 90);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(42, 20);
            labelTotal.TabIndex = 11;
            labelTotal.Text = "Total";
            // 
            // dataGridViewCarrinho
            // 
            dataGridViewCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarrinho.Location = new Point(484, 221);
            dataGridViewCarrinho.Name = "dataGridViewCarrinho";
            dataGridViewCarrinho.RowHeadersWidth = 51;
            dataGridViewCarrinho.RowTemplate.Height = 29;
            dataGridViewCarrinho.Size = new Size(686, 439);
            dataGridViewCarrinho.TabIndex = 13;
            // 
            // labelCarrinho
            // 
            labelCarrinho.AutoSize = true;
            labelCarrinho.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCarrinho.Location = new Point(787, 190);
            labelCarrinho.Name = "labelCarrinho";
            labelCarrinho.Size = new Size(93, 28);
            labelCarrinho.TabIndex = 14;
            labelCarrinho.Text = "Carrinho";
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Location = new Point(1004, 36);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(166, 102);
            buttonAdicionar.TabIndex = 15;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            // 
            // labelTotalPedido
            // 
            labelTotalPedido.AutoSize = true;
            labelTotalPedido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalPedido.Location = new Point(906, 680);
            labelTotalPedido.Name = "labelTotalPedido";
            labelTotalPedido.Size = new Size(129, 28);
            labelTotalPedido.TabIndex = 16;
            labelTotalPedido.Text = "Total Pedido";
            // 
            // labelTotalPedidoValor
            // 
            labelTotalPedidoValor.AutoSize = true;
            labelTotalPedidoValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalPedidoValor.Location = new Point(1041, 680);
            labelTotalPedidoValor.Name = "labelTotalPedidoValor";
            labelTotalPedidoValor.Size = new Size(24, 28);
            labelTotalPedidoValor.TabIndex = 17;
            labelTotalPedidoValor.Text = "0";
            // 
            // buttonFecharPedido
            // 
            buttonFecharPedido.Location = new Point(1192, 221);
            buttonFecharPedido.Name = "buttonFecharPedido";
            buttonFecharPedido.Size = new Size(192, 89);
            buttonFecharPedido.TabIndex = 18;
            buttonFecharPedido.Text = "Fechar Pedido";
            buttonFecharPedido.UseVisualStyleBackColor = true;
            // 
            // buttonCancelarPedido
            // 
            buttonCancelarPedido.Location = new Point(1192, 316);
            buttonCancelarPedido.Name = "buttonCancelarPedido";
            buttonCancelarPedido.Size = new Size(192, 89);
            buttonCancelarPedido.TabIndex = 19;
            buttonCancelarPedido.Text = "Cancelar Orçamento";
            buttonCancelarPedido.UseVisualStyleBackColor = true;
            // 
            // CadastroPedidoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 717);
            Controls.Add(buttonCancelarPedido);
            Controls.Add(buttonFecharPedido);
            Controls.Add(labelTotalPedidoValor);
            Controls.Add(labelTotalPedido);
            Controls.Add(buttonAdicionar);
            Controls.Add(labelCarrinho);
            Controls.Add(dataGridViewCarrinho);
            Controls.Add(labelTotalValor);
            Controls.Add(labelTotal);
            Controls.Add(labelPrecoUnitarioValor);
            Controls.Add(labelPrecoUnitario);
            Controls.Add(labelQuantidade);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(labelProduto);
            Controls.Add(comboBoxProdutos);
            Controls.Add(labelCodigoValor);
            Controls.Add(labelCodigo);
            Controls.Add(buttonCriarOrcamento);
            Controls.Add(comboBoxClientes);
            Controls.Add(labelCliente);
            Name = "CadastroPedidoForm";
            Text = "CadastroPedidoForm";
            Load += CadastroPedidoForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrinho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCliente;
        private ComboBox comboBoxClientes;
        private Button buttonCriarOrcamento;
        private Label labelCodigo;
        private Label labelCodigoValor;
        private ComboBox comboBoxProdutos;
        private Label labelProduto;
        private NumericUpDown numericUpDownQuantidade;
        private Label labelQuantidade;
        private Label labelPrecoUnitarioValor;
        private Label labelPrecoUnitario;
        private Label labelTotalValor;
        private Label labelTotal;
        private DataGridView dataGridViewCarrinho;
        private Label labelCarrinho;
        private Button buttonAdicionar;
        private Label labelTotalPedido;
        private Label labelTotalPedidoValor;
        private Button buttonFecharPedido;
        private Button buttonCancelarPedido;
    }
}