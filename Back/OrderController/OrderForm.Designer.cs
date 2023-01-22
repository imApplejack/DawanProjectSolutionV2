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
            this.listViewCategories = new System.Windows.Forms.ListView();
            this.listViewMenusProduits = new System.Windows.Forms.ListView();
            this.textBoxOrderName = new System.Windows.Forms.TextBox();
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAttente = new System.Windows.Forms.Button();
            this.buttonPayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewCategories
            // 
            this.listViewCategories.Location = new System.Drawing.Point(24, 52);
            this.listViewCategories.Name = "listViewCategories";
            this.listViewCategories.Size = new System.Drawing.Size(157, 328);
            this.listViewCategories.TabIndex = 0;
            this.listViewCategories.UseCompatibleStateImageBehavior = false;
            // 
            // listViewMenusProduits
            // 
            this.listViewMenusProduits.Location = new System.Drawing.Point(199, 52);
            this.listViewMenusProduits.Name = "listViewMenusProduits";
            this.listViewMenusProduits.Size = new System.Drawing.Size(176, 327);
            this.listViewMenusProduits.TabIndex = 1;
            this.listViewMenusProduits.UseCompatibleStateImageBehavior = false;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(412, 356);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 23);
            this.textBox1.TabIndex = 4;
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
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPayer);
            this.Controls.Add(this.buttonAttente);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridOrder);
            this.Controls.Add(this.textBoxOrderName);
            this.Controls.Add(this.listViewMenusProduits);
            this.Controls.Add(this.listViewCategories);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listViewCategories;
        private ListView listViewMenusProduits;
        private TextBox textBoxOrderName;
        private DataGridView dataGridOrder;
        private TextBox textBox1;
        private Button buttonAttente;
        private Button buttonPayer;
    }
}