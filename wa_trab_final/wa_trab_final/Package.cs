using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wa_trab_final
{
    class Package
    {
        private int id;
        private string name;
        private int duration;
        private double adult_price;
        private double kids_price;

        public Package()
        {
            id = duration = 0;
            name = "";
            adult_price = kids_price = 0.0;
        }

        public Package(int _id, string _name, int _duration, double _adult_price, double _kids_price)
        {
            id = _id;
            name = _name;
            duration = _duration;
            adult_price = _adult_price;
            kids_price = _kids_price;
        }

        public void setId(int _id)
        {
            id = _id;
        }
        public int getId()
        {
            return id;
        }
        public void setName(string _name)
        {
            name = _name;
        }
        public string getName()
        {
            return name;
        }
        public void setDuration(int _duration)
        {
            duration = _duration;
        }
        public int getDuration()
        {
            return duration;
        }
        public void setAdultPrice(double _adult_price)
        {
            adult_price = _adult_price;
        }
        public double getAdultPrice()
        {
            return adult_price;
        }
        public void setKidsPrice(double _kids_price)
        {
            kids_price = _kids_price;
        }
        public double getKidsPrice()
        {
            return kids_price;
        }
    }
}
