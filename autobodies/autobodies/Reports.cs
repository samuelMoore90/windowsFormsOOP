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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            dgvreport1.DataSource = null;
            int custId;
            int.TryParse(txtSearch.Text, out custId);

            using(DataClasses1DataContext dbcon = new DataClasses1DataContext())
            {
               try
                {
                    var results = (from c in dbcon.tblCustomers
                                   join v in dbcon.TblVehicles on c.CustomerId equals v.CustomerId
                                   join j in dbcon.TblJobDetails on v.VehicleId equals j.VehicleId
                                   orderby j.StartDate 
                                   where c.CustomerId == custId
                                   select new
                                   {
                                       c.CustomerId,
                                       c.name,
                                       v.Make,
                                       v.Model,
                                       v.Registration,
                                       j.JobType,
                                       j.StartDate
                                   }).ToList();

                    dgvreport1.DataSource = results;
                }
                catch(Exception)
                {
                    MessageBox.Show("Enter A valid customer Id");
                }
            }
        }

        private void btnAllJobs_Click(object sender, EventArgs e)
        {
            using(DataClasses1DataContext dbcon = new DataClasses1DataContext())
            {
                // I was getting errors here when switching between the buttons . the columns wern't reassigning themselves properly
                //dgvreport1.DataSource = null;
                //dgvreport1.AutoGenerateColumns = false;


                //dgvreport1.ColumnCount = 5;

                //dgvreport1.Columns[0].HeaderText = "JobId";
                //dgvreport1.Columns[0].DataPropertyName = "JobId";

                //dgvreport1.Columns[1].HeaderText = "EndDate";
                //dgvreport1.Columns[1].DataPropertyName = "EndDate";

                //dgvreport1.Columns[2].HeaderText = "JobType";
                //dgvreport1.Columns[2].DataPropertyName = "JobType";

                //dgvreport1.Columns[3].HeaderText = "StaffId";
                //dgvreport1.Columns[3].DataPropertyName = "StaffId";

                //dgvreport1.Columns[4].HeaderText = "Customer Name";
                //dgvreport1.Columns[4].DataPropertyName = "name";

                var results = (from c in dbcon.tblCustomers
                               join v in dbcon.TblVehicles on c.CustomerId equals v.CustomerId
                               join j in dbcon.TblJobDetails on v.VehicleId equals j.VehicleId
                               join job in dbcon.TblJobs on j.JobId equals job.JobId
                               join s in dbcon.tblStaffs on job.StaffId equals s.StaffID
                               orderby s.name
                               
                               select new
                               {
                                   j.JobId,
                                   j.EndDate,
                                   j.JobType,
                                   s.StaffID,
                                  c.name,
                                   
                               }).ToList();
               

                dgvreport1.DataSource = results;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int mechanicId;
            int.TryParse(txtMechanic.Text, out mechanicId);

            DateTime start = dtpStartDate.Value;
            DateTime end = start.AddDays(14);


            //string start = start.ToString();
            //string enddate = end.ToString();





            //MessageBox.Show($" 1 : {date1}, 2: {date2}");


            using (DataClasses1DataContext dbcon = new DataClasses1DataContext())
            {
                dgvreport1.DataSource = null;
                var results = (from job in dbcon.TblJobs
                               join jd in dbcon.TblJobDetails on job.JobId equals jd.JobId
                               join s in dbcon.tblStaffs on job.StaffId equals s.StaffID
                               where job.StaffId == mechanicId
                               where jd.StartDate >= start && jd.EndDate <= end
                               orderby jd.EndDate ascending
                               select new
                               {
                                   job.StaffId,
                                   job.JobId,
                                   jd.EndDate,
                                   jd.JobType,
                                   s.name

                               }).ToList();

                dgvreport1.DataSource = results;

            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
