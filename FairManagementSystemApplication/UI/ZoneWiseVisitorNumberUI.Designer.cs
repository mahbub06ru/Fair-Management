namespace FairManagementSystemApplication.UI
{
    partial class ZoneWiseVisitorNumberUI
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
            this.zoneWiseVisitorNumberListView = new System.Windows.Forms.ListView();
            this.zone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.noOfVisitor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.zoneWiseVisitorNumberTotalTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zoneWiseVisitorNumberListView
            // 
            this.zoneWiseVisitorNumberListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.zone,
            this.noOfVisitor});
            this.zoneWiseVisitorNumberListView.GridLines = true;
            this.zoneWiseVisitorNumberListView.Location = new System.Drawing.Point(38, 28);
            this.zoneWiseVisitorNumberListView.Margin = new System.Windows.Forms.Padding(2);
            this.zoneWiseVisitorNumberListView.Name = "zoneWiseVisitorNumberListView";
            this.zoneWiseVisitorNumberListView.Size = new System.Drawing.Size(344, 175);
            this.zoneWiseVisitorNumberListView.TabIndex = 0;
            this.zoneWiseVisitorNumberListView.UseCompatibleStateImageBehavior = false;
            this.zoneWiseVisitorNumberListView.View = System.Windows.Forms.View.Details;
            // 
            // zone
            // 
            this.zone.Text = "Zone";
            this.zone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.zone.Width = 161;
            // 
            // noOfVisitor
            // 
            this.noOfVisitor.Text = "No of Visitors";
            this.noOfVisitor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.noOfVisitor.Width = 159;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Count";
            // 
            // zoneWiseVisitorNumberTotalTextBox
            // 
            this.zoneWiseVisitorNumberTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoneWiseVisitorNumberTotalTextBox.Location = new System.Drawing.Point(280, 225);
            this.zoneWiseVisitorNumberTotalTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.zoneWiseVisitorNumberTotalTextBox.Name = "zoneWiseVisitorNumberTotalTextBox";
            this.zoneWiseVisitorNumberTotalTextBox.Size = new System.Drawing.Size(102, 20);
            this.zoneWiseVisitorNumberTotalTextBox.TabIndex = 2;
            // 
            // ZoneWiseVisitorNumberUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 325);
            this.Controls.Add(this.zoneWiseVisitorNumberTotalTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zoneWiseVisitorNumberListView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ZoneWiseVisitorNumberUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zone Wise Visitor Number Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView zoneWiseVisitorNumberListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox zoneWiseVisitorNumberTotalTextBox;
        private System.Windows.Forms.ColumnHeader zone;
        private System.Windows.Forms.ColumnHeader noOfVisitor;
    }
}