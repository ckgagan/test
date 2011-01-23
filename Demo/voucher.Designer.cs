namespace Demo
{
    partial class voucher
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
            this.codeNumberLbl = new System.Windows.Forms.Label();
            this.particularLbl = new System.Windows.Forms.Label();
            this.particularTxt = new System.Windows.Forms.TextBox();
            this.lfLbl = new System.Windows.Forms.Label();
            this.lfTxt = new System.Windows.Forms.TextBox();
            this.debitCredit = new System.Windows.Forms.ComboBox();
            this.debitCreditLbl = new System.Windows.Forms.Label();
            this.showBtn = new System.Windows.Forms.Button();
            this.amountLbl = new System.Windows.Forms.Label();
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.ayumiDB1DataSet = new Demo.AyumiDB1DataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.codeNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ayumiDB1DataSet1 = new Demo.AyumiDB1DataSet1();
            this.codeNameTableAdapter = new Demo.AyumiDB1DataSet1TableAdapters.CodeNameTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.ayumiDB1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayumiDB1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // codeNumberLbl
            // 
            this.codeNumberLbl.AutoSize = true;
            this.codeNumberLbl.Location = new System.Drawing.Point(62, 32);
            this.codeNumberLbl.Name = "codeNumberLbl";
            this.codeNumberLbl.Size = new System.Drawing.Size(75, 13);
            this.codeNumberLbl.TabIndex = 0;
            this.codeNumberLbl.Text = "Code Number:";
            // 
            // particularLbl
            // 
            this.particularLbl.AutoSize = true;
            this.particularLbl.Location = new System.Drawing.Point(83, 64);
            this.particularLbl.Name = "particularLbl";
            this.particularLbl.Size = new System.Drawing.Size(54, 13);
            this.particularLbl.TabIndex = 2;
            this.particularLbl.Text = "Particular:";
            // 
            // particularTxt
            // 
            this.particularTxt.Location = new System.Drawing.Point(144, 64);
            this.particularTxt.Name = "particularTxt";
            this.particularTxt.Size = new System.Drawing.Size(167, 20);
            this.particularTxt.TabIndex = 3;
            // 
            // lfLbl
            // 
            this.lfLbl.AutoSize = true;
            this.lfLbl.Location = new System.Drawing.Point(115, 97);
            this.lfLbl.Name = "lfLbl";
            this.lfLbl.Size = new System.Drawing.Size(22, 13);
            this.lfLbl.TabIndex = 4;
            this.lfLbl.Text = "LF:";
            // 
            // lfTxt
            // 
            this.lfTxt.Location = new System.Drawing.Point(143, 89);
            this.lfTxt.Name = "lfTxt";
            this.lfTxt.Size = new System.Drawing.Size(168, 20);
            this.lfTxt.TabIndex = 5;
            // 
            // debitCredit
            // 
            this.debitCredit.DisplayMember = "Debit";
            this.debitCredit.FormattingEnabled = true;
            this.debitCredit.Items.AddRange(new object[] {
            "Credit",
            "Debit"});
            this.debitCredit.Location = new System.Drawing.Point(143, 129);
            this.debitCredit.Name = "debitCredit";
            this.debitCredit.Size = new System.Drawing.Size(121, 21);
            this.debitCredit.Sorted = true;
            this.debitCredit.TabIndex = 6;
            // 
            // debitCreditLbl
            // 
            this.debitCreditLbl.AutoSize = true;
            this.debitCreditLbl.Location = new System.Drawing.Point(60, 132);
            this.debitCreditLbl.Name = "debitCreditLbl";
            this.debitCreditLbl.Size = new System.Drawing.Size(77, 13);
            this.debitCreditLbl.TabIndex = 7;
            this.debitCreditLbl.Text = "Debit or Credit:";
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(143, 180);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(121, 23);
            this.showBtn.TabIndex = 8;
            this.showBtn.Text = "Show Data";
            this.showBtn.UseVisualStyleBackColor = true;
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Location = new System.Drawing.Point(342, 97);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(46, 13);
            this.amountLbl.TabIndex = 9;
            this.amountLbl.Text = "Amount:";
            // 
            // amountTxt
            // 
            this.amountTxt.Location = new System.Drawing.Point(395, 97);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(87, 20);
            this.amountTxt.TabIndex = 10;
            // 
            // ayumiDB1DataSet
            // 
            this.ayumiDB1DataSet.DataSetName = "AyumiDB1DataSet";
            this.ayumiDB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.codeNameBindingSource;
            this.comboBox1.DisplayMember = "CodeName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "ID";
            // 
            // codeNameBindingSource
            // 
            this.codeNameBindingSource.DataMember = "CodeName";
            this.codeNameBindingSource.DataSource = this.ayumiDB1DataSet1;
            // 
            // ayumiDB1DataSet1
            // 
            this.ayumiDB1DataSet1.DataSetName = "AyumiDB1DataSet1";
            this.ayumiDB1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // codeNameTableAdapter
            // 
            this.codeNameTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(130, 91);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(197, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // voucher
            // 
            this.ClientSize = new System.Drawing.Size(533, 266);
            this.Controls.Add(this.progressBar1);
            this.Name = "voucher";
            ((System.ComponentModel.ISupportInitialize)(this.ayumiDB1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayumiDB1DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label codeNumberLbl;
        private System.Windows.Forms.Label particularLbl;
        private System.Windows.Forms.TextBox particularTxt;
        private System.Windows.Forms.Label lfLbl;
        private System.Windows.Forms.TextBox lfTxt;
        private System.Windows.Forms.ComboBox debitCredit;
        private System.Windows.Forms.Label debitCreditLbl;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.TextBox amountTxt;
        private AyumiDB1DataSet ayumiDB1DataSet;
        private System.Windows.Forms.ComboBox comboBox1;
        private AyumiDB1DataSet1 ayumiDB1DataSet1;
        private System.Windows.Forms.BindingSource codeNameBindingSource;
        private Demo.AyumiDB1DataSet1TableAdapters.CodeNameTableAdapter codeNameTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}