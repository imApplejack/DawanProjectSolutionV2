namespace Back.ProductController
{
    partial class ProductForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MajButton = new System.Windows.Forms.Button();
            this.imgBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ProductDatagrid = new System.Windows.Forms.DataGridView();
            this.Create = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MajButton);
            this.groupBox1.Controls.Add(this.imgBox);
            this.groupBox1.Controls.Add(this.priceBox);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produit";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(58, 75);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(125, 27);
            this.idBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Id";
            // 
            // MajButton
            // 
            this.MajButton.Location = new System.Drawing.Point(60, 341);
            this.MajButton.Name = "MajButton";
            this.MajButton.Size = new System.Drawing.Size(94, 29);
            this.MajButton.TabIndex = 7;
            this.MajButton.Text = "Maj";
            this.MajButton.UseVisualStyleBackColor = true;
            this.MajButton.Click += new System.EventHandler(this.MajButton_Click);
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(56, 277);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(125, 27);
            this.imgBox.TabIndex = 6;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(61, 209);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(125, 27);
            this.priceBox.TabIndex = 5;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(60, 145);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(125, 27);
            this.nameBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prix";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(654, 385);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(94, 29);
            this.UpdateButton.TabIndex = 0;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ProductDatagrid
            // 
            this.ProductDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDatagrid.Location = new System.Drawing.Point(346, 30);
            this.ProductDatagrid.MultiSelect = false;
            this.ProductDatagrid.Name = "ProductDatagrid";
            this.ProductDatagrid.RowHeadersWidth = 51;
            this.ProductDatagrid.RowTemplate.Height = 29;
            this.ProductDatagrid.Size = new System.Drawing.Size(697, 338);
            this.ProductDatagrid.TabIndex = 1;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(515, 385);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(94, 29);
            this.Create.TabIndex = 2;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 450);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.ProductDatagrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UpdateButton);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox imgBox;
        private TextBox priceBox;
        private TextBox nameBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button UpdateButton;
        private DataGridView ProductDatagrid;
        private Button MajButton;
        private Label label4;
        private TextBox idBox;
        private Button Create;
    }
}