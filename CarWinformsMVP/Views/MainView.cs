using CarWinformsMVP.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWinformsMVP.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> AddButtonClickedHandler { get; set; }
        public EventHandler<EventArgs> DeleteButtonClickedHandler { get; set; }
        public EventHandler<EventArgs> LoadButtonClickedHandler { get; set; }
        public EventHandler<EventArgs> ComboBoxVendorSelectedIndexChangedHandler { get; set; }
        public string VendorText { get => cbVendor.Text; set => cbVendor.Text = value; }
        public string ModelText { get => cbModel.Text; set => cbModel.Text = value; }
        public string ColorText { get => cbColor.Text; set => cbColor.Text = value; }
        public string YearText { get => cbYear.Text; set => cbYear.Text = value; }
        public string TransmissionText { get => cbTransmission.Text; set => cbTransmission.Text = value; }
        public List<Car> Cars { set => listBoxCar.DataSource = value; }
        public Car SelectDeleteCar { get => listBoxCar.SelectedItem as Car; set => listBoxCar.SelectedItem = value; }
        public List<string> Colors { set => cbColor.DataSource = value; }
        public List<int> Years { set => cbYear.DataSource = value; }
        public List<string> Transmissions { set => cbTransmission.DataSource = value; }
        public List<string> Models { set => cbModel.DataSource = value; }

        private void BtnAdd_Click(object sender, EventArgs e) => AddButtonClickedHandler.Invoke(sender, e);

        private void BtnDelete_Click(object sender, EventArgs e) => DeleteButtonClickedHandler.Invoke(sender, e);

        private void BtnLoad_Click(object sender, EventArgs e) => LoadButtonClickedHandler.Invoke(sender, e);

        private void CbVendor_SelectedIndexChanged(object sender, EventArgs e) => ComboBoxVendorSelectedIndexChangedHandler.Invoke(sender, e);
    }
}
