namespace EFDbFirstContext.Forms
{
    partial class FrmFilter
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
            dgvProducts = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            btnFilter = new Button();
            txtMax = new TextBox();
            txtMin = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(78, 160);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(645, 212);
            dgvProducts.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 83);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 10;
            label2.Text = "Max:";
            // 
            // label1
            // 
            label1.Location = new Point(92, 78);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 9;
            label1.Text = "Min:";
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(500, 83);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 8;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(348, 78);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(100, 23);
            txtMax.TabIndex = 7;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(149, 78);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(100, 23);
            txtMin.TabIndex = 6;
            // 
            // FrmFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProducts);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFilter);
            Controls.Add(txtMax);
            Controls.Add(txtMin);
            Name = "FrmFilter";
            Text = "FrmFilter";
            Load += FrmFilter_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private Label label2;
        private Label label1;
        private Button btnFilter;
        private TextBox txtMax;
        private TextBox txtMin;
    }
}