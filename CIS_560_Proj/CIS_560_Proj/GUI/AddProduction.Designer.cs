namespace CIS_560_Proj.GUI
{
    partial class AddProduction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxProductionName = new System.Windows.Forms.TextBox();
            this.uxButtonInsertProduction = new System.Windows.Forms.Button();
            this.uxLabelProductionLocation = new System.Windows.Forms.Label();
            this.uxProductionLocation = new System.Windows.Forms.TextBox();
            this.uxLabelProductionName = new System.Windows.Forms.Label();
            this.uxLabelTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uxUpdateMovie = new System.Windows.Forms.Button();
            this.uxDeleteProduction = new System.Windows.Forms.Button();
            this.uxSearchProduction = new System.Windows.Forms.Button();
            this.uxSearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uxProductionName
            // 
            this.uxProductionName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxProductionName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.uxProductionName.Location = new System.Drawing.Point(358, 122);
            this.uxProductionName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxProductionName.Multiline = true;
            this.uxProductionName.Name = "uxProductionName";
            this.uxProductionName.Size = new System.Drawing.Size(299, 52);
            this.uxProductionName.TabIndex = 41;
            // 
            // uxButtonInsertProduction
            // 
            this.uxButtonInsertProduction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxButtonInsertProduction.Enabled = false;
            this.uxButtonInsertProduction.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButtonInsertProduction.Location = new System.Drawing.Point(127, 317);
            this.uxButtonInsertProduction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxButtonInsertProduction.Name = "uxButtonInsertProduction";
            this.uxButtonInsertProduction.Size = new System.Drawing.Size(165, 60);
            this.uxButtonInsertProduction.TabIndex = 32;
            this.uxButtonInsertProduction.Text = "Insert";
            this.uxButtonInsertProduction.UseVisualStyleBackColor = true;
            this.uxButtonInsertProduction.Click += new System.EventHandler(this.uxButtonInsertProduction_Click);
            // 
            // uxLabelProductionLocation
            // 
            this.uxLabelProductionLocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelProductionLocation.AutoSize = true;
            this.uxLabelProductionLocation.BackColor = System.Drawing.Color.White;
            this.uxLabelProductionLocation.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.uxLabelProductionLocation.ForeColor = System.Drawing.Color.Black;
            this.uxLabelProductionLocation.Location = new System.Drawing.Point(20, 195);
            this.uxLabelProductionLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabelProductionLocation.Name = "uxLabelProductionLocation";
            this.uxLabelProductionLocation.Size = new System.Drawing.Size(333, 45);
            this.uxLabelProductionLocation.TabIndex = 31;
            this.uxLabelProductionLocation.Text = "Production Location:";
            // 
            // uxProductionLocation
            // 
            this.uxProductionLocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxProductionLocation.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.uxProductionLocation.Location = new System.Drawing.Point(361, 197);
            this.uxProductionLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxProductionLocation.Multiline = true;
            this.uxProductionLocation.Name = "uxProductionLocation";
            this.uxProductionLocation.Size = new System.Drawing.Size(296, 52);
            this.uxProductionLocation.TabIndex = 29;
            // 
            // uxLabelProductionName
            // 
            this.uxLabelProductionName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelProductionName.AutoSize = true;
            this.uxLabelProductionName.BackColor = System.Drawing.Color.White;
            this.uxLabelProductionName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.uxLabelProductionName.ForeColor = System.Drawing.Color.Black;
            this.uxLabelProductionName.Location = new System.Drawing.Point(20, 122);
            this.uxLabelProductionName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabelProductionName.Name = "uxLabelProductionName";
            this.uxLabelProductionName.Size = new System.Drawing.Size(293, 45);
            this.uxLabelProductionName.TabIndex = 30;
            this.uxLabelProductionName.Text = "Production Name:";
            // 
            // uxLabelTitle
            // 
            this.uxLabelTitle.BackColor = System.Drawing.Color.OrangeRed;
            this.uxLabelTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLabelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.uxLabelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.uxLabelTitle.ForeColor = System.Drawing.Color.White;
            this.uxLabelTitle.Location = new System.Drawing.Point(0, 0);
            this.uxLabelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabelTitle.Name = "uxLabelTitle";
            this.uxLabelTitle.Size = new System.Drawing.Size(1390, 77);
            this.uxLabelTitle.TabIndex = 42;
            this.uxLabelTitle.Text = "Production";
            this.uxLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(711, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(586, 320);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // uxUpdateMovie
            // 
            this.uxUpdateMovie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxUpdateMovie.Enabled = false;
            this.uxUpdateMovie.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUpdateMovie.Location = new System.Drawing.Point(378, 317);
            this.uxUpdateMovie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxUpdateMovie.Name = "uxUpdateMovie";
            this.uxUpdateMovie.Size = new System.Drawing.Size(182, 60);
            this.uxUpdateMovie.TabIndex = 37;
            this.uxUpdateMovie.Text = "Update";
            this.uxUpdateMovie.UseVisualStyleBackColor = true;
            // 
            // uxDeleteProduction
            // 
            this.uxDeleteProduction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxDeleteProduction.Enabled = false;
            this.uxDeleteProduction.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDeleteProduction.Location = new System.Drawing.Point(238, 445);
            this.uxDeleteProduction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxDeleteProduction.Name = "uxDeleteProduction";
            this.uxDeleteProduction.Size = new System.Drawing.Size(190, 60);
            this.uxDeleteProduction.TabIndex = 38;
            this.uxDeleteProduction.Text = "Delete";
            this.uxDeleteProduction.UseVisualStyleBackColor = true;
            // 
            // uxSearchProduction
            // 
            this.uxSearchProduction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxSearchProduction.Enabled = false;
            this.uxSearchProduction.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchProduction.Location = new System.Drawing.Point(1151, 118);
            this.uxSearchProduction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxSearchProduction.Name = "uxSearchProduction";
            this.uxSearchProduction.Size = new System.Drawing.Size(144, 60);
            this.uxSearchProduction.TabIndex = 39;
            this.uxSearchProduction.Text = "Search";
            this.uxSearchProduction.UseVisualStyleBackColor = true;
            this.uxSearchProduction.Click += new System.EventHandler(this.uxViewMovies_Click);
            // 
            // uxSearchTextBox
            // 
            this.uxSearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.uxSearchTextBox.Location = new System.Drawing.Point(710, 126);
            this.uxSearchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxSearchTextBox.Multiline = true;
            this.uxSearchTextBox.Name = "uxSearchTextBox";
            this.uxSearchTextBox.Size = new System.Drawing.Size(433, 52);
            this.uxSearchTextBox.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(717, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 29);
            this.label1.TabIndex = 45;
            this.label1.Text = "Search Production House by Name:";
            // 
            // AddProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxSearchTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uxLabelTitle);
            this.Controls.Add(this.uxProductionName);
            this.Controls.Add(this.uxSearchProduction);
            this.Controls.Add(this.uxDeleteProduction);
            this.Controls.Add(this.uxUpdateMovie);
            this.Controls.Add(this.uxButtonInsertProduction);
            this.Controls.Add(this.uxLabelProductionLocation);
            this.Controls.Add(this.uxProductionLocation);
            this.Controls.Add(this.uxLabelProductionName);
            this.Name = "AddProduction";
            this.Size = new System.Drawing.Size(1390, 696);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxProductionName;
        private System.Windows.Forms.Button uxButtonInsertProduction;
        private System.Windows.Forms.Label uxLabelProductionLocation;
        private System.Windows.Forms.TextBox uxProductionLocation;
        private System.Windows.Forms.Label uxLabelProductionName;
        private System.Windows.Forms.Label uxLabelTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button uxUpdateMovie;
        private System.Windows.Forms.Button uxDeleteProduction;
        private System.Windows.Forms.Button uxSearchProduction;
        private System.Windows.Forms.TextBox uxSearchTextBox;
        private System.Windows.Forms.Label label1;
    }
}
