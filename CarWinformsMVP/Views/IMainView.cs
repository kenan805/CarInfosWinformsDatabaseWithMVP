using CarWinformsMVP.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWinformsMVP.Views
{
    public interface IMainView
    {
        EventHandler<EventArgs> AddButtonClickedHandler { get; set; }
        EventHandler<EventArgs> DeleteButtonClickedHandler { get; set; }
        EventHandler<EventArgs> LoadButtonClickedHandler { get; set; }
        EventHandler<EventArgs> ComboBoxVendorSelectedIndexChangedHandler { get; set; }
        string VendorText { get; set; }
        string ModelText { get; set; }
        string ColorText { get; set; }
        string YearText { get; set; }
        string TransmissionText { get; set; }
        List<Car> Cars { set; }
        Car SelectDeleteCar { get; set; }
        List<string> Colors { set; }
        List<int> Years { set; }
        List<string> Transmissions { set; }
        List<string> Models { set; }
        Guna.UI2.WinForms.Guna2ComboBox ComboBoxColor { get; set; }


    }
}
