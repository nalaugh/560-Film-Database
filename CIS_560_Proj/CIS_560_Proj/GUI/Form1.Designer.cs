namespace CIS_560_Proj
{
    partial class Form1
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
            this.Awards = new System.Windows.Forms.Button();
            this.People = new System.Windows.Forms.Button();
            this.Production = new System.Windows.Forms.Button();
            this.Movie = new System.Windows.Forms.Button();
            this.SearchClick = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Awards);
            this.groupBox1.Controls.Add(this.People);
            this.groupBox1.Controls.Add(this.Production);
            this.groupBox1.Controls.Add(this.Movie);
            this.groupBox1.Location = new System.Drawing.Point(16, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(140, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Data";
            // 
            // Awards
            // 
            this.Awards.Location = new System.Drawing.Point(32, 105);
            this.Awards.Name = "Awards";
            this.Awards.Size = new System.Drawing.Size(75, 23);
            this.Awards.TabIndex = 0;
            this.Awards.Text = "Awards";
            this.Awards.UseVisualStyleBackColor = true;
            this.Awards.Click += new System.EventHandler(this.Awards_Click);
            // 
            // People
            // 
            this.People.Location = new System.Drawing.Point(32, 75);
            this.People.Name = "People";
            this.People.Size = new System.Drawing.Size(75, 23);
            this.People.TabIndex = 0;
            this.People.Text = "People";
            this.People.UseVisualStyleBackColor = true;
            this.People.Click += new System.EventHandler(this.People_Click);
            // 
            // Production
            // 
            this.Production.Location = new System.Drawing.Point(32, 46);
            this.Production.Name = "Production";
            this.Production.Size = new System.Drawing.Size(75, 23);
            this.Production.TabIndex = 0;
            this.Production.Text = "Production";
            this.Production.UseVisualStyleBackColor = true;
            this.Production.Click += new System.EventHandler(this.Production_Click);
            // 
            // Movie
            // 
            this.Movie.Location = new System.Drawing.Point(32, 17);
            this.Movie.Name = "Movie";
            this.Movie.Size = new System.Drawing.Size(75, 23);
            this.Movie.TabIndex = 0;
            this.Movie.Text = "Movie";
            this.Movie.UseVisualStyleBackColor = true;
            this.Movie.Click += new System.EventHandler(this.Movie_Click);
            // 
            // SearchClick
            // 
            this.SearchClick.Location = new System.Drawing.Point(25, 3);
            this.SearchClick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchClick.Name = "SearchClick";
            this.SearchClick.Size = new System.Drawing.Size(83, 31);
            this.SearchClick.TabIndex = 4;
            this.SearchClick.Text = "Search";
            this.SearchClick.UseVisualStyleBackColor = true;
            this.SearchClick.Click += new System.EventHandler(this.Search_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchClick);
            this.panel1.Location = new System.Drawing.Point(15, 157);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 40);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(169, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 435);
            this.panel2.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 196);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(140, 225);
            this.listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1175, 489);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "|";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SearchClick;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Movie;
        private System.Windows.Forms.Button Awards;
        private System.Windows.Forms.Button People;
        private System.Windows.Forms.Button Production;
    }
}

