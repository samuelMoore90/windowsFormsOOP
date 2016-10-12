using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autobodies
{
    class Accessor
    {
        public static System.Data.Linq.Table<tblCustomer> GetCustomerTable()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            return dc.GetTable<tblCustomer>();
        }
        public static System.Data.Linq.Table<tblStaff> GetStaffTable()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            return dc.GetTable<tblStaff>();
        }

        public static System.Data.Linq.Table<TblVehicle> GetVehicleTable()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            return dc.GetTable<TblVehicle>();
        }

        public static System.Data.Linq.Table<TblJobDetail> GetJobDetailTable()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            return dc.GetTable<TblJobDetail>();
        }

        public static System.Data.Linq.Table<TblJob> GetJobTable()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            return dc.GetTable<TblJob>();
        }

        public static void InsertOrUpdateCustomer(string name, string address, string email, string phone)
        {

            DataClasses1DataContext dc = new DataClasses1DataContext();

            var matchedCustomer = (from c in dc.GetTable<tblCustomer>()
                                   where c.name == name
                                   select c).FirstOrDefault();

            if (matchedCustomer == null)
            {
                try
                {
                    // create new customer record since customer ID
                    // does not exist
                    Table<tblCustomer> customers = Accessor.GetCustomerTable();
                    tblCustomer cust = new tblCustomer();

                    cust.name = name;
                    cust.address = address;
                    cust.email = email;
                    cust.phone = phone;
                  
        

                    customers.InsertOnSubmit(cust);
                    customers.Context.SubmitChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                try
                {
                    matchedCustomer.name = name;
                    matchedCustomer.address = address;
                    matchedCustomer.email = email;
                    matchedCustomer.phone = phone;
                    dc.SubmitChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

        public static void InsertEditVehicle(string make, string model, string reg, int customerid)
        {

            DataClasses1DataContext dc = new DataClasses1DataContext();

            var matchedVehicle= (from c in dc.GetTable<TblVehicle>()
                                   where c.CustomerId == customerid
                                   select c).FirstOrDefault();

            if (matchedVehicle == null)
            {
                try
                {
                    // create new car record since the vehicle doesnt exists
                    Table<TblVehicle> vehicles = Accessor.GetVehicleTable();
                    TblVehicle car = new TblVehicle();

                    car.Make = make;
                    car.Model = model;
                    car.Registration = reg;
                    car.CustomerId = customerid;

                    vehicles.InsertOnSubmit(car);
                    vehicles.Context.SubmitChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            else
            {
                try
                {
                    matchedVehicle.Make = make;
                    matchedVehicle.Model = model;
                    matchedVehicle.Registration = reg;
                   
                    dc.SubmitChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


        }

        public static void InsertJob(int vehicleid, int staffId, string jobtype, string bookingmethod, string payment, string startDate, string endDate)
        {

            DataClasses1DataContext dc = new DataClasses1DataContext();

            var matchedvehicle = (from c in dc.GetTable<TblVehicle>()
                                  where c.VehicleId == vehicleid
                                  select c).FirstOrDefault();

            var matchedStaff = (from s in dc.GetTable<tblStaff>()
                                where s.StaffID == staffId
                                select s).FirstOrDefault();

            if (matchedvehicle == null && matchedStaff == null)
            {
                try
                {

                    Table<TblJobDetail> jobdetails = Accessor.GetJobDetailTable();
                    Table<TblJob> job = Accessor.GetJobTable();

                    TblJobDetail jdet = new TblJobDetail();
                    TblJob j = new TblJob();

                    jdet.VehicleId = vehicleid;
                    jdet.StartDate = DateTime.Parse(startDate);
                    jdet.EndDate = DateTime.Parse(endDate);
                    jdet.JobType = jobtype;
                    j.BookingMethod = bookingmethod;
                    j.PaymentMethod = payment;
                    j.StaffId = staffId;

                    jobdetails.InsertOnSubmit(jdet);
                    job.InsertOnSubmit(j);
                    jobdetails.Context.SubmitChanges();
                    job.Context.SubmitChanges();


                    
                }
                catch (Exception ex)
                {
                    throw ex;
                }


            }
        }


    }
}
