namespace Back.KpiController
{
    partial class KpiForm
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
            this.OrderDatagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderDatagrid
            // 
            this.OrderDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDatagrid.Location = new System.Drawing.Point(76, 72);
            this.OrderDatagrid.Name = "OrderDatagrid";
            this.OrderDatagrid.RowTemplate.Height = 25;
            this.OrderDatagrid.Size = new System.Drawing.Size(666, 307);
            this.OrderDatagrid.TabIndex = 0;
            // 
            // KpiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderDatagrid);
            this.Name = "KpiForm";
            this.Text = "KpiForm";
            ((System.ComponentModel.ISupportInitialize)(this.OrderDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView OrderDatagrid;
    }
}