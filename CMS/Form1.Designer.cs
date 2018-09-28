namespace CMS
{
    partial class Form1
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.PassTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.UserTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroPanel1.BackColor = System.Drawing.Color.Silver;
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.PassTextBox);
            this.metroPanel1.Controls.Add(this.metroLink3);
            this.metroPanel1.Controls.Add(this.metroLink2);
            this.metroPanel1.Controls.Add(this.metroLink1);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.UserTextBox);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(186, 229);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(394, 265);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // PassTextBox
            // 
            // 
            // 
            // 
            this.PassTextBox.CustomButton.Image = null;
            this.PassTextBox.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.PassTextBox.CustomButton.Name = "";
            this.PassTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PassTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PassTextBox.CustomButton.TabIndex = 1;
            this.PassTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PassTextBox.CustomButton.UseSelectable = true;
            this.PassTextBox.Lines = new string[0];
            this.PassTextBox.Location = new System.Drawing.Point(106, 121);
            this.PassTextBox.MaxLength = 32767;
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.PasswordChar = '*';
            this.PassTextBox.PromptText = "Password";
            this.PassTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PassTextBox.SelectedText = "";
            this.PassTextBox.SelectionLength = 0;
            this.PassTextBox.SelectionStart = 0;
            this.PassTextBox.ShortcutsEnabled = true;
            this.PassTextBox.ShowButton = true;
            this.PassTextBox.Size = new System.Drawing.Size(164, 23);
            this.PassTextBox.TabIndex = 8;
            this.PassTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassTextBox.UseSelectable = true;
            this.PassTextBox.WaterMark = "Password";
            this.PassTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PassTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLink3
            // 
            this.metroLink3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink3.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.metroLink3.Location = new System.Drawing.Point(280, 121);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(102, 20);
            this.metroLink3.TabIndex = 7;
            this.metroLink3.TabStop = false;
            this.metroLink3.Text = "Show Password";
            this.metroLink3.UseSelectable = true;
            this.metroLink3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.metroLink3_MouseDown);
            this.metroLink3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.metroLink3_MouseUp);
            // 
            // metroLink2
            // 
            this.metroLink2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink2.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink2.Location = new System.Drawing.Point(280, 230);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(100, 23);
            this.metroLink2.TabIndex = 6;
            this.metroLink2.Text = "Forget Password";
            this.metroLink2.UseSelectable = true;
            // 
            // metroLink1
            // 
            this.metroLink1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink1.ForeColor = System.Drawing.Color.SkyBlue;
            this.metroLink1.Location = new System.Drawing.Point(15, 230);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(101, 23);
            this.metroLink1.TabIndex = 5;
            this.metroLink1.Text = "Create Account";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(150, 173);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(85, 27);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "LOG IN";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // UserTextBox
            // 
            // 
            // 
            // 
            this.UserTextBox.CustomButton.Image = null;
            this.UserTextBox.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.UserTextBox.CustomButton.Name = "";
            this.UserTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UserTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserTextBox.CustomButton.TabIndex = 1;
            this.UserTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserTextBox.CustomButton.UseSelectable = true;
            this.UserTextBox.Lines = new string[0];
            this.UserTextBox.Location = new System.Drawing.Point(106, 55);
            this.UserTextBox.MaxLength = 32767;
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.PasswordChar = '\0';
            this.UserTextBox.PromptText = "Username";
            this.UserTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserTextBox.SelectedText = "";
            this.UserTextBox.SelectionLength = 0;
            this.UserTextBox.SelectionStart = 0;
            this.UserTextBox.ShortcutsEnabled = true;
            this.UserTextBox.ShowButton = true;
            this.UserTextBox.Size = new System.Drawing.Size(164, 23);
            this.UserTextBox.TabIndex = 2;
            this.UserTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserTextBox.UseSelectable = true;
            this.UserTextBox.WaterMark = "Username";
            this.UserTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "SUNSPHERE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(575, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 70);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 726);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1364, 726);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Movable = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.metroPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox UserTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLink metroLink3;
        private MetroFramework.Controls.MetroTextBox PassTextBox;
    }
}

