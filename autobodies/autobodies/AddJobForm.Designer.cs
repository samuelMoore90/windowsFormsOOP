namespace autobodies
{
    partial class AddJobForm
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
            this.cboJobType = new System.Windows.Forms.ComboBox();
            this.lblJobType = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblBookingMethod = new System.Windows.Forms.Label();
            this.lblStaffId = new System.Windows.Forms.Label();
            this.cboBookingMethod = new System.Windows.Forms.ComboBox();
            this.cboPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancell = new System.Windows.Forms.Button();
            this.txtVehicleId = new System.Windows.Forms.TextBox();
            this.lblVehicleId = new System.Windows.Forms.Label();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtJobId = new System.Windows.Forms.TextBox();
            this.btnEditJob = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtYourId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // cboJobType
            // 
            this.cboJobType.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.cboJobType.FormattingEnabled = true;
            this.cboJobType.Items.AddRange(new object[] {
            "Full Service",
            "Minor Service",
            "Pre-NCT Inspection",
            "Replace Tyres",
            "Vehicle Recovery",
            "Windscreen Replacement",
            "Timing Belt Replacement",
            "CV-Boot Replacement",
            "Axle Realignment",
            "Body-shop Repair",
            "Engine Repair",
            "General Repair"});
            this.cboJobType.Location = new System.Drawing.Point(167, 156);
            this.cboJobType.Name = "cboJobType";
            this.cboJobType.Size = new System.Drawing.Size(154, 31);
            this.cboJobType.TabIndex = 0;
            // 
            // lblJobType
            // 
            this.lblJobType.AutoSize = true;
            this.lblJobType.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblJobType.Location = new System.Drawing.Point(7, 159);
            this.lblJobType.Name = "lblJobType";
            this.lblJobType.Size = new System.Drawing.Size(77, 23);
            this.lblJobType.TabIndex = 1;
            this.lblJobType.Text = "JobType";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPaymentMethod.Location = new System.Drawing.Point(8, 241);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(137, 23);
            this.lblPaymentMethod.TabIndex = 5;
            this.lblPaymentMethod.Text = "Payment Method";
            // 
            // lblBookingMethod
            // 
            this.lblBookingMethod.AutoSize = true;
            this.lblBookingMethod.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblBookingMethod.Location = new System.Drawing.Point(10, 198);
            this.lblBookingMethod.Name = "lblBookingMethod";
            this.lblBookingMethod.Size = new System.Drawing.Size(135, 23);
            this.lblBookingMethod.TabIndex = 6;
            this.lblBookingMethod.Text = "Booking Method";
            // 
            // lblStaffId
            // 
            this.lblStaffId.AutoSize = true;
            this.lblStaffId.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblStaffId.Location = new System.Drawing.Point(14, 118);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.Size = new System.Drawing.Size(58, 23);
            this.lblStaffId.TabIndex = 7;
            this.lblStaffId.Text = "StaffId";
            // 
            // cboBookingMethod
            // 
            this.cboBookingMethod.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.cboBookingMethod.FormattingEnabled = true;
            this.cboBookingMethod.Location = new System.Drawing.Point(167, 198);
            this.cboBookingMethod.Name = "cboBookingMethod";
            this.cboBookingMethod.Size = new System.Drawing.Size(154, 31);
            this.cboBookingMethod.TabIndex = 8;
            // 
            // cboPaymentMethod
            // 
            this.cboPaymentMethod.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.cboPaymentMethod.FormattingEnabled = true;
            this.cboPaymentMethod.Location = new System.Drawing.Point(167, 238);
            this.cboPaymentMethod.Name = "cboPaymentMethod";
            this.cboPaymentMethod.Size = new System.Drawing.Size(154, 31);
            this.cboPaymentMethod.TabIndex = 9;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblStartDate.Location = new System.Drawing.Point(8, 283);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(83, 23);
            this.lblStartDate.TabIndex = 10;
            this.lblStartDate.Text = "Start Date";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl.Location = new System.Drawing.Point(8, 316);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(78, 23);
            this.lbl.TabIndex = 11;
            this.lbl.Text = "End Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtpStartDate.Location = new System.Drawing.Point(97, 283);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(224, 29);
            this.dtpStartDate.TabIndex = 12;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtpEndDate.Location = new System.Drawing.Point(97, 316);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(224, 29);
            this.dtpEndDate.TabIndex = 13;
            // 
            // txtStaffId
            // 
            this.txtStaffId.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtStaffId.Location = new System.Drawing.Point(167, 118);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(154, 29);
            this.txtStaffId.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(29, 347);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 51);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "ADD JOB";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancell
            // 
            this.btnCancell.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCancell.Location = new System.Drawing.Point(184, 351);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(137, 42);
            this.btnCancell.TabIndex = 16;
            this.btnCancell.Text = "Cancel";
            this.btnCancell.UseVisualStyleBackColor = true;
            this.btnCancell.Click += new System.EventHandler(this.btnCancell_Click);
            // 
            // txtVehicleId
            // 
            this.txtVehicleId.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtVehicleId.Location = new System.Drawing.Point(167, 83);
            this.txtVehicleId.Name = "txtVehicleId";
            this.txtVehicleId.Size = new System.Drawing.Size(154, 29);
            this.txtVehicleId.TabIndex = 18;
            // 
            // lblVehicleId
            // 
            this.lblVehicleId.AutoSize = true;
            this.lblVehicleId.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblVehicleId.Location = new System.Drawing.Point(7, 83);
            this.lblVehicleId.Name = "lblVehicleId";
            this.lblVehicleId.Size = new System.Drawing.Size(83, 23);
            this.lblVehicleId.TabIndex = 17;
            this.lblVehicleId.Text = "Vehicle Id";
            // 
            // dgvJobs
            // 
            this.dgvJobs.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Location = new System.Drawing.Point(327, 83);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.Size = new System.Drawing.Size(589, 419);
            this.dgvJobs.TabIndex = 19;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(29, 457);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 45);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtJobId
            // 
            this.txtJobId.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtJobId.Location = new System.Drawing.Point(167, 465);
            this.txtJobId.Name = "txtJobId";
            this.txtJobId.Size = new System.Drawing.Size(122, 29);
            this.txtJobId.TabIndex = 21;
            // 
            // btnEditJob
            // 
            this.btnEditJob.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEditJob.Location = new System.Drawing.Point(29, 404);
            this.btnEditJob.Name = "btnEditJob";
            this.btnEditJob.Size = new System.Drawing.Size(116, 47);
            this.btnEditJob.TabIndex = 22;
            this.btnEditJob.Text = "Edit JOB";
            this.btnEditJob.UseVisualStyleBackColor = true;
            this.btnEditJob.Click += new System.EventHandler(this.btnEditJob_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(799, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 35);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtYourId
            // 
            this.txtYourId.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtYourId.Location = new System.Drawing.Point(78, 47);
            this.txtYourId.Name = "txtYourId";
            this.txtYourId.ReadOnly = true;
            this.txtYourId.Size = new System.Drawing.Size(74, 29);
            this.txtYourId.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "your Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "Autojalopy Motors";
            // 
            // AddJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 514);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYourId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEditJob);
            this.Controls.Add(this.txtJobId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvJobs);
            this.Controls.Add(this.txtVehicleId);
            this.Controls.Add(this.lblVehicleId);
            this.Controls.Add(this.btnCancell);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtStaffId);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.cboPaymentMethod);
            this.Controls.Add(this.cboBookingMethod);
            this.Controls.Add(this.lblStaffId);
            this.Controls.Add(this.lblBookingMethod);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblJobType);
            this.Controls.Add(this.cboJobType);
            this.Name = "AddJobForm";
            this.Text = "AddJobForm";
            this.Load += new System.EventHandler(this.AddJobForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboJobType;
        private System.Windows.Forms.Label lblJobType;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblBookingMethod;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.ComboBox cboBookingMethod;
        private System.Windows.Forms.ComboBox cboPaymentMethod;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancell;
        private System.Windows.Forms.TextBox txtVehicleId;
        private System.Windows.Forms.Label lblVehicleId;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtJobId;
        private System.Windows.Forms.Button btnEditJob;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.TextBox txtYourId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}