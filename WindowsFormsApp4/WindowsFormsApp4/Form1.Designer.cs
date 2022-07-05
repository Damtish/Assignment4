namespace WindowsFormsApp4
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
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt_inventoryNumber = new System.Windows.Forms.TextBox();
            this.txt_itName = new System.Windows.Forms.TextBox();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(206, 350);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(143, 38);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(80, 69);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(197, 22);
            this.txt_number.TabIndex = 1;
            this.txt_number.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inventory Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Item Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Price";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(341, 69);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(187, 22);
            this.txt_date.TabIndex = 8;
            // 
            // txt_inventoryNumber
            // 
            this.txt_inventoryNumber.Location = new System.Drawing.Point(576, 69);
            this.txt_inventoryNumber.Name = "txt_inventoryNumber";
            this.txt_inventoryNumber.Size = new System.Drawing.Size(171, 22);
            this.txt_inventoryNumber.TabIndex = 9;
            // 
            // txt_itName
            // 
            this.txt_itName.Location = new System.Drawing.Point(80, 143);
            this.txt_itName.Name = "txt_itName";
            this.txt_itName.Size = new System.Drawing.Size(667, 22);
            this.txt_itName.TabIndex = 10;
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(80, 248);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(197, 22);
            this.txt_count.TabIndex = 11;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(341, 248);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(110, 22);
            this.txt_price.TabIndex = 12;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(444, 350);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(145, 38);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.txt_itName);
            this.Controls.Add(this.txt_inventoryNumber);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.btn_add);
            this.Name = "Form1";
            this.Text = "form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.TextBox txt_inventoryNumber;
        private System.Windows.Forms.TextBox txt_itName;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Button btn_cancel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

