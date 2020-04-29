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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Awards);
            this.groupBox1.Controls.Add(this.People);
            this.groupBox1.Controls.Add(this.Production);
            this.groupBox1.Controls.Add(this.Movie);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 440);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Form";
            // 
            // Awards
            // 
            this.Awards.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Awards.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Awards.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Awards.Location = new System.Drawing.Point(0, 338);
            this.Awards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Awards.Name = "Awards";
            this.Awards.Size = new System.Drawing.Size(210, 99);
            this.Awards.TabIndex = 0;
            this.Awards.Text = "Awards";
            this.Awards.UseVisualStyleBackColor = false;
            this.Awards.Click += new System.EventHandler(this.Awards_Click);
            // 
            // People
            // 
            this.People.BackColor = System.Drawing.SystemColors.Highlight;
            this.People.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.People.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.People.Location = new System.Drawing.Point(0, 242);
            this.People.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.People.Name = "People";
            this.People.Size = new System.Drawing.Size(210, 98);
            this.People.TabIndex = 0;
            this.People.Text = "People";
            this.People.UseVisualStyleBackColor = false;
            this.People.Click += new System.EventHandler(this.People_Click);
            // 
            // Production
            // 
            this.Production.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Production.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Production.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Production.Location = new System.Drawing.Point(0, 143);
            this.Production.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Production.Name = "Production";
            this.Production.Size = new System.Drawing.Size(210, 100);
            this.Production.TabIndex = 0;
            this.Production.Text = "Production";
            this.Production.UseVisualStyleBackColor = false;
            this.Production.Click += new System.EventHandler(this.Production_Click);
            // 
            // Movie
            // 
            this.Movie.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Movie.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Movie.Location = new System.Drawing.Point(0, 48);
            this.Movie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Movie.Name = "Movie";
            this.Movie.Size = new System.Drawing.Size(210, 98);
            this.Movie.TabIndex = 0;
            this.Movie.Text = "Movie";
            this.Movie.UseVisualStyleBackColor = false;
            this.Movie.Click += new System.EventHandler(this.Movie_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(254, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1468, 755);
            this.panel2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1762, 752);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "|";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Movie;
        private System.Windows.Forms.Button Awards;
        private System.Windows.Forms.Button People;
        private System.Windows.Forms.Button Production;
    }
}

