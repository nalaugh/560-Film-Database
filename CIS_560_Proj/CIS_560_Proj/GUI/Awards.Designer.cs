namespace CIS_560_Proj
{
    partial class Awards
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
            this.uxLabelTitle = new System.Windows.Forms.Label();
            this.uxNumericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.uxLabelReleaseDate = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.uxButtonInsertMovie = new System.Windows.Forms.Button();
            this.Deleate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.uxSearchTextBox = new System.Windows.Forms.TextBox();
            this.uxSearchProduction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uxLabelTitle
            // 
            this.uxLabelTitle.BackColor = System.Drawing.Color.Goldenrod;
            this.uxLabelTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLabelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.uxLabelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.uxLabelTitle.ForeColor = System.Drawing.Color.White;
            this.uxLabelTitle.Location = new System.Drawing.Point(0, 0);
            this.uxLabelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabelTitle.Name = "uxLabelTitle";
            this.uxLabelTitle.Size = new System.Drawing.Size(1558, 77);
            this.uxLabelTitle.TabIndex = 10;
            this.uxLabelTitle.Text = "Awards";
            this.uxLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxNumericUpDownYear
            // 
            this.uxNumericUpDownYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxNumericUpDownYear.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.uxNumericUpDownYear.Location = new System.Drawing.Point(489, 125);
            this.uxNumericUpDownYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxNumericUpDownYear.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.uxNumericUpDownYear.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.uxNumericUpDownYear.Name = "uxNumericUpDownYear";
            this.uxNumericUpDownYear.Size = new System.Drawing.Size(180, 45);
            this.uxNumericUpDownYear.TabIndex = 11;
            this.uxNumericUpDownYear.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // uxLabelReleaseDate
            // 
            this.uxLabelReleaseDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelReleaseDate.AutoSize = true;
            this.uxLabelReleaseDate.BackColor = System.Drawing.Color.White;
            this.uxLabelReleaseDate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.uxLabelReleaseDate.ForeColor = System.Drawing.Color.Black;
            this.uxLabelReleaseDate.Location = new System.Drawing.Point(116, 118);
            this.uxLabelReleaseDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabelReleaseDate.Name = "uxLabelReleaseDate";
            this.uxLabelReleaseDate.Size = new System.Drawing.Size(192, 45);
            this.uxLabelReleaseDate.TabIndex = 12;
            this.uxLabelReleaseDate.Text = "AwardYear:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(108, 235);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 144);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(489, 235);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(178, 144);
            this.listBox2.TabIndex = 14;
            // 
            // uxButtonInsertMovie
            // 
            this.uxButtonInsertMovie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxButtonInsertMovie.Enabled = false;
            this.uxButtonInsertMovie.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButtonInsertMovie.Location = new System.Drawing.Point(108, 426);
            this.uxButtonInsertMovie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxButtonInsertMovie.Name = "uxButtonInsertMovie";
            this.uxButtonInsertMovie.Size = new System.Drawing.Size(206, 78);
            this.uxButtonInsertMovie.TabIndex = 15;
            this.uxButtonInsertMovie.Text = "Insert";
            this.uxButtonInsertMovie.UseVisualStyleBackColor = true;
            this.uxButtonInsertMovie.Click += new System.EventHandler(this.uxButtonAddMovie_Click);
            // 
            // Deleate
            // 
            this.Deleate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Deleate.Enabled = false;
            this.Deleate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deleate.Location = new System.Drawing.Point(464, 426);
            this.Deleate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Deleate.Name = "Deleate";
            this.Deleate.Size = new System.Drawing.Size(206, 78);
            this.Deleate.TabIndex = 16;
            this.Deleate.Text = "Deleate";
            this.Deleate.UseVisualStyleBackColor = true;
            this.Deleate.Click += new System.EventHandler(this.Deleate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(755, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(586, 320);
            this.dataGridView1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(750, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "Search Oscars by Year:";
            // 
            // uxSearchTextBox
            // 
            this.uxSearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.uxSearchTextBox.Location = new System.Drawing.Point(755, 140);
            this.uxSearchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxSearchTextBox.Multiline = true;
            this.uxSearchTextBox.Name = "uxSearchTextBox";
            this.uxSearchTextBox.Size = new System.Drawing.Size(433, 52);
            this.uxSearchTextBox.TabIndex = 47;
            // 
            // uxSearchProduction
            // 
            this.uxSearchProduction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxSearchProduction.Enabled = false;
            this.uxSearchProduction.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchProduction.Location = new System.Drawing.Point(1197, 131);
            this.uxSearchProduction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxSearchProduction.Name = "uxSearchProduction";
            this.uxSearchProduction.Size = new System.Drawing.Size(144, 60);
            this.uxSearchProduction.TabIndex = 46;
            this.uxSearchProduction.Text = "Search";
            this.uxSearchProduction.UseVisualStyleBackColor = true;
            this.uxSearchProduction.Click += new System.EventHandler(this.uxSearchProduction_Click);
            // 
            // Awards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxSearchTextBox);
            this.Controls.Add(this.uxSearchProduction);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Deleate);
            this.Controls.Add(this.uxButtonInsertMovie);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.uxLabelReleaseDate);
            this.Controls.Add(this.uxNumericUpDownYear);
            this.Controls.Add(this.uxLabelTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Awards";
            this.Size = new System.Drawing.Size(1558, 594);
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxLabelTitle;
        private System.Windows.Forms.NumericUpDown uxNumericUpDownYear;
        private System.Windows.Forms.Label uxLabelReleaseDate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button uxButtonInsertMovie;
        private System.Windows.Forms.Button Deleate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxSearchTextBox;
        private System.Windows.Forms.Button uxSearchProduction;
    }
}
