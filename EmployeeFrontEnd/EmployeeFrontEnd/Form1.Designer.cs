namespace EmployeeFrontEnd
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
            this.GroupName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxBankAccNo = new System.Windows.Forms.TextBox();
            this.textBoxIRDNo = new System.Windows.Forms.TextBox();
            this.textBoxPayPerHr = new System.Windows.Forms.TextBox();
            this.textBoxHoursWorked = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelBankAccNo = new System.Windows.Forms.Label();
            this.labelIRDNo = new System.Windows.Forms.Label();
            this.labelPayPerHr = new System.Windows.Forms.Label();
            this.labelHoursWorked = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GroupName
            // 
            this.GroupName.AutoSize = true;
            this.GroupName.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupName.Location = new System.Drawing.Point(13, 13);
            this.GroupName.Name = "GroupName";
            this.GroupName.Size = new System.Drawing.Size(270, 45);
            this.GroupName.TabIndex = 0;
            this.GroupName.Text = "Group Formation";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(21, 62);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(24, 79);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(346, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(24, 118);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(346, 20);
            this.textBoxAge.TabIndex = 3;
            this.textBoxAge.TextChanged += new System.EventHandler(this.textBoxAge_TextChanged);
            // 
            // textBoxBankAccNo
            // 
            this.textBoxBankAccNo.Location = new System.Drawing.Point(24, 157);
            this.textBoxBankAccNo.Name = "textBoxBankAccNo";
            this.textBoxBankAccNo.Size = new System.Drawing.Size(346, 20);
            this.textBoxBankAccNo.TabIndex = 4;
            this.textBoxBankAccNo.TextChanged += new System.EventHandler(this.textBoxBankAccNo_TextChanged);
            // 
            // textBoxIRDNo
            // 
            this.textBoxIRDNo.Location = new System.Drawing.Point(24, 196);
            this.textBoxIRDNo.Name = "textBoxIRDNo";
            this.textBoxIRDNo.Size = new System.Drawing.Size(346, 20);
            this.textBoxIRDNo.TabIndex = 5;
            this.textBoxIRDNo.TextChanged += new System.EventHandler(this.textBoxIRDNo_TextChanged);
            // 
            // textBoxPayPerHr
            // 
            this.textBoxPayPerHr.Location = new System.Drawing.Point(24, 235);
            this.textBoxPayPerHr.Name = "textBoxPayPerHr";
            this.textBoxPayPerHr.Size = new System.Drawing.Size(346, 20);
            this.textBoxPayPerHr.TabIndex = 6;
            this.textBoxPayPerHr.TextChanged += new System.EventHandler(this.textBoxPayPerHr_TextChanged);
            // 
            // textBoxHoursWorked
            // 
            this.textBoxHoursWorked.Location = new System.Drawing.Point(24, 274);
            this.textBoxHoursWorked.Name = "textBoxHoursWorked";
            this.textBoxHoursWorked.Size = new System.Drawing.Size(346, 20);
            this.textBoxHoursWorked.TabIndex = 7;
            this.textBoxHoursWorked.TextChanged += new System.EventHandler(this.textBoxHoursWorked_TextChanged);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(21, 102);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(29, 13);
            this.labelAge.TabIndex = 10;
            this.labelAge.Text = "Age:";
            this.labelAge.Click += new System.EventHandler(this.labelAge_Click);
            // 
            // labelBankAccNo
            // 
            this.labelBankAccNo.AutoSize = true;
            this.labelBankAccNo.Location = new System.Drawing.Point(21, 141);
            this.labelBankAccNo.Name = "labelBankAccNo";
            this.labelBankAccNo.Size = new System.Drawing.Size(95, 13);
            this.labelBankAccNo.TabIndex = 11;
            this.labelBankAccNo.Text = "Bank Account No:";
            this.labelBankAccNo.Click += new System.EventHandler(this.labelBankAccNo_Click);
            // 
            // labelIRDNo
            // 
            this.labelIRDNo.AutoSize = true;
            this.labelIRDNo.Location = new System.Drawing.Point(21, 180);
            this.labelIRDNo.Name = "labelIRDNo";
            this.labelIRDNo.Size = new System.Drawing.Size(46, 13);
            this.labelIRDNo.TabIndex = 12;
            this.labelIRDNo.Text = "IRD No:";
            this.labelIRDNo.Click += new System.EventHandler(this.labelIRDNo_Click);
            // 
            // labelPayPerHr
            // 
            this.labelPayPerHr.AutoSize = true;
            this.labelPayPerHr.Location = new System.Drawing.Point(21, 219);
            this.labelPayPerHr.Name = "labelPayPerHr";
            this.labelPayPerHr.Size = new System.Drawing.Size(48, 13);
            this.labelPayPerHr.TabIndex = 13;
            this.labelPayPerHr.Text = "Pay (Hr):";
            this.labelPayPerHr.Click += new System.EventHandler(this.labelPayPerHr_Click);
            // 
            // labelHoursWorked
            // 
            this.labelHoursWorked.AutoSize = true;
            this.labelHoursWorked.Location = new System.Drawing.Point(21, 258);
            this.labelHoursWorked.Name = "labelHoursWorked";
            this.labelHoursWorked.Size = new System.Drawing.Size(79, 13);
            this.labelHoursWorked.TabIndex = 14;
            this.labelHoursWorked.Text = "Hours Worked:";
            this.labelHoursWorked.Click += new System.EventHandler(this.labelHoursWorked_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSubmit.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(24, 394);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(144, 44);
            this.buttonSubmit.TabIndex = 15;
            this.buttonSubmit.Text = "Submit Details";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.Location = new System.Drawing.Point(529, 79);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(0, 23);
            this.labelDetails.TabIndex = 16;
            this.labelDetails.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelHoursWorked);
            this.Controls.Add(this.labelPayPerHr);
            this.Controls.Add(this.labelIRDNo);
            this.Controls.Add(this.labelBankAccNo);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textBoxHoursWorked);
            this.Controls.Add(this.textBoxPayPerHr);
            this.Controls.Add(this.textBoxIRDNo);
            this.Controls.Add(this.textBoxBankAccNo);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.GroupName);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Employee Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GroupName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxBankAccNo;
        private System.Windows.Forms.TextBox textBoxIRDNo;
        private System.Windows.Forms.TextBox textBoxPayPerHr;
        private System.Windows.Forms.TextBox textBoxHoursWorked;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelBankAccNo;
        private System.Windows.Forms.Label labelIRDNo;
        private System.Windows.Forms.Label labelPayPerHr;
        private System.Windows.Forms.Label labelHoursWorked;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelDetails;
    }
}

