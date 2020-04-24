namespace CIS_560_Proj
{
    partial class Person
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
            this.uxTextBoxMovieTitle = new System.Windows.Forms.TextBox();
            this.uxLabelMovieTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // uxLabelTitle
            // 
            this.uxLabelTitle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.uxLabelTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLabelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.uxLabelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.uxLabelTitle.ForeColor = System.Drawing.Color.White;
            this.uxLabelTitle.Location = new System.Drawing.Point(0, 0);
            this.uxLabelTitle.Name = "uxLabelTitle";
            this.uxLabelTitle.Size = new System.Drawing.Size(589, 50);
            this.uxLabelTitle.TabIndex = 10;
            this.uxLabelTitle.Text = "Person";
            this.uxLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxTextBoxMovieTitle
            // 
            this.uxTextBoxMovieTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxTextBoxMovieTitle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.uxTextBoxMovieTitle.Location = new System.Drawing.Point(160, 92);
            this.uxTextBoxMovieTitle.Multiline = true;
            this.uxTextBoxMovieTitle.Name = "uxTextBoxMovieTitle";
            this.uxTextBoxMovieTitle.Size = new System.Drawing.Size(269, 35);
            this.uxTextBoxMovieTitle.TabIndex = 11;
            // 
            // uxLabelMovieTitle
            // 
            this.uxLabelMovieTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelMovieTitle.AutoSize = true;
            this.uxLabelMovieTitle.BackColor = System.Drawing.Color.White;
            this.uxLabelMovieTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.uxLabelMovieTitle.ForeColor = System.Drawing.Color.Black;
            this.uxLabelMovieTitle.Location = new System.Drawing.Point(23, 92);
            this.uxLabelMovieTitle.Name = "uxLabelMovieTitle";
            this.uxLabelMovieTitle.Size = new System.Drawing.Size(80, 30);
            this.uxLabelMovieTitle.TabIndex = 12;
            this.uxLabelMovieTitle.Text = "Name:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "DOB:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Date of Death:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(215, 230);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxLabelMovieTitle);
            this.Controls.Add(this.uxTextBoxMovieTitle);
            this.Controls.Add(this.uxLabelTitle);
            this.Name = "Person";
            this.Size = new System.Drawing.Size(589, 405);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxLabelTitle;
        private System.Windows.Forms.TextBox uxTextBoxMovieTitle;
        private System.Windows.Forms.Label uxLabelMovieTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}
