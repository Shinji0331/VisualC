namespace WindowsFormsApp1
{
    partial class ItemForm
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.mtxtMoney = new System.Windows.Forms.MaskedTextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(33, 40);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "分類";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "品名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "金額";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "備考";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(523, 49);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(229, 32);
            this.cmbCategory.TabIndex = 5;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(523, 142);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(229, 31);
            this.txtItem.TabIndex = 6;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(523, 331);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(229, 31);
            this.txtRemarks.TabIndex = 7;
            // 
            // mtxtMoney
            // 
            this.mtxtMoney.Location = new System.Drawing.Point(523, 237);
            this.mtxtMoney.Name = "mtxtMoney";
            this.mtxtMoney.Size = new System.Drawing.Size(229, 31);
            this.mtxtMoney.TabIndex = 8;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(144, 398);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(159, 52);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "登録";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(561, 398);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(158, 52);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.mtxtMoney);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "ItemForm";
            this.Text = "登録";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.MaskedTextBox mtxtMoney;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}