namespace EVEPIPlan
{
    partial class PIInfo
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
            this.piNameTxt = new System.Windows.Forms.TextBox();
            this.piLvlBox = new System.Windows.Forms.ComboBox();
            this.reqList = new System.Windows.Forms.ListView();
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.addReqAmountBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.addPiBtn = new System.Windows.Forms.Button();
            this.addToReqBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // piNameTxt
            // 
            this.piNameTxt.Location = new System.Drawing.Point(12, 12);
            this.piNameTxt.Name = "piNameTxt";
            this.piNameTxt.Size = new System.Drawing.Size(190, 23);
            this.piNameTxt.TabIndex = 0;
            // 
            // piLvlBox
            // 
            this.piLvlBox.FormattingEnabled = true;
            this.piLvlBox.Items.AddRange(new object[] {
            "P0",
            "P1",
            "P2",
            "P3",
            "P4"});
            this.piLvlBox.Location = new System.Drawing.Point(12, 41);
            this.piLvlBox.Name = "piLvlBox";
            this.piLvlBox.Size = new System.Drawing.Size(190, 23);
            this.piLvlBox.TabIndex = 1;
            // 
            // reqList
            // 
            this.reqList.Location = new System.Drawing.Point(12, 79);
            this.reqList.Name = "reqList";
            this.reqList.Size = new System.Drawing.Size(190, 199);
            this.reqList.TabIndex = 2;
            this.reqList.UseCompatibleStateImageBehavior = false;
            // 
            // amountTxt
            // 
            this.amountTxt.Location = new System.Drawing.Point(12, 294);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(80, 23);
            this.amountTxt.TabIndex = 3;
            // 
            // addReqAmountBtn
            // 
            this.addReqAmountBtn.Location = new System.Drawing.Point(98, 294);
            this.addReqAmountBtn.Name = "addReqAmountBtn";
            this.addReqAmountBtn.Size = new System.Drawing.Size(104, 23);
            this.addReqAmountBtn.TabIndex = 4;
            this.addReqAmountBtn.Text = "Add amount";
            this.addReqAmountBtn.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(289, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(178, 266);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // addPiBtn
            // 
            this.addPiBtn.Location = new System.Drawing.Point(219, 12);
            this.addPiBtn.Name = "addPiBtn";
            this.addPiBtn.Size = new System.Drawing.Size(51, 52);
            this.addPiBtn.TabIndex = 6;
            this.addPiBtn.Text = ">";
            this.addPiBtn.UseVisualStyleBackColor = true;
            // 
            // addToReqBtn
            // 
            this.addToReqBtn.Location = new System.Drawing.Point(219, 150);
            this.addToReqBtn.Name = "addToReqBtn";
            this.addToReqBtn.Size = new System.Drawing.Size(51, 52);
            this.addToReqBtn.TabIndex = 6;
            this.addToReqBtn.Text = "<";
            this.addToReqBtn.UseVisualStyleBackColor = true;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(289, 293);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(178, 23);
            this.delBtn.TabIndex = 7;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            // 
            // PIInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 330);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addToReqBtn);
            this.Controls.Add(this.addPiBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.addReqAmountBtn);
            this.Controls.Add(this.amountTxt);
            this.Controls.Add(this.reqList);
            this.Controls.Add(this.piLvlBox);
            this.Controls.Add(this.piNameTxt);
            this.Name = "PIInfo";
            this.Text = "PIInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PIInfo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox piNameTxt;
        private ComboBox piLvlBox;
        private ListView reqList;
        private TextBox amountTxt;
        private Button addReqAmountBtn;
        private ListView listView1;
        private Button addPiBtn;
        private Button addToReqBtn;
        private Button delBtn;
    }
}