using CarWinformsMVP.Data;
using CarWinformsMVP.Models;
using CarWinformsMVP.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWinformsMVP.Presenters
{
    public class MainPresenter
    {
        private readonly CarContext _carContext;
        private readonly IMainView _view;
        public MainPresenter(IMainView view)
        {
            _view = view;
            _carContext = new CarContext();
            //Colors
            List<string> colors = new List<string>();
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                    colors.Add(prop.Name);
            }
            _view.Colors = colors;
            //Years
            List<int> years = new List<int>();
            for (int year = DateTime.Now.Year; year >= 1900; year--)
                years.Add(year);
            _view.Years = years;

            _view.AddButtonClickedHandler += ViewAddButtonClicked;
            _view.DeleteButtonClickedHandler += ViewDeleteButtonClicked;
            _view.LoadButtonClickedHandler += ViewLoadButtonClicked;
            _view.ComboBoxVendorSelectedIndexChangedHandler += ViewComboBoxSelectedIndexChanged;
        }

        private void ViewAddButtonClicked(object sender, EventArgs e)
        {
            Car car = new Car()
            {
                Vendor = _view.VendorText,
                Model = _view.ModelText,
                Color = _view.ColorText,
                Year = int.Parse(_view.YearText),
                Transmission = _view.TransmissionText
            };
            _carContext.Cars.Add(car);
            _carContext.SaveChanges();
        }
        private void ViewDeleteButtonClicked(object sender, EventArgs e)
        {
            _carContext.Cars.Remove(_view.SelectDeleteCar);
            _carContext.SaveChanges();
        }
        private void ViewLoadButtonClicked(object sender, EventArgs e)
        {
            _view.Cars = _carContext.Cars.ToList();
        }
        private void ViewComboBoxSelectedIndexChanged(object sender,EventArgs e)
        {
            List<string> models = new List<string>();
            switch (_view.VendorText)
            {
                case "Audi":
                    {
                        models.Add("100");
                        models.Add("80");
                        models.Add("A1");
                        models.Add("A3");
                        models.Add("A4");
                        break;
                    }
                case "Bmw":
                    {
                        models.Add("M3");
                        models.Add("M5");
                        models.Add("M6");
                        models.Add("X5");
                        models.Add("X6");
                        models.Add("i3");
                        models.Add("i8");
                        break;
                    }
                case "Ford":
                    {
                        models.Add("Contour");
                        models.Add("Escape");
                        models.Add("Explorer");
                        models.Add("Focus");
                        models.Add("Fusion");
                        models.Add("Mustang");
                        models.Add("Ranger");
                        break;
                    }
                case "Hyundai":
                    {
                        models.Add("Azera");
                        models.Add("Elantra");
                        models.Add("Grandeur");
                        models.Add("Sonata");
                        models.Add("Tucson");
                        models.Add("Veloster");
                        models.Add("Venue");
                        models.Add("i30");
                        models.Add("ix35");
                        models.Add("ix55");
                        break;
                    }
                case "Kia":
                    {
                        models.Add("Carnival");
                        models.Add("Ceed");
                        models.Add("Cerato");
                        models.Add("Optima");
                        models.Add("Rio");
                        models.Add("Stinger");
                        break;
                    }
                case "Mazda":
                    {
                        models.Add("CX-30");
                        models.Add("CX-5");
                        models.Add("CX-7");
                        models.Add("MPV");
                        models.Add("Millenia");
                        break;
                    }
                case "Tesla":
                    {
                        models.Add("Model 3");
                        models.Add("Model X");
                        models.Add("Model S");
                        models.Add("Model Y");
                        break;
                    }
            }
            _view.Models = models;
        }
    }
}
