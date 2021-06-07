
namespace Hamburger
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.orderManegementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addHamburgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExtraMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderManegementToolStripMenuItem,
            this.productManagmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // orderManegementToolStripMenuItem
            // 
            this.orderManegementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createOrderToolStripMenuItem,
            this.orderDetailToolStripMenuItem});
            this.orderManegementToolStripMenuItem.Name = "orderManegementToolStripMenuItem";
            this.orderManegementToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.orderManegementToolStripMenuItem.Text = "Order Manegement";
            // 
            // createOrderToolStripMenuItem
            // 
            this.createOrderToolStripMenuItem.Name = "createOrderToolStripMenuItem";
            this.createOrderToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.createOrderToolStripMenuItem.Text = "Create Order";
            this.createOrderToolStripMenuItem.Click += new System.EventHandler(this.createOrderToolStripMenuItem_Click);
            // 
            // orderDetailToolStripMenuItem
            // 
            this.orderDetailToolStripMenuItem.Name = "orderDetailToolStripMenuItem";
            this.orderDetailToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.orderDetailToolStripMenuItem.Text = "Order Detail";
            this.orderDetailToolStripMenuItem.Click += new System.EventHandler(this.orderDetailToolStripMenuItem_Click);
            // 
            // productManagmentToolStripMenuItem
            // 
            this.productManagmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addHamburgerToolStripMenuItem,
            this.addExtraMaterialToolStripMenuItem});
            this.productManagmentToolStripMenuItem.Name = "productManagmentToolStripMenuItem";
            this.productManagmentToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.productManagmentToolStripMenuItem.Text = "Product Manegement";
            // 
            // addHamburgerToolStripMenuItem
            // 
            this.addHamburgerToolStripMenuItem.Name = "addHamburgerToolStripMenuItem";
            this.addHamburgerToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addHamburgerToolStripMenuItem.Text = "Add Hamburger";
            this.addHamburgerToolStripMenuItem.Click += new System.EventHandler(this.addHamburgerToolStripMenuItem_Click);
            // 
            // addExtraMaterialToolStripMenuItem
            // 
            this.addExtraMaterialToolStripMenuItem.Name = "addExtraMaterialToolStripMenuItem";
            this.addExtraMaterialToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addExtraMaterialToolStripMenuItem.Text = "Add Extra Material";
            this.addExtraMaterialToolStripMenuItem.Click += new System.EventHandler(this.addExtraMaterialToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderManegementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productManagmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addHamburgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExtraMaterialToolStripMenuItem;
    }
}

