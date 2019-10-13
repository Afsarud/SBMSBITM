namespace ProectWindowsFormsApp1
{
    partial class Sales
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.royalityPointTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.avoilableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.catagoryComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.totalMrpTextBox = new System.Windows.Forms.TextBox();
            this.mrpTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.resultShowDataGridView = new System.Windows.Forms.DataGridView();
            this.payableAmountTextBox = new System.Windows.Forms.TextBox();
            this.discountAmountTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.grandTotalTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultShowDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.royalityPointTextBox);
            this.groupBox1.Controls.Add(this.dateTextBox);
            this.groupBox1.Controls.Add(this.customerComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.submitButton);
            this.groupBox2.Controls.Add(this.payableAmountTextBox);
            this.groupBox2.Controls.Add(this.discountAmountTextBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.discountTextBox);
            this.groupBox2.Controls.Add(this.grandTotalTextBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.resultShowDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(318, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 374);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addButton);
            this.groupBox3.Controls.Add(this.totalMrpTextBox);
            this.groupBox3.Controls.Add(this.mrpTextBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.productComboBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.quantityTextBox);
            this.groupBox3.Controls.Add(this.avoilableQuantityTextBox);
            this.groupBox3.Controls.Add(this.catagoryComboBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(22, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 245);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Royality Point";
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(113, 25);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(121, 21);
            this.customerComboBox.TabIndex = 0;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(113, 55);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(121, 20);
            this.dateTextBox.TabIndex = 0;
            // 
            // royalityPointTextBox
            // 
            this.royalityPointTextBox.Location = new System.Drawing.Point(113, 86);
            this.royalityPointTextBox.Name = "royalityPointTextBox";
            this.royalityPointTextBox.Size = new System.Drawing.Size(121, 20);
            this.royalityPointTextBox.TabIndex = 3;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(113, 109);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(121, 20);
            this.quantityTextBox.TabIndex = 9;
            // 
            // avoilableQuantityTextBox
            // 
            this.avoilableQuantityTextBox.Location = new System.Drawing.Point(113, 78);
            this.avoilableQuantityTextBox.Name = "avoilableQuantityTextBox";
            this.avoilableQuantityTextBox.Size = new System.Drawing.Size(121, 20);
            this.avoilableQuantityTextBox.TabIndex = 4;
            // 
            // catagoryComboBox
            // 
            this.catagoryComboBox.FormattingEnabled = true;
            this.catagoryComboBox.Location = new System.Drawing.Point(113, 13);
            this.catagoryComboBox.Name = "catagoryComboBox";
            this.catagoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.catagoryComboBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Avoilable Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Catagory";
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(113, 44);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(121, 21);
            this.productComboBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Product";
            // 
            // totalMrpTextBox
            // 
            this.totalMrpTextBox.Location = new System.Drawing.Point(113, 170);
            this.totalMrpTextBox.Name = "totalMrpTextBox";
            this.totalMrpTextBox.Size = new System.Drawing.Size(121, 20);
            this.totalMrpTextBox.TabIndex = 15;
            // 
            // mrpTextBox
            // 
            this.mrpTextBox.Location = new System.Drawing.Point(113, 139);
            this.mrpTextBox.Name = "mrpTextBox";
            this.mrpTextBox.Size = new System.Drawing.Size(121, 20);
            this.mrpTextBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total MRP (TK)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "MRP (TK)";
            // 
            // resultShowDataGridView
            // 
            this.resultShowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultShowDataGridView.Location = new System.Drawing.Point(15, 19);
            this.resultShowDataGridView.Name = "resultShowDataGridView";
            this.resultShowDataGridView.Size = new System.Drawing.Size(409, 150);
            this.resultShowDataGridView.TabIndex = 0;
            // 
            // payableAmountTextBox
            // 
            this.payableAmountTextBox.Location = new System.Drawing.Point(183, 296);
            this.payableAmountTextBox.Name = "payableAmountTextBox";
            this.payableAmountTextBox.Size = new System.Drawing.Size(130, 20);
            this.payableAmountTextBox.TabIndex = 23;
            // 
            // discountAmountTextBox
            // 
            this.discountAmountTextBox.Location = new System.Drawing.Point(183, 265);
            this.discountAmountTextBox.Name = "discountAmountTextBox";
            this.discountAmountTextBox.Size = new System.Drawing.Size(130, 20);
            this.discountAmountTextBox.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Payable Amount(Tk)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Discount Amount(Tk)";
            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(183, 235);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(130, 20);
            this.discountTextBox.TabIndex = 19;
            // 
            // grandTotalTextBox
            // 
            this.grandTotalTextBox.Location = new System.Drawing.Point(183, 204);
            this.grandTotalTextBox.Name = "grandTotalTextBox";
            this.grandTotalTextBox.Size = new System.Drawing.Size(130, 20);
            this.grandTotalTextBox.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Discount(%)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Grand Total (Tk)";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(125, 207);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 24;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(335, 336);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 25;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 424);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sales";
            this.Text = "Sales";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultShowDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox royalityPointTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox payableAmountTextBox;
        private System.Windows.Forms.TextBox discountAmountTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox grandTotalTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView resultShowDataGridView;
        private System.Windows.Forms.TextBox totalMrpTextBox;
        private System.Windows.Forms.TextBox mrpTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox avoilableQuantityTextBox;
        private System.Windows.Forms.ComboBox catagoryComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button addButton;
    }
}