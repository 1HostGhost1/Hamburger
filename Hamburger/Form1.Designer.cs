
namespace Hamburger
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparişYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addHamburgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExtraMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişYönetimiToolStripMenuItem,
            this.productManagmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            this.siparişYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişOluşturToolStripMenuItem,
            this.siparişBilgileriToolStripMenuItem});
            this.siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            this.siparişYönetimiToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.siparişYönetimiToolStripMenuItem.Text = "Order Manegement";
            // 
            // siparişOluşturToolStripMenuItem
            // 
            this.siparişOluşturToolStripMenuItem.Name = "siparişOluşturToolStripMenuItem";
            this.siparişOluşturToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparişOluşturToolStripMenuItem.Text = "Create Order";
            // 
            // siparişBilgileriToolStripMenuItem
            // 
            this.siparişBilgileriToolStripMenuItem.Name = "siparişBilgileriToolStripMenuItem";
            this.siparişBilgileriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparişBilgileriToolStripMenuItem.Text = "Order Detail";
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
            this.addHamburgerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addHamburgerToolStripMenuItem.Text = "Add Hamburger";
            // 
            // addExtraMaterialToolStripMenuItem
            // 
            this.addExtraMaterialToolStripMenuItem.Name = "addExtraMaterialToolStripMenuItem";
            this.addExtraMaterialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addExtraMaterialToolStripMenuItem.Text = "Add Extra Material";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productManagmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addHamburgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExtraMaterialToolStripMenuItem;
    }
}

