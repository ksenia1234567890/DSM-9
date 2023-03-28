using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр7
{
    
    public class BaseObject
    {
        
        private double range;
        private double capacity;
        private double speed;

        // Свойство: дальность
        public double Range
        {
            get
            {
                return range;
            }
            set
            {
                range = value;
            }
        }

        // Свойство: вместимость
        public double Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        // Свойство: скорость
        public double Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }


        // Грузопоток в зависимости от расстояния

        virtual public double CargoTurnover(double weight, double distance)
        {
            return weight * distance;
        }
    }

    public class ChildObject : BaseObject
    {
        private string nickname;
        private double price;
        
        // Свойство: наименование
        public string Nickname
        {
            get
            {
                return nickname;
            }
            set
            {
                if (value.Contains("Имя_") == true)
                {
                    nickname = value;
                }
            }
        }

        // Свойство: цена
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if(value>20000)
                {
                    price = value;
                }
            }
        }

        // Метод: расчет стоимости перевозки в пересчете за килограмм груза
        public override double CargoTurnover(double price, double kilograms)
        {
            return price * kilograms;
        }

        
    }

}
