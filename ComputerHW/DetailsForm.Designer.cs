namespace ComputerHW
{
    partial class DetailsForm
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
            ProductDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ProductDataGridView
            // 
            ProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDataGridView.Dock = DockStyle.Fill;
            ProductDataGridView.Location = new Point(0, 0);
            ProductDataGridView.Name = "ProductDataGridView";
            ProductDataGridView.Size = new Size(800, 450);
            ProductDataGridView.TabIndex = 0;
            ProductDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // DetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProductDataGridView);
            Name = "DetailsForm";
            Text = "DetailsForm";
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ProductDataGridView;
    }
}