namespace CMS
{
    partial class Stock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ProductnameComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.QuantityTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UpdateButton = new MetroFramework.Controls.MetroButton();
            this.DeleteButton = new MetroFramework.Controls.MetroButton();
            this.RefreshButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel1.Location = new System.Drawing.Point(24, 40);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ProductName : ";
            this.metroLabel1.UseMnemonic = false;
            // 
            // ProductnameComboBox
            // 
            this.ProductnameComboBox.FormattingEnabled = true;
            this.ProductnameComboBox.ItemHeight = 23;
            this.ProductnameComboBox.Location = new System.Drawing.Point(144, 40);
            this.ProductnameComboBox.Name = "ProductnameComboBox";
            this.ProductnameComboBox.Size = new System.Drawing.Size(153, 29);
            this.ProductnameComboBox.TabIndex = 1;
            this.ProductnameComboBox.TabStop = false;
            this.ProductnameComboBox.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(333, 44);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Quantity : ";
            this.metroLabel2.UseMnemonic = false;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToOrderColumns = true;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.White;
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeight = 40;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.Black;
            this.metroGrid1.Location = new System.Drawing.Point(-3, 95);
            this.metroGrid1.MultiSelect = false;
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersVisible = false;
            this.metroGrid1.RowHeadersWidth = 70;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.ShowCellErrors = false;
            this.metroGrid1.ShowCellToolTips = false;
            this.metroGrid1.ShowEditingIcon = false;
            this.metroGrid1.ShowRowErrors = false;
            this.metroGrid1.Size = new System.Drawing.Size(1325, 533);
            this.metroGrid1.TabIndex = 6;
            this.metroGrid1.TabStop = false;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            // 
            // QuantityTextBox
            // 
            // 
            // 
            // 
            this.QuantityTextBox.CustomButton.Image = null;
            this.QuantityTextBox.CustomButton.Location = new System.Drawing.Point(102, 1);
            this.QuantityTextBox.CustomButton.Name = "";
            this.QuantityTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.QuantityTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QuantityTextBox.CustomButton.TabIndex = 1;
            this.QuantityTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QuantityTextBox.CustomButton.UseSelectable = true;
            this.QuantityTextBox.CustomButton.Visible = false;
            this.QuantityTextBox.Lines = new string[0];
            this.QuantityTextBox.Location = new System.Drawing.Point(421, 44);
            this.QuantityTextBox.MaxLength = 32767;
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.PasswordChar = '\0';
            this.QuantityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QuantityTextBox.SelectedText = "";
            this.QuantityTextBox.SelectionLength = 0;
            this.QuantityTextBox.SelectionStart = 0;
            this.QuantityTextBox.ShortcutsEnabled = true;
            this.QuantityTextBox.Size = new System.Drawing.Size(126, 25);
            this.QuantityTextBox.TabIndex = 7;
            this.QuantityTextBox.TabStop = false;
            this.QuantityTextBox.UseSelectable = true;
            this.QuantityTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QuantityTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UpdateButton
            // 
            this.UpdateButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.UpdateButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.UpdateButton.Location = new System.Drawing.Point(686, 40);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(85, 33);
            this.UpdateButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.TabStop = false;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseCustomBackColor = true;
            this.UpdateButton.UseSelectable = true;
            this.UpdateButton.UseStyleColors = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.DeleteButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.DeleteButton.Location = new System.Drawing.Point(786, 40);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(85, 33);
            this.DeleteButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseCustomBackColor = true;
            this.DeleteButton.UseSelectable = true;
            this.DeleteButton.UseStyleColors = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.RefreshButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.RefreshButton.Location = new System.Drawing.Point(886, 40);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(85, 33);
            this.RefreshButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.RefreshButton.TabIndex = 10;
            this.RefreshButton.TabStop = false;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseCustomBackColor = true;
            this.RefreshButton.UseSelectable = true;
            this.RefreshButton.UseStyleColors = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 641);
            this.ControlBox = false;
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.ProductnameComboBox);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Stock";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox ProductnameComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTextBox QuantityTextBox;
        private MetroFramework.Controls.MetroButton UpdateButton;
        private MetroFramework.Controls.MetroButton DeleteButton;
        private MetroFramework.Controls.MetroButton RefreshButton;
    }
}