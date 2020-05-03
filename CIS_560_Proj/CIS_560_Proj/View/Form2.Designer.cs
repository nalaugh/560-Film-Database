namespace CIS_560_Proj.View
{
    partial class Form2
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
            this.uxProductionName = new System.Windows.Forms.TextBox();
            this.uxLabelProductionLocation = new System.Windows.Forms.Label();
            this.uxProductionLocation = new System.Windows.Forms.TextBox();
            this.uxLabelProductionName = new System.Windows.Forms.Label();
            this.uxButtonInsertProduction = new System.Windows.Forms.Button();
            this.uxDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxProductionName
            // 
            this.uxProductionName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxProductionName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.uxProductionName.Location = new System.Drawing.Point(250, 91);
            this.uxProductionName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxProductionName.Multiline = true;
            this.uxProductionName.Name = "uxProductionName";
            this.uxProductionName.Size = new System.Drawing.Size(296, 44);
            this.uxProductionName.TabIndex = 45;
            // 
            // uxLabelProductionLocation
            // 
            this.uxLabelProductionLocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelProductionLocation.AutoSize = true;
            this.uxLabelProductionLocation.BackColor = System.Drawing.Color.White;
            this.uxLabelProductionLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabelProductionLocation.ForeColor = System.Drawing.Color.Black;
            this.uxLabelProductionLocation.Location = new System.Drawing.Point(13, 152);
            this.uxLabelProductionLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabelProductionLocation.Name = "uxLabelProductionLocation";
            this.uxLabelProductionLocation.Size = new System.Drawing.Size(255, 32);
            this.uxLabelProductionLocation.TabIndex = 44;
            this.uxLabelProductionLocation.Text = "Production Location:";
            // 
            // uxProductionLocation
            // 
            this.uxProductionLocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxProductionLocation.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.uxProductionLocation.Location = new System.Drawing.Point(285, 154);
            this.uxProductionLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxProductionLocation.Multiline = true;
            this.uxProductionLocation.Name = "uxProductionLocation";
            this.uxProductionLocation.Size = new System.Drawing.Size(261, 42);
            this.uxProductionLocation.TabIndex = 42;
            // 
            // uxLabelProductionName
            // 
            this.uxLabelProductionName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelProductionName.AutoSize = true;
            this.uxLabelProductionName.BackColor = System.Drawing.Color.White;
            this.uxLabelProductionName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabelProductionName.ForeColor = System.Drawing.Color.Black;
            this.uxLabelProductionName.Location = new System.Drawing.Point(13, 91);
            this.uxLabelProductionName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabelProductionName.Name = "uxLabelProductionName";
            this.uxLabelProductionName.Size = new System.Drawing.Size(224, 32);
            this.uxLabelProductionName.TabIndex = 43;
            this.uxLabelProductionName.Text = "Production Name:";
            // 
            // uxButtonInsertProduction
            // 
            this.uxButtonInsertProduction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxButtonInsertProduction.Enabled = false;
            this.uxButtonInsertProduction.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButtonInsertProduction.Location = new System.Drawing.Point(69, 255);
            this.uxButtonInsertProduction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxButtonInsertProduction.Name = "uxButtonInsertProduction";
            this.uxButtonInsertProduction.Size = new System.Drawing.Size(182, 70);
            this.uxButtonInsertProduction.TabIndex = 46;
            this.uxButtonInsertProduction.Text = "Add";
            this.uxButtonInsertProduction.UseVisualStyleBackColor = true;
            this.uxButtonInsertProduction.Click += new System.EventHandler(this.uxButtonInsertProduction_Click);
            // 
            // uxDelete
            // 
            this.uxDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxDelete.Enabled = false;
            this.uxDelete.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDelete.Location = new System.Drawing.Point(285, 255);
            this.uxDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxDelete.Name = "uxDelete";
            this.uxDelete.Size = new System.Drawing.Size(182, 70);
            this.uxDelete.TabIndex = 47;
            this.uxDelete.Text = "Cancel";
            this.uxDelete.UseVisualStyleBackColor = true;
            this.uxDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Please fill out the information below to add NEW production";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "The production does not exist.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 359);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxDelete);
            this.Controls.Add(this.uxButtonInsertProduction);
            this.Controls.Add(this.uxProductionName);
            this.Controls.Add(this.uxLabelProductionLocation);
            this.Controls.Add(this.uxProductionLocation);
            this.Controls.Add(this.uxLabelProductionName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxProductionName;
        private System.Windows.Forms.Label uxLabelProductionLocation;
        private System.Windows.Forms.TextBox uxProductionLocation;
        private System.Windows.Forms.Label uxLabelProductionName;
        private System.Windows.Forms.Button uxButtonInsertProduction;
        private System.Windows.Forms.Button uxDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}