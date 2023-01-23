namespace Back.OrderController
{
    partial class OrderForm
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
            this.textBoxOrderName = new System.Windows.Forms.TextBox();
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.buttonAttente = new System.Windows.Forms.Button();
            this.buttonPayer = new System.Windows.Forms.Button();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.listBoxProduitMenu = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxOrderName
            // 
            this.textBoxOrderName.Location = new System.Drawing.Point(412, 52);
            this.textBoxOrderName.Name = "textBoxOrderName";
            this.textBoxOrderName.Size = new System.Drawing.Size(354, 23);
            this.textBoxOrderName.TabIndex = 2;
            // 
            // dataGridOrder
            // 
            this.dataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrder.Location = new System.Drawing.Point(412, 73);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.RowTemplate.Height = 25;
            this.dataGridOrder.Size = new System.Drawing.Size(354, 286);
            this.dataGridOrder.TabIndex = 3;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(412, 356);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(354, 23);
            this.textBoxTotal.TabIndex = 4;
            // 
            // buttonAttente
            // 
            this.buttonAttente.Location = new System.Drawing.Point(412, 394);
            this.buttonAttente.Name = "buttonAttente";
            this.buttonAttente.Size = new System.Drawing.Size(114, 44);
            this.buttonAttente.TabIndex = 5;
            this.buttonAttente.Text = "Attente";
            this.buttonAttente.UseVisualStyleBackColor = true;
            // 
            // buttonPayer
            // 
            this.buttonPayer.Location = new System.Drawing.Point(652, 394);
            this.buttonPayer.Name = "buttonPayer";
            this.buttonPayer.Size = new System.Drawing.Size(114, 44);
            this.buttonPayer.TabIndex = 5;
            this.buttonPayer.Text = "Payer";
            this.buttonPayer.UseVisualStyleBackColor = true;
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.ItemHeight = 15;
            this.listBoxCategories.Location = new System.Drawing.Point(38, 52);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(120, 94);
            this.listBoxCategories.TabIndex = 6;
            this.listBoxCategories.SelectedIndexChanged += new System.EventHandler(this.listBoxCategories_SelectedIndexChanged);
            // 
            // listBoxProduitMenu
            // 
            this.listBoxProduitMenu.FormattingEnabled = true;
            this.listBoxProduitMenu.ItemHeight = 15;
            this.listBoxProduitMenu.Location = new System.Drawing.Point(218, 52);
            this.listBoxProduitMenu.Name = "listBoxProduitMenu";
            this.listBoxProduitMenu.Size = new System.Drawing.Size(120, 94);
            this.listBoxProduitMenu.TabIndex = 6;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxProduitMenu);
            this.Controls.Add(this.listBoxCategories);
            this.Controls.Add(this.buttonPayer);
            this.Controls.Add(this.buttonAttente);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.dataGridOrder);
            this.Controls.Add(this.textBoxOrderName);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxOrderName;
        private DataGridView dataGridOrder;
        private TextBox textBoxTotal;
        private Button buttonAttente;
        private Button buttonPayer;
        private ListBox listBoxCategories;
        private ListBox listBoxProduitMenu;
    }
}