using System;
using System.Windows.Forms;
using CityInformationWithDatabaseApp.BLL;
using CityInformationWithDatabaseApp.Model;

namespace CityInformationWithDatabaseApp.UI
{
    public partial class CityInfoUI : Form
    {
        public CityInfoUI()
        {
            InitializeComponent();
        }
        Manager manager = new Manager();
        private void saveButton_Click(object sender, EventArgs e)
        {
            City aCity = new City();
            aCity.CityName = cityNameTextBox.Text;
            aCity.About = aboutTextBox.Text;
            aCity.Country = countryTextBox.Text;
            
            MessageBox.Show(manager.Save(aCity));
        }
    }
}
