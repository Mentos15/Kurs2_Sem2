using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AirLane.Models
{
    class AiraportModel : INotifyPropertyChanged
    {
        private string _nameAirport;
        public string nameAirport
        {
            get { return _nameAirport; }
            set
            {
                _nameAirport = value;
                OnPropertyChanged("nameAirport");

            }
        }

        private string _country;
        public string country
        {
            get { return _country; }
            set
            {
                _country = value;
                OnPropertyChanged("country");
            }
        }

        private string _town;
        public string town
        {
            get { return _town; }
            set
            {
                _town = value;
                OnPropertyChanged("town");
            }
        }

        public void Add()
        {
            bool flag = true;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "select * from airport";
            sqlCommand.Connection = DBConnection.DBConnection.SqlConnection;
            SqlDataReader reader = sqlCommand.ExecuteReader();



            foreach (var i in reader)
            {
                if (reader.GetSqlString(0) == nameAirport)
                {
                    MessageBox.Show("Данный аэропорт уже существует");
                    flag = false;
                    reader.Close();
                    break;
                }

            }
            if (flag)
            {
                if (nameAirport != null  && country != null  && town != null )
                {
                    if (nameAirport != "" && country != "" && town != "")
                    {
                        reader.Close();
                        sqlCommand.CommandText = $"insert into airport (nameAirport, country, town ) values(@nameAirport,@country,@town)";
                        SqlParameter nameParam = new SqlParameter("@nameAirport", nameAirport);
                        sqlCommand.Parameters.Add(nameParam);
                        SqlParameter countryParap = new SqlParameter("@country", country);
                        sqlCommand.Parameters.Add(countryParap);
                        SqlParameter townParam = new SqlParameter("@town", town);
                        sqlCommand.Parameters.Add(townParam);
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Аэропорт успешно добавлен");

                        sqlCommand.CommandText = "select * from airport";
                        sqlCommand.Connection = DBConnection.DBConnection.SqlConnection;
                        SqlDataReader reader2 = sqlCommand.ExecuteReader();


                        RouteModel.AirportsFrom.Clear();
                        RouteModel.AirportsTo.Clear();
                        foreach (var x in reader2)
                        {
                            RouteModel.AirportsFrom.Add(new AiraportModel { nameAirport = reader2.GetString(0), country = reader2.GetString(1), town = reader2.GetString(2) });
                            RouteModel.AirportsTo.Add(new AiraportModel { nameAirport = reader2.GetString(0), country = reader2.GetString(1), town = reader2.GetString(2) });
                        }
                        reader2.Close();
                    }
                    else
                    {
                        MessageBox.Show("Заполнены не все поля");
                        reader.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Заполнены не все поля");
                    reader.Close();
                }

            }
            reader.Close();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
