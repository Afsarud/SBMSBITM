namespace ProectWindowsFormsApp1
{
    partial class Customer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customerCodeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerAddressTextBox = new System.Windows.Forms.TextBox();
            this.customerEmailTextBox = new System.Windows.Forms.TextBox();
            this.customerContactTextBox = new System.Windows.Forms.TextBox();
            this.loyaltyPointTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Loyalty Point";
            // 
            // customerCodeTextBox
            // 
            this.customerCodeTextBox.Location = new System.Drawing.Point(305, 16);
            this.customerCodeTextBox.Name = "customerCodeTextBox";
            this.customerCodeTextBox.Size = new System.Drawing.Size(116, 20);
            this.customerCodeTextBox.TabIndex = 1;
            this.customerCodeTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // showDataGridView
            // 
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Location = new System.Drawing.Point(56, 288);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.Size = new System.Drawing.Size(625, 150);
            this.showDataGridView.TabIndex = 3;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(305, 56);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(116, 20);
            this.customerNameTextBox.TabIndex = 1;
            this.customerNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // customerAddressTextBox
            // 
            this.customerAddressTextBox.Location = new System.Drawing.Point(305, 92);
            this.customerAddressTextBox.Name = "customerAddressTextBox";
            this.customerAddressTextBox.Size = new System.Drawing.Size(116, 20);
            this.customerAddressTextBox.TabIndex = 1;
            this.customerAddressTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // customerEmailTextBox
            // 
            this.customerEmailTextBox.Location = new System.Drawing.Point(305, 131);
            this.customerEmailTextBox.Name = "customerEmailTextBox";
            this.customerEmailTextBox.Size = new System.Drawing.Size(116, 20);
            this.customerEmailTextBox.TabIndex = 1;
            this.customerEmailTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // customerContactTextBox
            // 
            this.customerContactTextBox.Location = new System.Drawing.Point(305, 172);
            this.customerContactTextBox.Name = "customerContactTextBox";
            this.customerContactTextBox.Size = new System.Drawing.Size(116, 20);
            this.customerContactTextBox.TabIndex = 1;
            this.customerContactTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // loyaltyPointTextBox
            // 
            this.loyaltyPointTextBox.Location = new System.Drawing.Point(305, 212);
            this.loyaltyPointTextBox.Name = "loyaltyPointTextBox";
            this.loyaltyPointTextBox.Size = new System.Drawing.Size(116, 20);
            this.loyaltyPointTextBox.TabIndex = 1;
            this.loyaltyPointTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loyaltyPointTextBox);
            this.Controls.Add(this.customerContactTextBox);
            this.Controls.Add(this.customerEmailTextBox);
            this.Controls.Add(this.customerAddressTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.customerCodeTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customerCodeTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox customerAddressTextBox;
        private System.Windows.Forms.TextBox customerEmailTextBox;
        private System.Windows.Forms.TextBox customerContactTextBox;
        private System.Windows.Forms.TextBox loyaltyPointTextBox;
    }
}