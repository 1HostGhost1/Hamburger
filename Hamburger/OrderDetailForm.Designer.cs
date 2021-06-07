
namespace Hamburger
{
    partial class OrderDetailForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.lstAllOrders = new System.Windows.Forms.ListBox();
            this.gbxTotalEarning = new System.Windows.Forms.GroupBox();
            this.lblTotalEarning = new System.Windows.Forms.Label();
            this.gbxTotalOrderQuantity = new System.Windows.Forms.GroupBox();
            this.lblTotalOrderQuantity = new System.Windows.Forms.Label();
            this.gbxTotalEarningOfExtra = new System.Windows.Forms.GroupBox();
            this.lblTotalEarningOfExtra = new System.Windows.Forms.Label();
            this.gbxNumberOfProductSold = new System.Windows.Forms.GroupBox();
            this.lblNumberOfProductSold = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gbxTotalEarning.SuspendLayout();
            this.gbxTotalOrderQuantity.SuspendLayout();
            this.gbxTotalEarningOfExtra.SuspendLayout();
            this.gbxNumberOfProductSold.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "All Orders";
            // 
            // lstAllOrders
            // 
            this.lstAllOrders.FormattingEnabled = true;
            this.lstAllOrders.ItemHeight = 20;
            this.lstAllOrders.Location = new System.Drawing.Point(25, 58);
            this.lstAllOrders.Name = "lstAllOrders";
            this.lstAllOrders.Size = new System.Drawing.Size(585, 484);
            this.lstAllOrders.TabIndex = 3;
            // 
            // gbxTotalEarning
            // 
            this.gbxTotalEarning.Controls.Add(this.lblTotalEarning);
            this.gbxTotalEarning.Location = new System.Drawing.Point(668, 101);
            this.gbxTotalEarning.Name = "gbxTotalEarning";
            this.gbxTotalEarning.Size = new System.Drawing.Size(200, 70);
            this.gbxTotalEarning.TabIndex = 4;
            this.gbxTotalEarning.TabStop = false;
            this.gbxTotalEarning.Text = "Total Earning";
            // 
            // lblTotalEarning
            // 
            this.lblTotalEarning.AutoSize = true;
            this.lblTotalEarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalEarning.Location = new System.Drawing.Point(31, 31);
            this.lblTotalEarning.Name = "lblTotalEarning";
            this.lblTotalEarning.Size = new System.Drawing.Size(29, 20);
            this.lblTotalEarning.TabIndex = 5;
            this.lblTotalEarning.Text = "₺0";
            // 
            // gbxTotalOrderQuantity
            // 
            this.gbxTotalOrderQuantity.Controls.Add(this.lblTotalOrderQuantity);
            this.gbxTotalOrderQuantity.Location = new System.Drawing.Point(668, 207);
            this.gbxTotalOrderQuantity.Name = "gbxTotalOrderQuantity";
            this.gbxTotalOrderQuantity.Size = new System.Drawing.Size(200, 70);
            this.gbxTotalOrderQuantity.TabIndex = 6;
            this.gbxTotalOrderQuantity.TabStop = false;
            this.gbxTotalOrderQuantity.Text = "Total Order Quantity";
            // 
            // lblTotalOrderQuantity
            // 
            this.lblTotalOrderQuantity.AutoSize = true;
            this.lblTotalOrderQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalOrderQuantity.Location = new System.Drawing.Point(31, 31);
            this.lblTotalOrderQuantity.Name = "lblTotalOrderQuantity";
            this.lblTotalOrderQuantity.Size = new System.Drawing.Size(19, 20);
            this.lblTotalOrderQuantity.TabIndex = 5;
            this.lblTotalOrderQuantity.Text = "0";
            // 
            // gbxTotalEarningOfExtra
            // 
            this.gbxTotalEarningOfExtra.Controls.Add(this.linkLabel1);
            this.gbxTotalEarningOfExtra.Controls.Add(this.lblTotalEarningOfExtra);
            this.gbxTotalEarningOfExtra.Location = new System.Drawing.Point(668, 313);
            this.gbxTotalEarningOfExtra.Name = "gbxTotalEarningOfExtra";
            this.gbxTotalEarningOfExtra.Size = new System.Drawing.Size(200, 70);
            this.gbxTotalEarningOfExtra.TabIndex = 7;
            this.gbxTotalEarningOfExtra.TabStop = false;
            this.gbxTotalEarningOfExtra.Text = "Total Earning Of Extra";
            // 
            // lblTotalEarningOfExtra
            // 
            this.lblTotalEarningOfExtra.AutoSize = true;
            this.lblTotalEarningOfExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalEarningOfExtra.Location = new System.Drawing.Point(31, 31);
            this.lblTotalEarningOfExtra.Name = "lblTotalEarningOfExtra";
            this.lblTotalEarningOfExtra.Size = new System.Drawing.Size(29, 20);
            this.lblTotalEarningOfExtra.TabIndex = 5;
            this.lblTotalEarningOfExtra.Text = "₺0";
            // 
            // gbxNumberOfProductSold
            // 
            this.gbxNumberOfProductSold.Controls.Add(this.lblNumberOfProductSold);
            this.gbxNumberOfProductSold.Location = new System.Drawing.Point(668, 419);
            this.gbxNumberOfProductSold.Name = "gbxNumberOfProductSold";
            this.gbxNumberOfProductSold.Size = new System.Drawing.Size(200, 70);
            this.gbxNumberOfProductSold.TabIndex = 8;
            this.gbxNumberOfProductSold.TabStop = false;
            this.gbxNumberOfProductSold.Text = "Number Of Product Sold";
            // 
            // lblNumberOfProductSold
            // 
            this.lblNumberOfProductSold.AutoSize = true;
            this.lblNumberOfProductSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumberOfProductSold.Location = new System.Drawing.Point(31, 31);
            this.lblNumberOfProductSold.Name = "lblNumberOfProductSold";
            this.lblNumberOfProductSold.Size = new System.Drawing.Size(19, 20);
            this.lblNumberOfProductSold.TabIndex = 5;
            this.lblNumberOfProductSold.Text = "0";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(84, 47);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 20);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click For More";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // OrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 553);
            this.Controls.Add(this.gbxNumberOfProductSold);
            this.Controls.Add(this.gbxTotalEarningOfExtra);
            this.Controls.Add(this.gbxTotalOrderQuantity);
            this.Controls.Add(this.gbxTotalEarning);
            this.Controls.Add(this.lstAllOrders);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Order Detail";
            this.Load += new System.EventHandler(this.OrderDetailForm_Load);
            this.gbxTotalEarning.ResumeLayout(false);
            this.gbxTotalEarning.PerformLayout();
            this.gbxTotalOrderQuantity.ResumeLayout(false);
            this.gbxTotalOrderQuantity.PerformLayout();
            this.gbxTotalEarningOfExtra.ResumeLayout(false);
            this.gbxTotalEarningOfExtra.PerformLayout();
            this.gbxNumberOfProductSold.ResumeLayout(false);
            this.gbxNumberOfProductSold.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstAllOrders;
        private System.Windows.Forms.GroupBox gbxTotalEarning;
        private System.Windows.Forms.Label lblTotalEarning;
        private System.Windows.Forms.GroupBox gbxTotalOrderQuantity;
        private System.Windows.Forms.Label lblTotalOrderQuantity;
        private System.Windows.Forms.GroupBox gbxTotalEarningOfExtra;
        private System.Windows.Forms.Label lblTotalEarningOfExtra;
        private System.Windows.Forms.GroupBox gbxNumberOfProductSold;
        private System.Windows.Forms.Label lblNumberOfProductSold;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}