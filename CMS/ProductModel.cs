using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public static class ProductModel
    {
        #region public properties
        public static SqlConnection con = new SqlConnection(@"Data Source =VISHAL-PC; Initial Catalog = master; Integrated Security = True");
        public static DataTable d;
        public static SqlCommand cmd;
        public static SqlDataAdapter s;
        public static string TargetPath = Application.StartupPath + @"\Files";
        public static SqlTransaction trans;
        public static int result;
        #endregion

        #region Readdata

        public static DataTable Read()
        {
            try
            {
                con.Open();
                s = new SqlDataAdapter(@"Select id as ID,productcode as ProductCode,productname as ProductName,quantity as Quantity,price as Price,(quantity*price) as Total,files as Files from Products", con);
                d = new DataTable();
                s.Fill(d);
                return d;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally { con.Close(); }
        }
        #endregion

        #region Adddata

        public static DataTable Add(string Productcode, string ProductName, int quantity, int price,string filename , string filepath)
        {
            try
            {
                con.Open();
            trans = con.BeginTransaction();

            if (filename == String.Empty)
            {
                cmd = new SqlCommand(@"insert into Products(productcode,productname,quantity,price) values('" + Productcode + "','" + ProductName + "'," + quantity + "," + price + ")", con, trans);
                result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    if (StockModel.Add(ProductName, quantity, price))
                    {
                        trans.Commit(); MessageBox.Show("..Add Successfully..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                         MessageBox.Show("Error occured", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error); trans.Rollback();
                    }

                }
                else { MessageBox.Show("Error occured", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error); trans.Rollback(); }
            }
            else
            {
                   string filename2 = filename.Substring(0, filename.LastIndexOf('.'));
                    string extension = filename.Substring(filename.LastIndexOf('.'),filename.Length-1);
                    filename = filename2 + DateTime.Now.Date.ToString("MM/d/h/mm/yy")+"."+extension;
                    MessageBox.Show(filename);
                cmd = new SqlCommand(@"insert into Products(productcode,productname,quantity,price,files) values('" + Productcode + "','" + ProductName + "'," + quantity + "," + price + ",'" + filename + "' )", con, trans);
                if (!System.IO.Directory.Exists(TargetPath))
                {
                    System.IO.Directory.CreateDirectory(TargetPath);
                }
                result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("..Add Successfully..", "Info", MessageBoxButtons.OK);
                    string destFile = System.IO.Path.Combine(TargetPath, filename);
                    System.IO.File.Copy(filepath, destFile, true);
                        if(StockModel.Add(ProductName, quantity, price)) { trans.Commit(); }
                        else { trans.Rollback(); MessageBox.Show("Error occured", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error); }
               
                }
                else { MessageBox.Show("Error occured", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error); trans.Rollback(); }
            }
                s = new SqlDataAdapter(@"Select id as ID,productcode as ProductCode,productname as ProductName,quantity as Quantity,price as Price,(quantity*price) as Total,files as Files from Products", con);
                d = new DataTable();
                s.Fill(d); 

                return d;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error); trans.Rollback();
                return null;
            }
            finally { con.Close(); }
        }

        #endregion

        #region Deletedata
        public static DataTable Delete(string ProductCode)
        {
          try
            {
                con.Open();
                trans = con.BeginTransaction();
                cmd = new SqlCommand(@"delete from products where productcode='"+ProductCode +"' ", con,trans);
                result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("..Delete Successfully..", "Info", MessageBoxButtons.OK);
                    trans.Commit();
                }
                else { MessageBox.Show("Error occured", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error); trans.Rollback(); }

                s = new SqlDataAdapter(@"Select id as ID,productcode as ProductCode,productname as ProductName,quantity as Quantity,price as Price,(quantity*price) as Total,files as Files from Products", con);
                d = new DataTable();
                s.Fill(d); 
                return d;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error); trans.Rollback();
                return null;
            }
            finally { con.Close();}
        }
        #endregion
    }
}
