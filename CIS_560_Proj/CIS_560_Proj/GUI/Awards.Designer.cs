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
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownYear)).BeginInit();
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
            this.uxLabelTitle.Size = new System.Drawing.Size(742, 77);
            this.uxLabelTitle.TabIndex = 10;
            this.uxLabelTitle.Text = "Awards";
            this.uxLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxNumericUpDownYear
            // 
            this.uxNumericUpDownYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxNumericUpDownYear.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.uxNumericUpDownYear.Location = new System.Drawing.Point(525, 122);
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
            this.uxLabelReleaseDate.Location = new System.Drawing.Point(42, 122);
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
            this.listBox2.Location = new System.Drawing.Point(516, 235);
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
            this.uxButtonInsertMovie.Location = new System.Drawing.Point(65, 424);
            this.uxButtonInsertMovie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxButtonInsertMovie.Name = "uxButtonInsertMovie";
            this.uxButtonInsertMovie.Size = new System.Drawing.Size(206, 79);
            this.uxButtonInsertMovie.TabIndex = 15;
            this.uxButtonInsertMovie.Text = "Insert";
            this.uxButtonInsertMovie.UseVisualStyleBackColor = true;
            this.uxButtonInsertMovie.Click += new System.EventHandler(this.uxButtonAddMovie_Click);
            // 
            // Awards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.uxButtonInsertMovie);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.uxLabelReleaseDate);
            this.Controls.Add(this.uxNumericUpDownYear);
            this.Controls.Add(this.uxLabelTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Awards";
            this.Size = new System.Drawing.Size(742, 594);
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownYear)).EndInit();
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
    }
}
