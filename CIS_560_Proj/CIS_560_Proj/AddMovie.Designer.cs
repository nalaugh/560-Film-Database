namespace CIS_560_Proj
{
    partial class Add
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
            this.uxTextBoxMovieTitle = new System.Windows.Forms.TextBox();
            this.uxLabelMovieTitle = new System.Windows.Forms.Label();
            this.uxNumericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.uxLabelReleaseDate = new System.Windows.Forms.Label();
            this.uxButtonAddMovie = new System.Windows.Forms.Button();
            this.uxLabelTitle = new System.Windows.Forms.Label();
            this.Persontext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxOptoins = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownYear)).BeginInit();
            this.SuspendLayout();
            // 
            // uxTextBoxMovieTitle
            // 
            this.uxTextBoxMovieTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxTextBoxMovieTitle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.uxTextBoxMovieTitle.Location = new System.Drawing.Point(155, 97);
            this.uxTextBoxMovieTitle.Multiline = true;
            this.uxTextBoxMovieTitle.Name = "uxTextBoxMovieTitle";
            this.uxTextBoxMovieTitle.Size = new System.Drawing.Size(269, 35);
            this.uxTextBoxMovieTitle.TabIndex = 2;
            // 
            // uxLabelMovieTitle
            // 
            this.uxLabelMovieTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelMovieTitle.AutoSize = true;
            this.uxLabelMovieTitle.BackColor = System.Drawing.Color.White;
            this.uxLabelMovieTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.uxLabelMovieTitle.ForeColor = System.Drawing.Color.Black;
            this.uxLabelMovieTitle.Location = new System.Drawing.Point(15, 100);
            this.uxLabelMovieTitle.Name = "uxLabelMovieTitle";
            this.uxLabelMovieTitle.Size = new System.Drawing.Size(135, 30);
            this.uxLabelMovieTitle.TabIndex = 3;
            this.uxLabelMovieTitle.Text = "Movie Title:";
            // 
            // uxNumericUpDownYear
            // 
            this.uxNumericUpDownYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxNumericUpDownYear.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.uxNumericUpDownYear.Location = new System.Drawing.Point(315, 159);
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
            this.uxNumericUpDownYear.Size = new System.Drawing.Size(120, 32);
            this.uxNumericUpDownYear.TabIndex = 4;
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
            this.uxLabelReleaseDate.Location = new System.Drawing.Point(15, 160);
            this.uxLabelReleaseDate.Name = "uxLabelReleaseDate";
            this.uxLabelReleaseDate.Size = new System.Drawing.Size(287, 30);
            this.uxLabelReleaseDate.TabIndex = 5;
            this.uxLabelReleaseDate.Text = "Movie Release Date (Year):";
            // 
            // uxButtonAddMovie
            // 
            this.uxButtonAddMovie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxButtonAddMovie.Enabled = false;
            this.uxButtonAddMovie.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButtonAddMovie.Location = new System.Drawing.Point(122, 270);
            this.uxButtonAddMovie.Name = "uxButtonAddMovie";
            this.uxButtonAddMovie.Size = new System.Drawing.Size(200, 50);
            this.uxButtonAddMovie.TabIndex = 8;
            this.uxButtonAddMovie.Text = "Add Movie";
            this.uxButtonAddMovie.UseVisualStyleBackColor = true;
            // 
            // uxLabelTitle
            // 
            this.uxLabelTitle.BackColor = System.Drawing.Color.OrangeRed;
            this.uxLabelTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLabelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.uxLabelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.uxLabelTitle.ForeColor = System.Drawing.Color.White;
            this.uxLabelTitle.Location = new System.Drawing.Point(0, 0);
            this.uxLabelTitle.Name = "uxLabelTitle";
            this.uxLabelTitle.Size = new System.Drawing.Size(499, 50);
            this.uxLabelTitle.TabIndex = 9;
            this.uxLabelTitle.Text = "Add Movie";
            this.uxLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          
            // 
            // Persontext
            // 
            this.Persontext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Persontext.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Persontext.Location = new System.Drawing.Point(186, 211);
            this.Persontext.Multiline = true;
            this.Persontext.Name = "Persontext";
            this.Persontext.Size = new System.Drawing.Size(136, 35);
            this.Persontext.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Actor/Director";
            // 
            // listBoxOptoins
            // 
            this.listBoxOptoins.FormattingEnabled = true;
            this.listBoxOptoins.Location = new System.Drawing.Point(348, 211);
            this.listBoxOptoins.Name = "listBoxOptoins";
            this.listBoxOptoins.Size = new System.Drawing.Size(87, 43);
            this.listBoxOptoins.TabIndex = 12;
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxOptoins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Persontext);
            this.Controls.Add(this.uxLabelTitle);
            this.Controls.Add(this.uxButtonAddMovie);
            this.Controls.Add(this.uxNumericUpDownYear);
            this.Controls.Add(this.uxLabelReleaseDate);
            this.Controls.Add(this.uxTextBoxMovieTitle);
            this.Controls.Add(this.uxLabelMovieTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddMovie";
            this.Size = new System.Drawing.Size(499, 400);
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDownYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxTextBoxMovieTitle;
        private System.Windows.Forms.Label uxLabelMovieTitle;
        private System.Windows.Forms.NumericUpDown uxNumericUpDownYear;
        private System.Windows.Forms.Label uxLabelReleaseDate;
        private System.Windows.Forms.Button uxButtonAddMovie;
        private System.Windows.Forms.Label uxLabelTitle;
        private System.Windows.Forms.TextBox Persontext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxOptoins;
    }
}
