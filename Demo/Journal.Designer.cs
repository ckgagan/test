namespace Demo
{
    partial class Journal
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.headerTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addVoucherBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.headerTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerTab
            // 
            this.headerTab.Controls.Add(this.tabPage1);
            this.headerTab.Controls.Add(this.tabPage2);
            this.headerTab.ItemSize = new System.Drawing.Size(58, 28);
            this.headerTab.Location = new System.Drawing.Point(2, 2);
            this.headerTab.Name = "headerTab";
            this.headerTab.SelectedIndex = 0;
            this.headerTab.Size = new System.Drawing.Size(1049, 140);
            this.headerTab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addVoucherBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1041, 104);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Journal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1041, 104);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Other";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addVoucherBtn
            // 
            this.addVoucherBtn.Location = new System.Drawing.Point(3, 6);
            this.addVoucherBtn.Name = "addVoucherBtn";
            this.addVoucherBtn.Size = new System.Drawing.Size(97, 50);
            this.addVoucherBtn.TabIndex = 0;
            this.addVoucherBtn.Text = "Add Voucher";
            this.addVoucherBtn.UseVisualStyleBackColor = true;
            this.addVoucherBtn.Click += new System.EventHandler(this.addVoucherBtn_Click);
            // 
            // Journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 613);
            this.Controls.Add(this.headerTab);
            this.IsMdiContainer = true;
            this.Name = "Journal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.headerTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabControl headerTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button addVoucherBtn;

    }
}

