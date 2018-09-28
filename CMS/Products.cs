using MetroFramework.Forms;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace CMS
{
    public partial class Products : MetroForm
    {
        #region public properties
        DataTable d;
        string Filename = null;
        string Filepath = null;
        #endregion

        #region constructor
        public Products()
        {
            InitializeComponent();
            metroGrid1.DataSource = d = ProductModel.Read();
        }
        #endregion

        #region private events
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FilenameLabel.Text == "FileNotSelected")
                {
                    if (ProductNameTextBox.Text.Length > 0 && ProductCodeTextBox.Text.Length > 0 && QuantityTextBox.Text.Length > 0 && PriceTextBox.Text.Length > 0)
                    {
                        metroGrid1.DataSource = d = ProductModel.Add(ProductCodeTextBox.Text, ProductNameTextBox.Text, Convert.ToInt32(QuantityTextBox.Text), Convert.ToInt32(PriceTextBox.Text),String.Empty,String.Empty);
                    }
                    else
                    {
                        MessageBox.Show(".. Some Fields are Blank ..", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (ProductNameTextBox.Text.Length > 0 && ProductCodeTextBox.Text.Length > 0 && QuantityTextBox.Text.Length > 0 && PriceTextBox.Text.Length > 0)
                    {
                        metroGrid1.DataSource = d = ProductModel.Add(ProductCodeTextBox.Text, ProductNameTextBox.Text, Convert.ToInt32(QuantityTextBox.Text), Convert.ToInt32(PriceTextBox.Text), Filename, Filepath);
                    }
                    else
                    {
                        MessageBox.Show(".. Some Fields are Blank ..", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { MessageBox.Show(".. Some Fields are Blank ..", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);  }
            Cleardata();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductCodeTextBox.Text.Length > 0)
                {
                    DataRow[] foundAuthors = d.Select("ProductCode = '" + ProductCodeTextBox.Text + "'");
                    int result = foundAuthors.Length;
                    if (foundAuthors.Length == 1)
                    {
                        metroGrid1.DataSource = d = ProductModel.Delete(ProductCodeTextBox.Text);
                    }
                    else
                    {
                        MessageBox.Show(".. Product Doesn't Exist ..", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(".. Some Fields are Blank ..", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch { MessageBox.Show(".. Some Fields are Blank ..", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            Cleardata();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDlg = new OpenFileDialog();
            ofDlg.Filter = "DOC|*.docx|PDF|*.pdf|IMG |*.jpg";

            if (DialogResult.OK == ofDlg.ShowDialog())
            {
                Filepath = ofDlg.FileName;
                Filename = FilenameLabel.Text = Path.GetFileName(ofDlg.FileName);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            metroGrid1.DataSource = d = ProductModel.Read();
            Cleardata();
        }
        #endregion

        #region public method
        public void Cleardata()
        {
            FilenameLabel.Text = "FileNotSelected";
            PriceTextBox.Clear();
            QuantityTextBox.Clear();
            ProductCodeTextBox.Clear();
            ProductNameTextBox.Clear();
        }
        #endregion

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0) { 
            //productcode as ProductCode,productname as ProductName,quantity as Quantity,price as Price
            ProductCodeTextBox.Text = metroGrid1.Rows[e.RowIndex].Cells["ProductCode"].Value.ToString();
            ProductNameTextBox.Text = metroGrid1.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                //QuantityTextBox.Text = metroGrid1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                //PriceTextBox.Text = metroGrid1.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            }
        }
    }
}
