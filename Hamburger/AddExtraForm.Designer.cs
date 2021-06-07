
namespace Hamburger
{
    partial class AddExtraForm
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
            this.ExtraDetails = new System.Windows.Forms.GroupBox();
            this.btnSaveExtra = new System.Windows.Forms.Button();
            this.nmrPrice = new System.Windows.Forms.NumericUpDown();
            this.txtExtraName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExtraDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // ExtraDetails
            // 
            this.ExtraDetails.Controls.Add(this.btnSaveExtra);
            this.ExtraDetails.Controls.Add(this.nmrPrice);
            this.ExtraDetails.Controls.Add(this.txtExtraName);
            this.ExtraDetails.Controls.Add(this.label2);
            this.ExtraDetails.Controls.Add(this.label1);
            this.ExtraDetails.Location = new System.Drawing.Point(12, 12);
            this.ExtraDetails.Name = "ExtraDetails";
            this.ExtraDetails.Size = new System.Drawing.Size(531, 216);
            this.ExtraDetails.TabIndex = 1;
            this.ExtraDetails.TabStop = false;
            this.ExtraDetails.Text = "Extra Details";
            // 
            // btnSaveExtra
            // 
            this.btnSaveExtra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveExtra.ForeColor = System.Drawing.Color.White;
            this.btnSaveExtra.Location = new System.Drawing.Point(131, 133);
            this.btnSaveExtra.Name = "btnSaveExtra";
            this.btnSaveExtra.Size = new System.Drawing.Size(268, 59);
            this.btnSaveExtra.TabIndex = 4;
            this.btnSaveExtra.Text = "Save";
            this.btnSaveExtra.UseVisualStyleBackColor = false;
            this.btnSaveExtra.Click += new System.EventHandler(this.btnSaveExtra_Click);
            // 
            // nmrPrice
            // 
            this.nmrPrice.DecimalPlaces = 2;
            this.nmrPrice.Location = new System.Drawing.Point(97, 82);
            this.nmrPrice.Name = "nmrPrice";
            this.nmrPrice.Size = new System.Drawing.Size(221, 26);
            this.nmrPrice.TabIndex = 3;
            // 
            // txtExtraName
            // 
            this.txtExtraName.Location = new System.Drawing.Point(97, 46);
            this.txtExtraName.Name = "txtExtraName";
            this.txtExtraName.Size = new System.Drawing.Size(428, 26);
            this.txtExtraName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extra :";
            // 
            // AddExtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 240);
            this.Controls.Add(this.ExtraDetails);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddExtraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Add Extra";
            this.ExtraDetails.ResumeLayout(false);
            this.ExtraDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ExtraDetails;
        private System.Windows.Forms.Button btnSaveExtra;
        private System.Windows.Forms.NumericUpDown nmrPrice;
        private System.Windows.Forms.TextBox txtExtraName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}