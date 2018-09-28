using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CMS
{
    public static class StockModel
    {
        #region Public method
        public static SqlConnection con = new SqlConnection(@"Data Source =VISHAL-PC; Initial Catalog = master; Integrated Security = True");
        public static DataTable d;
        public static SqlDataAdapter s;
        public static int result;
        public static SqlTransaction transstock;
        #endregion

        #region Readdata
        public static DataTable Read()
        {
            try
            {
                con.Open();
                 s = new SqlDataAdapter(@"Select id as ID,productname as ProductName,quantity as Quantity,price as Price,(quantity*price) as Total from Stock", con);
                d = new DataTable();
                s.Fill(d);
                return d;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message,"Alert",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }
            finally { con.Close();s = null; }
        }
        #endregion

        #region Deletedata
        public static DataTable Delete(string Productname)
        {
            result = 0;
            try
            {
                con.Open();
                transstock = con.BeginTransaction();
                SqlCommand cmd = new SqlCommand(@"delete from Stock where productname='"+ Productname +"'",con,transstock);
                result = cmd.ExecuteNonQuery();
                if(result>0)
                {
                    MessageBox.Show("..Delete Successfully..","Info", MessageBoxButtons.OK); transstock.Commit();
                }
                else { MessageBox.Show("Error occured", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error); transstock.Rollback(); }
                s = new SqlDataAdapter(@"Select id as ID,productname as ProductName,quantity as Quantity,price as Price,(quantity*price) as Total from Stock", con);
                d = new DataTable();
                 s.Fill(d);
                return d;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error); transstock.Rollback();
                return null;
            }
            finally { con.Close();transstock = null;s = null; }
        }
        #endregion

        #region Updatedata
        public static DataTable Update(string Productname, int Quantity)
        {
            result = 0;
            try
            {
                con.Open();
                transstock = con.BeginTransaction();
                SqlCommand cmd = new SqlCommand(@"Update Stock set quantity = " + Quantity + " where productname='" + Productname + "'", con,transstock);
                result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    transstock.Commit();
                    MessageBox.Show("..Update Successfully..", "Info", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else {
                    transstock.Rollback();
                    MessageBox.Show("Error occured", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                s = new SqlDataAdapter(@"Select id as ID,productname as ProductName,quantity as Quantity,price as Price,(quantity*price) as Total from Stock", con);
                d = new DataTable();
                s.Fill(d);
                return d;
            }
            catch (Exception e)
            {
                MessageBox.Show("..Error occured while updation..", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error); transstock.Rollback();
                return null;
            }
            finally { con.Close(); transstock = null;s = null; }
        }
        #endregion

        #region Adddata
        public static bool Add(string Productname,int Quantity,int price)
        {
            result = 0;
            con.Open();
            try
            {
                SqlCommand cmd2 = new SqlCommand(@"select quantity from stock where productname='" + Productname + "'", con);
                result = (int)cmd2.ExecuteScalar();
                con.Close();
                con.Open();
                transstock = con.BeginTransaction();
                SqlCommand cmd = new SqlCommand(@"Update Stock set quantity = " + (Quantity + result) + " where productname='" + Productname + "'", con, transstock);
                int result2 = cmd.ExecuteNonQuery();
                if (result2 == 1) { transstock.Commit(); return true; }
                else { transstock.Rollback(); return false; }
            }
            catch(Exception st)
            {
                transstock=null;
                transstock = con.BeginTransaction();
                try
                {
                    SqlCommand cmd = new SqlCommand(@"insert into stock values ( '" + Productname + "' , " + Quantity + "," + price + " )", con, transstock);
                    result = cmd.ExecuteNonQuery();
                    if (result == 1) { transstock.Commit(); return true; }
                    else { transstock.Rollback(); return false; }
                }
                catch (Exception e) { MessageBox.Show(e.Message); transstock.Rollback(); return false; }
            }
            finally { con.Close();transstock = null; }
        }

        #endregion

    }
}
