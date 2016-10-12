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
    public partial class AddVehicleForm : Form
    {
        DataClasses1DataContext dbCon = new DataClasses1DataContext();
        public AddVehicleForm()
        {
            InitializeComponent();
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                int customerId;
                string make = txtMake.Text;
                string model = txtModel.Text;
                string reg = txtReg.Text;
                int.TryParse(txtCustomerId.Text, out customerId);

                Accessor.InsertEditVehicle(make, model, reg, customerId);

                txtMake.Text = "";
                txtModel.Text = "";
                txtCustomerId.Text = "";
                txtReg.Text = "";
                txtMake.Text = "";
                PrimeGrid();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void AddVehicleForm_Load(object sender, EventArgs e)
        {
            dgvVehicles.AutoGenerateColumns = false;
            dgvVehicles.ColumnCount = 4;
            dgvVehicles.Columns[0].HeaderText = "VehicleID";
            dgvVehicles.Columns[0].DataPropertyName = "VehicleId";
            dgvVehicles.Columns[1].HeaderText = "Make";
            dgvVehicles.Columns[1].DataPropertyName = "Make";
            dgvVehicles.Columns[2].HeaderText = "Model";
            dgvVehicles.Columns[2].DataPropertyName = "Model";
            dgvVehicles.Columns[3].HeaderText = "CustomerId";
            dgvVehicles.Columns[3].DataPropertyName = "CustomerId";
            PrimeGrid();
            
        }

        private void PrimeGrid()
        {
            int id;
            int.TryParse(txtYourId.Text, out id);

            var adminuser = (from au in dbCon.tblStaffs
                             where (id == au.StaffID)
                             select au).Single();

            if (adminuser.IsAdmin)
            {
                dgvVehicles.DataSource = null;

                var cars = from c in dbCon.TblVehicles
                           select c;

                dgvVehicles.DataSource = cars;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
