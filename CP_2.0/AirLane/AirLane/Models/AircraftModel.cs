using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AirLane.Models
{
    class AircraftModel : INotifyPropertyChanged
    {
        private string _name_aircraft;
        public string name_aircraft
        {
            get { return _name_aircraft; }
            set
            {
                _name_aircraft = value;
                OnPropertyChanged("name_aircraft");

            }
        }

        private string _count_of_seats;
        public string count_of_seats
        {
            get { return _count_of_seats; }
            set
            {
                _count_of_seats = value;
                OnPropertyChanged("count_of_seats");

            }
        }
        private string _speed;
        public string speed
        {
            get { return _speed; }
            set
            {
                _speed = value;
                OnPropertyChanged("speed");

            }
        }

        public void Add()
        {
            int valid;

            if (Int32.TryParse(count_of_seats, out valid) && Int32.TryParse(speed, out valid) && name_aircraft != null && name_aircraft !="" )
            {

                bool flag = true;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "select * from aircrafts";
                sqlCommand.Connection = DBConnection.DBConnection.SqlConnection;
                SqlDataReader reader = sqlCommand.ExecuteReader();



                foreach (var i in reader)
                {
                    if (reader.GetSqlString(0) == name_aircraft)
                    {
                        MessageBox.Show("Даннное имя самолета занято");
                        flag = false;
                        reader.Close();
                        break;
                    }

                }
                if (flag)
                {
                    reader.Close();
                    sqlCommand.CommandText = $"insert into aircrafts(name_aircraft, count_of_seats, speed ) values(@name_aircraft,'{Convert.ToInt32(count_of_seats)}',{Convert.ToInt32(speed)})";
                    SqlParameter nameParam = new SqlParameter("@name_aircraft", name_aircraft);
                    sqlCommand.Parameters.Add(nameParam);
                    sqlCommand.ExecuteNonQuery();

                    FlightsModel.Aircrafts.Clear();
                    sqlCommand.CommandText = "select * from aircrafts";
                    sqlCommand.Connection = DBConnection.DBConnection.SqlConnection;
                    SqlDataReader reader2 = sqlCommand.ExecuteReader();
                    foreach (var i in reader2)
                    {
                        FlightsModel.Aircrafts.Add(new AircraftModel { name_aircraft = reader2.GetString(0), count_of_seats = reader2.GetInt32(1).ToString(), speed = reader2.GetInt32(2).ToString() });
                    }
                    reader2.Close();
                    MessageBox.Show("Самолет успешно добавлен");
                }
            }
            else
            {
                MessageBox.Show("Введены не корректные данные");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }



    }
}
