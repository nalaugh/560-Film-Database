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
            this.uxSearchButton = new System.Windows.Forms.Button();
            this.uxSearchBox = new System.Windows.Forms.TextBox();
            this.uxDeleteButton = new System.Windows.Forms.Button();
            this.uxViewButton = new System.Windows.Forms.Button();
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
            this.uxLabelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabelTitle.Name = "uxLabelTitle";
            this.uxLabelTitle.Size = new System.Drawing.Size(1293, 77);
            this.uxLabelTitle.TabIndex = 10;
            this.uxLabelTitle.Text = "Person";
            this.uxLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxPersonName
            // 
            this.uxPersonName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxPersonName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.uxPersonName.Location = new System.Drawing.Point(180, 142);
            this.uxPersonName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxPersonName.Multiline = true;
            this.uxPersonName.Name = "uxPersonName";
            this.uxPersonName.Size = new System.Drawing.Size(379, 46);
            this.uxPersonName.TabIndex = 11;
            // 
            // uxLabelMovieTitle
            // 
            this.uxLabelMovieTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelMovieTitle.AutoSize = true;
            this.uxLabelMovieTitle.BackColor = System.Drawing.Color.White;
            this.uxLabelMovieTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.uxLabelMovieTitle.ForeColor = System.Drawing.Color.Black;
            this.uxLabelMovieTitle.Location = new System.Drawing.Point(46, 140);
            this.uxLabelMovieTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabelMovieTitle.Name = "uxLabelMovieTitle";
            this.uxLabelMovieTitle.Size = new System.Drawing.Size(108, 45);
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
            this.label1.Location = new System.Drawing.Point(65, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 45);
            this.label1.TabIndex = 14;
            this.label1.Text = "DOB";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 228);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(362, 26);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // uxDeathCheckBox
            // 
            this.uxDeathCheckBox.AutoSize = true;
            this.uxDeathCheckBox.Location = new System.Drawing.Point(111, 285);
            this.uxDeathCheckBox.Name = "uxDeathCheckBox";
            this.uxDeathCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uxDeathCheckBox.Size = new System.Drawing.Size(122, 24);
            this.uxDeathCheckBox.TabIndex = 16;
            this.uxDeathCheckBox.Text = "Death Date:";
            this.uxDeathCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(238, 280);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(301, 26);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // uxInsertButton
            // 
            this.uxInsertButton.Location = new System.Drawing.Point(145, 368);
            this.uxInsertButton.Name = "uxInsertButton";
            this.uxInsertButton.Size = new System.Drawing.Size(148, 58);
            this.uxInsertButton.TabIndex = 18;
            this.uxInsertButton.Text = "Insert";
            this.uxInsertButton.UseVisualStyleBackColor = true;
            this.uxInsertButton.Click += new System.EventHandler(this.uxInsertButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(657, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(588, 360);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Location = new System.Drawing.Point(1109, 91);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(136, 58);
            this.uxSearchButton.TabIndex = 20;
            this.uxSearchButton.Text = "Search";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            this.uxSearchButton.Click += new System.EventHandler(this.uxSearchButton_Click);
            // 
            // uxSearchBox
            // 
            this.uxSearchBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxSearchBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.uxSearchBox.Location = new System.Drawing.Point(657, 92);
            this.uxSearchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxSearchBox.Multiline = true;
            this.uxSearchBox.Name = "uxSearchBox";
            this.uxSearchBox.Size = new System.Drawing.Size(428, 52);
            this.uxSearchBox.TabIndex = 21;
            // 
            // uxDeleteButton
            // 
            this.uxDeleteButton.Location = new System.Drawing.Point(260, 461);
            this.uxDeleteButton.Name = "uxDeleteButton";
            this.uxDeleteButton.Size = new System.Drawing.Size(148, 58);
            this.uxDeleteButton.TabIndex = 22;
            this.uxDeleteButton.Text = "Delete";
            this.uxDeleteButton.UseVisualStyleBackColor = true;
            this.uxDeleteButton.Click += new System.EventHandler(this.uxDeleteButton_Click);
            // 
            // uxViewButton
            // 
            this.uxViewButton.Location = new System.Drawing.Point(342, 368);
            this.uxViewButton.Name = "uxViewButton";
            this.uxViewButton.Size = new System.Drawing.Size(148, 58);
            this.uxViewButton.TabIndex = 23;
            this.uxViewButton.Text = "View";
            this.uxViewButton.UseVisualStyleBackColor = true;
            this.uxViewButton.Click += new System.EventHandler(this.uxViewButton_Click);
            // 
            // People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxViewButton);
            this.Controls.Add(this.uxDeleteButton);
            this.Controls.Add(this.uxSearchBox);
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uxInsertButton);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.uxDeathCheckBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxPersonName);
            this.Controls.Add(this.uxLabelMovieTitle);
            this.Controls.Add(this.uxLabelTitle);
            this.Name = "People";
            this.Size = new System.Drawing.Size(1293, 598);
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
        private System.Windows.Forms.Button uxSearchButton;
        private System.Windows.Forms.TextBox uxSearchBox;
        private System.Windows.Forms.Button uxDeleteButton;
        private System.Windows.Forms.Button uxViewButton;
    }
}
