using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autobodies
{
    public partial class AddJobForm : Form
    {
        DataClasses1DataContext dbconn = new DataClasses1DataContext();

        public AddJobForm()
        {
            InitializeComponent();
        }

        private void AddJobForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("To edit an item: select it on the data grid view and then edit in the text boxes");
            using (DataClasses1DataContext dbcon = new DataClasses1DataContext())
            {

                cboJobType.DataSource = (from jt in dbcon.TblJobDetails
                                         select jt.JobType).Distinct().ToList();

                cboBookingMethod.DataSource = (from bm in dbcon.TblJobs
                                               select bm.BookingMethod).Distinct().ToList();

                cboPaymentMethod.DataSource = (from bm in dbcon.TblJobs
                                               select bm.PaymentMethod).Distinct().ToList();
            }

            dgvJobs.AutoGenerateColumns = false;


            dgvJobs.ColumnCount = 6;

            dgvJobs.Columns[0].HeaderText = "VehicleId";
            dgvJobs.Columns[0].DataPropertyName = "VehicleId";

            dgvJobs.Columns[1].HeaderText = "BookingMethod";
            dgvJobs.Columns[1].DataPropertyName = "BookingMethod";

            dgvJobs.Columns[2].HeaderText = "JobType";
            dgvJobs.Columns[2].DataPropertyName = "JobType";

            dgvJobs.Columns[3].HeaderText = "StartDate";
            dgvJobs.Columns[3].DataPropertyName = "StartDate";

            dgvJobs.Columns[4].HeaderText = "Staff Name";
            dgvJobs.Columns[4].DataPropertyName = "name";

            dgvJobs.Columns[5].HeaderText = "StaffId";
            dgvJobs.Columns[5].DataPropertyName = "staffId";

            PrimeGrid();
        }

        private void PrimeGrid()
        {
            using (DataClasses1DataContext dbcon = new DataClasses1DataContext())
            {
                int id;
                int.TryParse(txtYourId.Text, out id);

                var adminuser = (from au in dbcon.tblStaffs
                                 where (id == au.StaffID)
                                 select au).Single();

                if (adminuser.IsAdmin)
                {

                    dgvJobs.DataSource = null;

                    var jobs = (from jd in dbcon.TblJobDetails
                                join j in dbcon.TblJobs on jd.JobId equals j.JobId
                                join s in dbcon.tblStaffs on j.StaffId equals s.StaffID

                                select new
                                {
                                    jd.JobId,
                                    jd.JobType,
                                    jd.StartDate,
                                    j.BookingMethod,
                                    jd.VehicleId,
                                    s.name,
                                    s.StaffID
                                });

                    dgvJobs.DataSource = jobs;
                }
            }
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int vehicleId, staffid;
                int.TryParse(txtVehicleId.Text, out vehicleId);
                int.TryParse(txtVehicleId.Text, out staffid);
                string jobType = cboJobType.SelectedItem.ToString();
                string bookingmethod = cboBookingMethod.SelectedItem.ToString();
                string paymentmethod = cboPaymentMethod.SelectedItem.ToString();
                string startDate = dtpStartDate.ToString();
                string endDate = dtpEndDate.ToString();


                Accessor.InsertJob(vehicleId, staffid, jobType, bookingmethod, paymentmethod, startDate, endDate);
                txtVehicleId.Text = "";
                txtStaffId.Text = "";

                MessageBox.Show("Job entered correctly");
                PrimeGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("not entered correctly");
            }

            //using (DataClasses1DataContext dbCon = new DataClasses1DataContext())
            //{
            //    try
            //    {
            //        TblJobDetail tourOp = new TblJobDetail
            //        {
            //            JobType = cboJobType.SelectedItem.ToString(),
            //            VehicleId = int.Parse(txtVehicleId.Text),
            //            StartDate = dtpStartDate.ToString(),
            //            EndDate = dtpEndDate.ToString()
            //        };

            //        TblJob j = new TblJob
            //        {
            //            StaffId = int.Parse(txtStaffId.Text),
            //            BookingMethod = cboBookingMethod.SelectedItem.ToString(),
            //           PaymentMethod = cboPaymentMethod.SelectedItem.ToString()
            //        };

            //        dbCon.TblJobs.InsertOnSubmit(j);
            //        dbCon.TblJobDetails.InsertOnSubmit(tourOp);
            //        dbCon.SubmitChanges();
            //        DialogResult = DialogResult.OK;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //        DialogResult = DialogResult.Cancel;
            //    }



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            using (DataClasses1DataContext dc = new DataClasses1DataContext())
            {
                int jobid = int.Parse(txtJobId.Text);
                var matchedjobDetail = (from c in dc.TblJobDetails
                                       where c.JobId == jobid
                                       select c).SingleOrDefault();

                var matchedjob = (from c in dc.TblJobs
                                        where c.JobId == jobid
                                        select c).SingleOrDefault();

                try
                {
                    dc.TblJobDetails.DeleteOnSubmit(matchedjobDetail);
                    dc.TblJobs.DeleteOnSubmit(matchedjob);
                    dc.SubmitChanges();
                    PrimeGrid();
                }
                catch (Exception)
                {
                    MessageBox.Show("You have to enter a valid Vehicle Id");
                }
                
            }

           
        }

        private void btnEditJob_Click(object sender, EventArgs e)
        {
            int rowIndex = GetCurrentIndex();

            int selectedVehicleId = GetVehicleID(rowIndex);

            var jobOpToUpdate = (from jds in dbconn.TblJobDetails
                                 join j in dbconn.TblJobs on jds.JobId equals j.JobId
                                  where jds.JobId == selectedVehicleId
                                 select jds).First();

            if (jobOpToUpdate != null)
            {
                string originaljobType= jobOpToUpdate.JobType;
                DateTime originalstartDate = jobOpToUpdate.StartDate;
                DateTime originalendDate = jobOpToUpdate.EndDate;


                //jobOpToUpdate.JobType = "abc";
                //jobOpToUpdate.StartDate = Convert.ToString(dgvJobs.Rows[rowIndex].Cells[3].Value);
                //jobOpToUpdate.EndDate = Convert.ToString(dgvJobs.Rows[rowIndex].Cells[4].Value);
                ////jobOpToUpdate.JobType = Convert.ToString(dgvJobs.Rows[rowIndex].Cells[2].Value);
                //jobOpToUpdate.StartDate = Convert.ToString(dgvJobs.Rows[rowIndex].Cells[3].Value);
                //jobOpToUpdate.EndDate = Convert.ToString(dgvJobs.Rows[rowIndex].Cells[4].Value);
                jobOpToUpdate.StartDate = dtpStartDate.Value;
                jobOpToUpdate.EndDate = dtpEndDate.Value;
                jobOpToUpdate.JobType = cboJobType.SelectedItem.ToString();



                try
                {
                    dbconn.SubmitChanges();
                    MessageBox.Show("Changes Made Succesfully");

                }
                catch (Exception)
                {
                    MessageBox.Show("Enter the updates into the text box with all fields completed");
                    
                }
            }

            PrimeGrid();
        }

        private int GetVehicleID(int rowIndex)
        {
            return Convert.ToInt32(dgvJobs.Rows[rowIndex].Cells[0].Value);
        }

        private int GetCurrentIndex()
        {
            int rowIndex = dgvJobs.CurrentRow.Index;

            return rowIndex;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


