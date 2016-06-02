using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    class Car
    {
        private String year;
        private String make;
        private String model;
        private int _speed;
        private double _tank;
        
        public Car(String y, String make, String model)
        {
            year = y;
            this.make = make;
            this.model = model;
        }
        public String getYear()
        {
            return year;
        }
        public String getMake()
        {
            return make;
        }
        public String getModel()
        {
            return model;
        }
        public void setYear(String y)
        {
            year = y;
        }
        public void setMake(String ma)
        {
            make = ma;
        }
        public void setModel(String mo)
        {
            model = mo;
        }
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }
        public double Tank
        {
            get { return _tank; }
            set { _tank = value; }
        }
    }
}
