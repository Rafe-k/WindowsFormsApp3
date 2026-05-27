namespace WindowsFormsApp1
{
    partial class Orders_UC
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
            this.dgvAvailable = new System.Windows.Forms.DataGridView();
            this.dgvCurrentOrder = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_loadOrder = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_Checkout = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOrderName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelBack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentOrder)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAvailable
            // 
            this.dgvAvailable.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailable.Location = new System.Drawing.Point(295, 36);
            this.dgvAvailable.Name = "dgvAvailable";
            this.dgvAvailable.Size = new System.Drawing.Size(222, 255);
            this.dgvAvailable.TabIndex = 0;
            // 
            // dgvCurrentOrder
            // 
            this.dgvCurrentOrder.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvCurrentOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentOrder.Location = new System.Drawing.Point(541, 36);
            this.dgvCurrentOrder.Name = "dgvCurrentOrder";
            this.dgvCurrentOrder.Size = new System.Drawing.Size(227, 255);
            this.dgvCurrentOrder.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(352, 347);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button_loadOrder);
            this.panel1.Controls.Add(this.button_save);
            this.panel1.Controls.Add(this.button_remove);
            this.panel1.Controls.Add(this.button_Checkout);
            this.panel1.Controls.Add(this.buttonLoad);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxOrderName);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxDesc);
            this.panel1.Location = new System.Drawing.Point(27, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 296);
            this.panel1.TabIndex = 31;
            // 
            // button_loadOrder
            // 
            this.button_loadOrder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_loadOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_loadOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_loadOrder.Location = new System.Drawing.Point(107, 204);
            this.button_loadOrder.Name = "button_loadOrder";
            this.button_loadOrder.Size = new System.Drawing.Size(75, 23);
            this.button_loadOrder.TabIndex = 33;
            this.button_loadOrder.Text = "Load Order";
            this.button_loadOrder.UseVisualStyleBackColor = false;
            this.button_loadOrder.Click += new System.EventHandler(this.button_loadOrder_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_save.Location = new System.Drawing.Point(6, 204);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 34;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_remove
            // 
            this.button_remove.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_remove.Location = new System.Drawing.Point(107, 233);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(75, 23);
            this.button_remove.TabIndex = 33;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = false;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_Checkout
            // 
            this.button_Checkout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Checkout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Checkout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Checkout.Location = new System.Drawing.Point(6, 233);
            this.button_Checkout.Name = "button_Checkout";
            this.button_Checkout.Size = new System.Drawing.Size(75, 23);
            this.button_Checkout.TabIndex = 33;
            this.button_Checkout.Text = "Checkout";
            this.button_Checkout.UseVisualStyleBackColor = false;
            this.button_Checkout.Click += new System.EventHandler(this.button_Checkout_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLoad.Location = new System.Drawing.Point(6, 264);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 32;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Order Name";
            // 
            // textBoxOrderName
            // 
            this.textBoxOrderName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxOrderName.Location = new System.Drawing.Point(4, 15);
            this.textBoxOrderName.Name = "textBoxOrderName";
            this.textBoxOrderName.Size = new System.Drawing.Size(179, 20);
            this.textBoxOrderName.TabIndex = 32;
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxID.Location = new System.Drawing.Point(4, 54);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(179, 20);
            this.textBoxID.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_add.Location = new System.Drawing.Point(108, 264);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 21;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Location = new System.Drawing.Point(3, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Description";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDesc.Location = new System.Drawing.Point(3, 93);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(179, 20);
            this.textBoxDesc.TabIndex = 25;
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.Location = new System.Drawing.Point(227, 33);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(49, 13);
            this.labelBack.TabIndex = 32;
            this.labelBack.Text = "Go Back";
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            // 
            // Orders_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvCurrentOrder);
            this.Controls.Add(this.dgvAvailable);
            this.Name = "Orders_UC";
            this.Size = new System.Drawing.Size(810, 460);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAvailable;
        private System.Windows.Forms.DataGridView dgvCurrentOrder;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxOrderName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.Button button_Checkout;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_loadOrder;
    }
}
