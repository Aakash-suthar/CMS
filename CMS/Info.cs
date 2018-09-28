using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CMS
{
    public static class Info
    {
        public static SqlConnection con = new SqlConnection(@"Data Source =VISHAL-PC; Initial Catalog = master; Integrated Security = True");

        #region public member
        //public string gmail
        //{
        //    get;
        //    set;
        //}
        //public string Firstname
        //{
        //    get;
        //    set;
        //}
        //public string Lastname
        //{
        //    get;
        //    set;
        //}
        //public string Username
        //{
        //    get;
        //    set;
        //}
        //public string pass
        //{
        //    get;
        //    set;
        //}
        #endregion


        public static bool Save(string Username,string Password,string gmail,string firstname,string lastname)
        {
            #region Fileoperation
            //using (var e = new FileStream("Info.xml", FileMode.Create))
            //{
            //    var xml = new XmlSerializer(typeof(Info));
            //    xml.Serialize(e, this);
            //}
            #endregion

            try
            {
                con.Open();
                SqlCommand adap = new SqlCommand(@"Insert into Users values('" + Username + "','" + Password + "','" + gmail + "','" + firstname + "','" + lastname + "' )", con);
                int result = adap.ExecuteNonQuery();
                if (result >= 0) return true;
                else  return false;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                
            }
            finally { con.Close(); }

           

        }

        public static bool Read(string Username,string Password)
        {
            #region Fileread
            //if (File.Exists("Info.xml"))
            //{
            //    XmlSerializer xm = new XmlSerializer(typeof(Info));
            //    FileStream read = new FileStream("Info.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            //    Info f = (Info)xm.Deserialize(read);
            //    read.Close();
            //    return (f);

            //}
            //else
            #endregion
            try
            {
                con.Open();
                SqlDataAdapter adap = new SqlDataAdapter(@"Select * from Users where username = '" + Username + "' and password =  '" + Password + "'", con);
                DataTable d = new DataTable();
                adap.Fill(d);
                if (d.Rows.Count == 1)
                {
                    return true;
                }
                else return false;
            }
            catch { return false; }
            finally { con.Close(); }
        }

        public static bool CheckDatabase()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"Select * from Users", con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch   { return false; }
            finally { con.Close(); }
        }

        public static void GenerateDatabase()
        {
            try
            {
               string script = File.ReadAllText(Application.StartupPath + "\\Script.sql"); 

                // split script on GO command
                IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$",
                                         RegexOptions.Multiline | RegexOptions.IgnoreCase);

                con.Open();
                foreach (string commandString in commandStrings)
                {
                    if (commandString.Trim() != "")
                    {
                        using (var command = new SqlCommand(commandString, con))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Generated succesfully.");
            }
            catch(Exception e) { MessageBox.Show(e.Message,"Alert",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            finally { con.Close(); }
        }
    }
}
