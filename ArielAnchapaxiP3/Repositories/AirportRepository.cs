using ArielAnchapaxiP3.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArielAnchapaxiP3.Repositories
{
    public class AirportRepository
    {
        public string _dbPath;
        public string? StatusMessage { get; set; }

        private SQLiteConnection? conn;

        public AirportRepository(string dbpath)
        {
            _dbPath = dbpath;
        }


        private void Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<AirportModel>();
        }

        public void AddNewAirport(AirportModel airport)
        {
            int result = 0;
            try
            {
                Init();
                if (airport == null)
                    throw new Exception("Valid object required");

                result = conn.Insert(airport);

                StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, airport.name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", airport.name, ex.Message);
            }

        }

        public List<AirportModel> GetAllAirports()
        {
            try
            {
                Init();
                StatusMessage = string.Format("Success");
                return conn.Table<AirportModel>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<AirportModel>();
        }
    }
}
