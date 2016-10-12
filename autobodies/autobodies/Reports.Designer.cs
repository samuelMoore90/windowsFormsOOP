namespace autobodies
{
    partial class Reports
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
            this.dgvreport1 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.btnAllJobs = new System.Windows.Forms.Button();
            this.txtMechanic = new System.Windows.Forms.TextBox();
            this.lblJobsin2weeks = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreport1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvreport1
            // 
            this.dgvreport1.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvreport1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvreport1.Location = new System.Drawing.Point(12, 211);
            this.dgvreport1.Name = "dgvreport1";
            this.dgvreport1.Size = new System.Drawing.Size(963, 306);
            this.dgvreport1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(12, 163);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(99, 29);
            this.txtSearch.TabIndex = 1;
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCustomerSearch.Location = new System.Drawing.Point(131, 163);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(179, 33);
            this.btnCustomerSearch.TabIndex = 2;
            this.btnCustomerSearch.Text = "Customer History";
            this.btnCustomerSearch.UseVisualStyleBackColor = true;
            this.btnCustomerSearch.Click += new System.EventHandler(this.btnCustomerSearch_Click);
            // 
            // btnAllJobs
            // 
            this.btnAllJobs.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAllJobs.Location = new System.Drawing.Point(330, 165);
            this.btnAllJobs.Name = "btnAllJobs";
            this.btnAllJobs.Size = new System.Drawing.Size(108, 33);
            this.btnAllJobs.TabIndex = 3;
            this.btnAllJobs.Text = "All Jobs";
            this.btnAllJobs.UseVisualStyleBackColor = true;
            this.btnAllJobs.Click += new System.EventHandler(this.btnAllJobs_Click);
            // 
            // txtMechanic
            // 
            this.txtMechanic.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtMechanic.Location = new System.Drawing.Point(876, 122);
            this.txtMechanic.Name = "txtMechanic";
            this.txtMechanic.Size = new System.Drawing.Size(99, 29);
            this.txtMechanic.TabIndex = 4;
            // 
            // lblJobsin2weeks
            // 
            this.lblJobsin2weeks.AutoSize = true;
            this.lblJobsin2weeks.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblJobsin2weeks.Location = new System.Drawing.Point(536, 122);
            this.lblJobsin2weeks.Name = "lblJobsin2weeks";
            this.lblJobsin2weeks.Size = new System.Drawing.Size(327, 23);
            this.lblJobsin2weeks.TabIndex = 5;
            this.lblJobsin2weeks.Text = "Jobs in a two week period for mechanic id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(536, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtpStartDate.Location = new System.Drawing.Point(594, 157);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(287, 29);
            this.dtpStartDate.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(887, 157);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 35);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(887, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 37);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "Autojalopy Motors";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 529);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblJobsin2weeks);
            this.Controls.Add(this.txtMechanic);
            this.Controls.Add(this.btnAllJobs);
            this.Controls.Add(this.btnCustomerSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvreport1);
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dgvreport1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvreport1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCustomerSearch;
        private System.Windows.Forms.Button btnAllJobs;
        private System.Windows.Forms.TextBox txtMechanic;
        private System.Windows.Forms.Label lblJobsin2weeks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
    }
}