namespace CIS_560_Proj
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
            this.uxLabelTitle = new System.Windows.Forms.Label();
            this.uxButtonAddProduction = new System.Windows.Forms.Button();
            this.uxTextBoxLocation = new System.Windows.Forms.TextBox();
            this.uxLabelLocation = new System.Windows.Forms.Label();
            this.uxLabelProductionName = new System.Windows.Forms.Label();
            this.ProductionName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.uxLabelTitle.Size = new System.Drawing.Size(482, 50);
            this.uxLabelTitle.TabIndex = 17;
            this.uxLabelTitle.Text = "Add Production";
            this.uxLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxButtonAddProduction
            // 
            this.uxButtonAddProduction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxButtonAddProduction.Enabled = false;
            this.uxButtonAddProduction.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButtonAddProduction.Location = new System.Drawing.Point(113, 240);
            this.uxButtonAddProduction.Name = "uxButtonAddProduction";
            this.uxButtonAddProduction.Size = new System.Drawing.Size(200, 50);
            this.uxButtonAddProduction.TabIndex = 16;
            this.uxButtonAddProduction.Text = "Add";
            this.uxButtonAddProduction.UseVisualStyleBackColor = true;
            this.uxButtonAddProduction.Click += new System.EventHandler(this.uxButtonAddProduction_Click);
            // 
            // uxTextBoxLocation
            // 
            this.uxTextBoxLocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxTextBoxLocation.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.uxTextBoxLocation.Location = new System.Drawing.Point(272, 131);
            this.uxTextBoxLocation.Multiline = true;
            this.uxTextBoxLocation.Name = "uxTextBoxLocation";
            this.uxTextBoxLocation.Size = new System.Drawing.Size(165, 35);
            this.uxTextBoxLocation.TabIndex = 14;
            // 
            // uxLabelLocation
            // 
            this.uxLabelLocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelLocation.AutoSize = true;
            this.uxLabelLocation.BackColor = System.Drawing.Color.White;
            this.uxLabelLocation.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.uxLabelLocation.ForeColor = System.Drawing.Color.Black;
            this.uxLabelLocation.Location = new System.Drawing.Point(16, 136);
            this.uxLabelLocation.Name = "uxLabelLocation";
            this.uxLabelLocation.Size = new System.Drawing.Size(228, 30);
            this.uxLabelLocation.TabIndex = 15;
            this.uxLabelLocation.Text = "Production Location:";
            // 
            // uxLabelProductionName
            // 
            this.uxLabelProductionName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxLabelProductionName.AutoSize = true;
            this.uxLabelProductionName.BackColor = System.Drawing.Color.White;
            this.uxLabelProductionName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.uxLabelProductionName.ForeColor = System.Drawing.Color.Black;
            this.uxLabelProductionName.Location = new System.Drawing.Point(16, 79);
            this.uxLabelProductionName.Name = "uxLabelProductionName";
            this.uxLabelProductionName.Size = new System.Drawing.Size(201, 30);
            this.uxLabelProductionName.TabIndex = 13;
            this.uxLabelProductionName.Text = "Production Name:";
            // 
            // ProductionName
            // 
            this.ProductionName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProductionName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ProductionName.Location = new System.Drawing.Point(217, 80);
            this.ProductionName.Multiline = true;
            this.ProductionName.Name = "ProductionName";
            this.ProductionName.Size = new System.Drawing.Size(221, 35);
            this.ProductionName.TabIndex = 18;
            // 
            // AddProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.ProductionName);
            this.Controls.Add(this.uxLabelTitle);
            this.Controls.Add(this.uxButtonAddProduction);
            this.Controls.Add(this.uxTextBoxLocation);
            this.Controls.Add(this.uxLabelLocation);
            this.Controls.Add(this.uxLabelProductionName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddProduction";
            this.Size = new System.Drawing.Size(482, 378);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxLabelTitle;
        private System.Windows.Forms.Button uxButtonAddProduction;
        private System.Windows.Forms.TextBox uxTextBoxLocation;
        private System.Windows.Forms.Label uxLabelLocation;
        private System.Windows.Forms.Label uxLabelProductionName;
        private System.Windows.Forms.TextBox ProductionName;
    }
}
