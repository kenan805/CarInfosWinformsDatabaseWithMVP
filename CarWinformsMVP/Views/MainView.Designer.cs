
namespace CarWinformsMVP.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.cbVendor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbModel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbColor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbYear = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbTransmission = new Guna.UI2.WinForms.Guna2ComboBox();
            this.listBoxCar = new System.Windows.Forms.ListBox();
            this.panel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnLoad = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblTransmission = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblYear = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblColor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblModel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblVendor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbCar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).BeginInit();
            this.SuspendLayout();
            // 
            // cbVendor
            // 
            this.cbVendor.BackColor = System.Drawing.Color.Transparent;
            this.cbVendor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVendor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVendor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVendor.FocusedState.Parent = this.cbVendor;
            this.cbVendor.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cbVendor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbVendor.HoverState.Parent = this.cbVendor;
            this.cbVendor.IntegralHeight = false;
            this.cbVendor.ItemHeight = 30;
            this.cbVendor.Items.AddRange(new object[] {
            "Audi",
            "Bmw",
            "Ford",
            "Hyundai",
            "Kia",
            "Mazda",
            "Tesla"});
            this.cbVendor.ItemsAppearance.Parent = this.cbVendor;
            this.cbVendor.Location = new System.Drawing.Point(327, 65);
            this.cbVendor.Name = "cbVendor";
            this.cbVendor.ShadowDecoration.Parent = this.cbVendor;
            this.cbVendor.Size = new System.Drawing.Size(253, 36);
            this.cbVendor.TabIndex = 5;
            this.cbVendor.SelectedIndexChanged += new System.EventHandler(this.CbVendor_SelectedIndexChanged);
            // 
            // cbModel
            // 
            this.cbModel.BackColor = System.Drawing.Color.Transparent;
            this.cbModel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbModel.FocusedState.Parent = this.cbModel;
            this.cbModel.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cbModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbModel.HoverState.Parent = this.cbModel;
            this.cbModel.IntegralHeight = false;
            this.cbModel.ItemHeight = 30;
            this.cbModel.ItemsAppearance.Parent = this.cbModel;
            this.cbModel.Location = new System.Drawing.Point(327, 151);
            this.cbModel.Name = "cbModel";
            this.cbModel.ShadowDecoration.Parent = this.cbModel;
            this.cbModel.Size = new System.Drawing.Size(253, 36);
            this.cbModel.TabIndex = 6;
            // 
            // cbColor
            // 
            this.cbColor.BackColor = System.Drawing.Color.Transparent;
            this.cbColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbColor.FocusedState.Parent = this.cbColor;
            this.cbColor.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cbColor.ForeColor = System.Drawing.Color.Black;
            this.cbColor.HoverState.Parent = this.cbColor;
            this.cbColor.IntegralHeight = false;
            this.cbColor.ItemHeight = 30;
            this.cbColor.ItemsAppearance.Parent = this.cbColor;
            this.cbColor.Location = new System.Drawing.Point(327, 240);
            this.cbColor.Name = "cbColor";
            this.cbColor.ShadowDecoration.Parent = this.cbColor;
            this.cbColor.Size = new System.Drawing.Size(253, 36);
            this.cbColor.TabIndex = 7;
            // 
            // cbYear
            // 
            this.cbYear.BackColor = System.Drawing.Color.Transparent;
            this.cbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbYear.FocusedState.Parent = this.cbYear;
            this.cbYear.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cbYear.ForeColor = System.Drawing.Color.Black;
            this.cbYear.HoverState.Parent = this.cbYear;
            this.cbYear.IntegralHeight = false;
            this.cbYear.ItemHeight = 30;
            this.cbYear.ItemsAppearance.Parent = this.cbYear;
            this.cbYear.Location = new System.Drawing.Point(327, 338);
            this.cbYear.Name = "cbYear";
            this.cbYear.ShadowDecoration.Parent = this.cbYear;
            this.cbYear.Size = new System.Drawing.Size(253, 36);
            this.cbYear.TabIndex = 8;
            // 
            // cbTransmission
            // 
            this.cbTransmission.BackColor = System.Drawing.Color.Transparent;
            this.cbTransmission.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTransmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransmission.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTransmission.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTransmission.FocusedState.Parent = this.cbTransmission;
            this.cbTransmission.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cbTransmission.ForeColor = System.Drawing.Color.Black;
            this.cbTransmission.HoverState.Parent = this.cbTransmission;
            this.cbTransmission.IntegralHeight = false;
            this.cbTransmission.ItemHeight = 30;
            this.cbTransmission.Items.AddRange(new object[] {
            "Mechanical",
            "Automatic",
            "Robotized",
            "Variator"});
            this.cbTransmission.ItemsAppearance.Parent = this.cbTransmission;
            this.cbTransmission.Location = new System.Drawing.Point(327, 438);
            this.cbTransmission.Name = "cbTransmission";
            this.cbTransmission.ShadowDecoration.Parent = this.cbTransmission;
            this.cbTransmission.Size = new System.Drawing.Size(253, 36);
            this.cbTransmission.TabIndex = 9;
            // 
            // listBoxCar
            // 
            this.listBoxCar.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCar.FormattingEnabled = true;
            this.listBoxCar.ItemHeight = 23;
            this.listBoxCar.Location = new System.Drawing.Point(643, 69);
            this.listBoxCar.Name = "listBoxCar";
            this.listBoxCar.Size = new System.Drawing.Size(361, 280);
            this.listBoxCar.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.listBoxCar);
            this.panel1.Controls.Add(this.cbTransmission);
            this.panel1.Controls.Add(this.cbYear);
            this.panel1.Controls.Add(this.cbColor);
            this.panel1.Controls.Add(this.cbModel);
            this.panel1.Controls.Add(this.cbVendor);
            this.panel1.Controls.Add(this.lblTransmission);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.lblColor);
            this.panel1.Controls.Add(this.lblModel);
            this.panel1.Controls.Add(this.lblVendor);
            this.panel1.Controls.Add(this.pbCar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.FillColor = System.Drawing.Color.IndianRed;
            this.panel1.FillColor2 = System.Drawing.Color.Aqua;
            this.panel1.FillColor3 = System.Drawing.Color.CornflowerBlue;
            this.panel1.FillColor4 = System.Drawing.Color.LavenderBlush;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.ShadowDecoration.Parent = this.panel1;
            this.panel1.Size = new System.Drawing.Size(1076, 548);
            this.panel1.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.CheckedState.Parent = this.btnLoad;
            this.btnLoad.CustomImages.Parent = this.btnLoad;
            this.btnLoad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoad.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoad.DisabledState.Parent = this.btnLoad;
            this.btnLoad.FillColor = System.Drawing.Color.SteelBlue;
            this.btnLoad.FillColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoad.Font = new System.Drawing.Font("Perpetua Titling MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.HoverState.Parent = this.btnLoad;
            this.btnLoad.Location = new System.Drawing.Point(819, 355);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.ShadowDecoration.Parent = this.btnLoad;
            this.btnLoad.Size = new System.Drawing.Size(185, 123);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.DisabledState.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.FillColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(643, 425);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(153, 53);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.DisabledState.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FillColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(643, 355);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(153, 53);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = false;
            this.lblTransmission.BackColor = System.Drawing.Color.Transparent;
            this.lblTransmission.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransmission.Location = new System.Drawing.Point(45, 441);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(320, 42);
            this.lblTransmission.TabIndex = 4;
            this.lblTransmission.Text = "Transmission";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = false;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(45, 341);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(119, 42);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Year";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = false;
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(45, 243);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(146, 42);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = false;
            this.lblModel.BackColor = System.Drawing.Color.Transparent;
            this.lblModel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(45, 154);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(148, 42);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model";
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = false;
            this.lblVendor.BackColor = System.Drawing.Color.Transparent;
            this.lblVendor.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendor.Location = new System.Drawing.Point(45, 68);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(168, 42);
            this.lblVendor.TabIndex = 0;
            this.lblVendor.Text = "Vendor";
            // 
            // pbCar
            // 
            this.pbCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCar.Image = ((System.Drawing.Image)(resources.GetObject("pbCar.Image")));
            this.pbCar.ImageRotate = 0F;
            this.pbCar.Location = new System.Drawing.Point(0, 0);
            this.pbCar.Name = "pbCar";
            this.pbCar.ShadowDecoration.Parent = this.pbCar;
            this.pbCar.Size = new System.Drawing.Size(1076, 548);
            this.pbCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCar.TabIndex = 11;
            this.pbCar.TabStop = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 548);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1094, 595);
            this.MinimumSize = new System.Drawing.Size(1094, 595);
            this.Name = "MainView";
            this.Text = "MainViews";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbVendor;
        private Guna.UI2.WinForms.Guna2ComboBox cbModel;
        private Guna.UI2.WinForms.Guna2ComboBox cbColor;
        private Guna.UI2.WinForms.Guna2ComboBox cbYear;
        private Guna.UI2.WinForms.Guna2ComboBox cbTransmission;
        private System.Windows.Forms.ListBox listBoxCar;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblVendor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblModel;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblColor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblYear;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTransmission;
        private Guna.UI2.WinForms.Guna2PictureBox pbCar;
        private Guna.UI2.WinForms.Guna2GradientButton btnLoad;
        private Guna.UI2.WinForms.Guna2GradientButton btnDelete;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
    }
}