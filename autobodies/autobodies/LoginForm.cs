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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dc = new DataClasses1DataContext())
            {
                try
                {
                    int staffId;
                    int.TryParse(txtLoginID.Text, out staffId);

                    var adminuser = (from au in dc.tblStaffs
                                     where (staffId == au.StaffID)
                                     select au).Single();

                    if (adminuser.IsAdmin && txtPassWord !=null)
                    {
                        
                        adminform af = new adminform();
                        af.txtYourId.Text = staffId.ToString();
                        af.Show();

                    }
                    else if (!adminuser.IsAdmin && txtPassWord != null)
                    {
                        mechanicForm mf = new mechanicForm();
                        mf.txtYourId.Text = staffId.ToString();
                        mf.Show();
                    }
                    else if (txtLoginID.Text == "10000")
                    {
                        adminform af = new adminform();
                        af.txtYourId.Text = staffId.ToString();
                        af.Show();
                    }
                    else
                    {
                        MessageBox.Show("You have not entered correct Details");
                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("That is not a valid ID Or Password");
                }
            }

    }     
        
        
        // TRIED HERE TO SET UP A HASHING SERVICE


        //private bool CheckUser(string user, string pass)
        //{
        //    using (DataClasses1DataContext dbConn = new DataClasses1DataContext())
        //    {


        //        var id = from i in dbConn.TblLogins
        //                 where i.Id.ToString() == txtID.Text
        //                 select i.Id;

        //        var passw = from p in dbConn.TblLogins
        //                    where p.Id.ToString() == txtID.Text
        //                    select p.password;

        //        if (id.ToString() == txtID.Text && passw.ToString() == txtPassWord.Text )
        //        {
        //            return true;

        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }



        private void LoginForm_Load(object sender, EventArgs e)
        {
            


        }
    }
}


    
