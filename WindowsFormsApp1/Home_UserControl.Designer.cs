namespace WindowsFormsApp1
{
    partial class Home_UserControl
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
            this.buttonInventory = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInventory
            // 
            this.buttonInventory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInventory.Location = new System.Drawing.Point(13, 15);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.Size = new System.Drawing.Size(75, 54);
            this.buttonInventory.TabIndex = 7;
            this.buttonInventory.Text = "Inventory";
            this.buttonInventory.UseVisualStyleBackColor = false;
            this.buttonInventory.Click += new System.EventHandler(this.buttonInventory_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 460);
            this.panel2.TabIndex = 13;
            // 
            // buttonOrders
            // 
            this.buttonOrders.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOrders.Location = new System.Drawing.Point(13, 72);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(75, 54);
            this.buttonOrders.TabIndex = 8;
            this.buttonOrders.Text = "Orders";
            this.buttonOrders.UseVisualStyleBackColor = false;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonInventory);
            this.Controls.Add(this.panel2);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(810, 460);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInventory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonOrders;
    }
}
