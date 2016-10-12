using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

namespace autobodies
{
    public partial class adminform : Form
    {
        
        public adminform()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm ac = new AddCustomerForm();
            ac.txtYourId.Text = txtYourId.Text;
            ac.Show();
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            AddVehicleForm ac = new AddVehicleForm();
            ac.txtYourId.Text = txtYourId.Text;
            ac.Show();
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            AddJobForm aj = new AddJobForm();
            aj.txtYourId.Text = txtYourId.Text;
            aj.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports r = new Reports();
            r.Show();
            
        }

        private void btnEmailList_Click(object sender, EventArgs e)
        {

            using (StreamWriter sw = new StreamWriter("C:\\Users\\samue\\Desktop\\autobodies\\emailingList.txt"))
            {

                using (DataClasses1DataContext dbcon = new DataClasses1DataContext())
                {
                    var emailList = (from em in dbcon.tblCustomers
                                     select em.email).ToList();

                    foreach (var email in emailList)
                    {
                        sw.Write(email + ",");
                    }
                    sw.Close();
                    MessageBox.Show("Email list created successfully");

                }
            }
            }

        private void adminform_Load(object sender, EventArgs e)
        {
            //string userID = System.DirectoryServices.AccountManagement.UserPrincipal.Current.DisplayName;
            //MessageBox.Show(userID);


        }

        private void btnGenerateSmsList_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\samue\\Desktop\\autobodies\\smsList.txt"))
            {

                using (DataClasses1DataContext dbcon = new DataClasses1DataContext())
                {
                    var phoneList = (from p in dbcon.tblCustomers
                                     select p.phone).ToList();

                    foreach (var phone in phoneList)
                    {
                        sw.Write(phone + ",");
                    }
                    sw.Close();
                    MessageBox.Show("Sms list created successfully");

                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

