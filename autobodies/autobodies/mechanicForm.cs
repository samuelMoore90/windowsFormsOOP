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
    public partial class mechanicForm : Form
    {
        public mechanicForm()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm ac = new AddCustomerForm();
            ac.txtYourId.Text = txtYourId.Text;
            ac.Show();
        }

        private void mechanicForm_Load(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dbcon = new DataClasses1DataContext())
            {
                var yourjobs = (from job in dbcon.TblJobs
                                join jd in dbcon.TblJobDetails on job.JobId equals jd.JobId
                                join s in dbcon.tblStaffs on job.StaffId equals s.StaffID
                                where job.StaffId == int.Parse(txtYourId.Text)
                                orderby jd.EndDate ascending
                                select new
                                {
                                    job.StaffId,
                                    job.JobId,
                                    jd.EndDate,
                                    jd.JobType,
                                    s.name

                                }).ToList();

                dataGridView1.DataSource = yourjobs;




            }

    }

    

        private void button1_Click(object sender, EventArgs e)
        {
            AddVehicleForm av = new AddVehicleForm();
            av.txtYourId.Text = txtYourId.Text;
            av.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddJobForm aj = new AddJobForm();
            aj.txtYourId.Text = txtYourId.Text;
            aj.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
