using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_DelSmith
{
    public class Vehicle
    {
        private int id;
        private String make;
        private String model;
        private String year;


        public int ID
        {
            get { return id; }
        }

        public String Make
        {
            get { return make; }
            set { make = value; }
        }

        public String Model
        {
            get { return model; }
            set { model = value; }
        }

        public String Year
        {
            get { return year; }
            set { year = value; }
        }

        public Vehicle(int id, String make, String model, String year)
        {
            this.id = id;
            this.make = make;
            this.model = model;
            this.year = year;
        }
    }
}
