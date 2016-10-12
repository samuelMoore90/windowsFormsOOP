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
    public partial class AddCustomerForm : Form
    {
        DataClasses1DataContext dbCon = new DataClasses1DataContext();
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {

                string name = txtFirstName.Text;
                string address = txtAddress.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;

                Accessor.InsertOrUpdateCustomer(name, address, email, phone);
                resetTbs();
                MessageBox.Show($"{name} was succesfully added");
                PrimeGrid();


            }
            catch (Exception)
            {
                MessageBox.Show("no Car exists for that ID");
            }
         
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
          
            resetTbs();
            this.Visible = false;
        }

        public void resetTbs()
        {

            txtFirstName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }

        public void AddCustomerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.ColumnCount = 4;

            dataGridView1.Columns[0].HeaderText = "Customer Name";
            dataGridView1.Columns[0].DataPropertyName = "name";

            dataGridView1.Columns[1].HeaderText = "address";
            dataGridView1.Columns[1].DataPropertyName = "address";

            dataGridView1.Columns[2].HeaderText = "email";
            dataGridView1.Columns[2].DataPropertyName = "email";

            dataGridView1.Columns[3].HeaderText = "phone";
            dataGridView1.Columns[3].DataPropertyName = "phone";

            PrimeGrid();
               
        }



        private void PrimeGrid()
        {

            using (DataClasses1DataContext dc = new DataClasses1DataContext())
            {
                int id;
                int.TryParse(txtYourId.Text, out id);

                var adminuser = (from au in dc.tblStaffs
                                 where (id == au.StaffID)
                                 select au).Single();

                if (adminuser.IsAdmin)
                {
                    dataGridView1.DataSource = null;

                    var customers = from c in dbCon.tblCustomers
                                    select c;

                    dataGridView1.DataSource = customers;
                }
            }
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}

