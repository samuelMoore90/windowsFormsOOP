namespace autobodies
{
    partial class adminform
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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnEmailList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYourId = new System.Windows.Forms.TextBox();
            this.btnGenerateSmsList = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddCustomer.Location = new System.Drawing.Point(23, 103);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(274, 32);
            this.btnAddCustomer.TabIndex = 3;
            this.btnAddCustomer.Text = "Customers";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddVehicle.Location = new System.Drawing.Point(23, 158);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(274, 32);
            this.btnAddVehicle.TabIndex = 6;
            this.btnAddVehicle.Text = "Vehicles";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnAddJob
            // 
            this.btnAddJob.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddJob.Location = new System.Drawing.Point(23, 210);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(274, 32);
            this.btnAddJob.TabIndex = 7;
            this.btnAddJob.Text = "Jobs";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnReports.Location = new System.Drawing.Point(23, 260);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(274, 32);
            this.btnReports.TabIndex = 8;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnEmailList
            // 
            this.btnEmailList.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEmailList.Location = new System.Drawing.Point(23, 308);
            this.btnEmailList.Name = "btnEmailList";
            this.btnEmailList.Size = new System.Drawing.Size(274, 32);
            this.btnEmailList.TabIndex = 9;
            this.btnEmailList.Text = "Generate Email List";
            this.btnEmailList.UseVisualStyleBackColor = true;
            this.btnEmailList.Click += new System.EventHandler(this.btnEmailList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "your Id";
            // 
            // txtYourId
            // 
            this.txtYourId.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYourId.Location = new System.Drawing.Point(81, 51);
            this.txtYourId.Name = "txtYourId";
            this.txtYourId.ReadOnly = true;
            this.txtYourId.Size = new System.Drawing.Size(85, 22);
            this.txtYourId.TabIndex = 11;
            // 
            // btnGenerateSmsList
            // 
            this.btnGenerateSmsList.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnGenerateSmsList.Location = new System.Drawing.Point(23, 357);
            this.btnGenerateSmsList.Name = "btnGenerateSmsList";
            this.btnGenerateSmsList.Size = new System.Drawing.Size(274, 32);
            this.btnGenerateSmsList.TabIndex = 12;
            this.btnGenerateSmsList.Text = "Generate sms List";
            this.btnGenerateSmsList.UseVisualStyleBackColor = true;
            this.btnGenerateSmsList.Click += new System.EventHandler(this.btnGenerateSmsList_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(258, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 23);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Autojalopy Motors";
            // 
            // adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 401);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGenerateSmsList);
            this.Controls.Add(this.txtYourId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEmailList);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "adminform";
            this.Text = "adminform";
            this.Load += new System.EventHandler(this.adminform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnEmailList;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtYourId;
        private System.Windows.Forms.Button btnGenerateSmsList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
    }
}