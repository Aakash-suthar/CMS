using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CMS
{
    public partial class Stock : MetroForm
    {
        #region public properties
        DataTable d;
        #endregion

        #region Constructer
        public Stock()
        {
            InitializeComponent();
            metroGrid1.DataSource = d = StockModel.Read();
        }
        #endregion

        #region private events
        private void RefreshButton_Click(object sender, System.EventArgs e)
        {
            metroGrid1.DataSource = d = StockModel.Read();
            Comborefresh();
        }

        private void Stock_Load(object sender, System.EventArgs e)
        {
            Comborefresh();
        }

        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (ProductnameComboBox.SelectedItem.ToString().Length>0)
                {
                    metroGrid1.DataSource = d = StockModel.Delete(ProductnameComboBox.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Field is blank", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { MessageBox.Show("Field is blank", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            Comborefresh(); Cleardata();
        }

        private void UpdateButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (QuantityTextBox.Text.Length > 0 && ProductnameComboBox.SelectedIndex!=-1)
                { metroGrid1.DataSource = StockModel.Update(ProductnameComboBox.SelectedItem.ToString(), Convert.ToInt32(QuantityTextBox.Text));                }

                else
                { MessageBox.Show("Field is blank", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch
            {
                MessageBox.Show("Field is blank", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cleardata(); Comborefresh();
        }

        #endregion

        #region methods
        void Comborefresh()
        {
            ProductnameComboBox.Items.Clear();
            for (int i = 0; i < d.Rows.Count; i++)
            {
                ProductnameComboBox.Items.Add(d.Rows[i]["ProductName"]);
            }
        }
        void Cleardata()
        {
            QuantityTextBox.Clear();
        }
        #endregion

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0) {
                ProductnameComboBox.Text = metroGrid1.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                QuantityTextBox.Text = metroGrid1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            }
        }
    }
}
