using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CityInformationWithDatabaseApp.DAL;
using CityInformationWithDatabaseApp.Model;

namespace CityInformationWithDatabaseApp.BLL
{
    class Manager
    {
        Gateway gateway = new Gateway();
        public string Save(City aCity)
        {
            if (gateway.IsCityNameExists(aCity.CityName))
            {
                MessageBox.Show("City Name Already Exists");
            }
            if (aCity.CityName.Length>3)
                {
                    if (gateway.Save(aCity)>0)
                    {
                        return "Successfully saved";
                    }
                    else
                    {
                        return "Save failed";
                    }
                }
                else
                {
                    return "City name must be at least 4 characters long";
                }
        }
    }
}
