namespace CIS_560_Proj.GUI
{
    partial class People
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
            this.uxPersonName = new System.Windows.Forms.TextBox();
            this.uxLabelMovieTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.uxDeathCheckBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.uxInsertButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uxViewButton = new System.Windows.Forms.Button();
            this.uxSearchBox = new System.Windows.Forms.TextBox();
            this.Deleate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uxLabelTitle
            // 
            this.uxLabelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.uxLabelTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLabelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.uxLabelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.uxLabelTitle.ForeColor = System.Drawing.Color.White;
            this.uxLabelTitle.Location = new System.Drawing.Point(0, 0);
            this.uxLabelTitle.Name = "uxLabelTitle";
            this.uxLabelTitle.Size = new System.Drawing.Size(851, 50);
            this.uxLabelTitle.TabIndex = 10;
            this.uxLabelTitle.Text = "Person";
            this.uxLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxPersonName
            // 
            this.uxPersonName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxPersonName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.uxPersonName.Location = new System.Drawing.Point(115, 92);
            this.uxPersonName.Multiline = true;
            this.uxPersonName.Name = "uxPersonName";
            this.uxPersonName.Size = new System.Drawing.Size(254, 31);
            this.uxPersonName.TabIndex = 11;
            // 
            // uxLabelMovieTitle
            // 
            this.uxLabelMovieTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelMovieTitle.AutoSize = true;
            this.uxLabelMovieTitle.BackColor = System.Drawing.Color.White;
            this.uxLabelMovieTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.uxLabelMovieTitle.ForeColor = System.Drawing.Color.Black;
            this.uxLabelMovieTitle.Location = new System.Drawing.Point(25, 91);
            this.uxLabelMovieTitle.Name = "uxLabelMovieTitle";
            this.uxLabelMovieTitle.Size = new System.Drawing.Size(74, 30);
            this.uxLabelMovieTitle.TabIndex = 12;
            this.uxLabelMovieTitle.Text = "Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "DOB";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 148);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // uxDeathCheckBox
            // 
            this.uxDeathCheckBox.AutoSize = true;
            this.uxDeathCheckBox.Location = new System.Drawing.Point(74, 185);
            this.uxDeathCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxDeathCheckBox.Name = "uxDeathCheckBox";
            this.uxDeathCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uxDeathCheckBox.Size = new System.Drawing.Size(84, 17);
            this.uxDeathCheckBox.TabIndex = 16;
            this.uxDeathCheckBox.Text = "Death Date:";
            this.uxDeathCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(159, 182);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // uxInsertButton
            // 
            this.uxInsertButton.Location = new System.Drawing.Point(31, 239);
            this.uxInsertButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxInsertButton.Name = "uxInsertButton";
            this.uxInsertButton.Size = new System.Drawing.Size(99, 38);
            this.uxInsertButton.TabIndex = 18;
            this.uxInsertButton.Text = "Insert";
            this.uxInsertButton.UseVisualStyleBackColor = true;
            this.uxInsertButton.Click += new System.EventHandler(this.uxInsertButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(438, 109);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(361, 234);
            this.dataGridView1.TabIndex = 19;
            // 
            // uxViewButton
            // 
            this.uxViewButton.Location = new System.Drawing.Point(719, 59);
            this.uxViewButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxViewButton.Name = "uxViewButton";
            this.uxViewButton.Size = new System.Drawing.Size(91, 38);
            this.uxViewButton.TabIndex = 20;
            this.uxViewButton.Text = "Search";
            this.uxViewButton.UseVisualStyleBackColor = true;
            this.uxViewButton.Click += new System.EventHandler(this.uxViewButton_Click);
            // 
            // uxSearchBox
            // 
            this.uxSearchBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxSearchBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.uxSearchBox.Location = new System.Drawing.Point(438, 63);
            this.uxSearchBox.Multiline = true;
            this.uxSearchBox.Name = "uxSearchBox";
            this.uxSearchBox.Size = new System.Drawing.Size(269, 35);
            this.uxSearchBox.TabIndex = 21;
            // 
            // Deleate
            // 
            this.Deleate.Location = new System.Drawing.Point(262, 239);
            this.Deleate.Margin = new System.Windows.Forms.Padding(2);
            this.Deleate.Name = "Deleate";
            this.Deleate.Size = new System.Drawing.Size(99, 38);
            this.Deleate.TabIndex = 22;
            this.Deleate.Text = "Deleate";
            this.Deleate.UseVisualStyleBackColor = true;
            this.Deleate.Click += new System.EventHandler(this.Deleate_Click);
            // 
            // People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Deleate);
            this.Controls.Add(this.uxSearchBox);
            this.Controls.Add(this.uxViewButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uxInsertButton);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.uxDeathCheckBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxPersonName);
            this.Controls.Add(this.uxLabelMovieTitle);
            this.Controls.Add(this.uxLabelTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "People";
            this.Size = new System.Drawing.Size(851, 367);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxLabelTitle;
        private System.Windows.Forms.TextBox uxPersonName;
        private System.Windows.Forms.Label uxLabelMovieTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox uxDeathCheckBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button uxInsertButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button uxViewButton;
        private System.Windows.Forms.TextBox uxSearchBox;
        private System.Windows.Forms.Button Deleate;
    }
}
