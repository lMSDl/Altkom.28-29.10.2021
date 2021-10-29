using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    //public - ogólnie dostępne
    //private - dostępne tylko w obrębie klasy
    //internal - dostępne w obrębie projektu (assembly)
    public class Product
    {
        private decimal _price;
        /*private string _name;
        public void SetName(string value)
        {
            _name = value;
        }
        public string GetName()
        {
            return _name;
        }*/

        //auto-property
        public string Name { get; set; }

        public Category Category { get; set; }

        //full-property
        public decimal Price
        {
            get { 
                return _price;
            }
            set
            {
                if(value >= 0)
                    _price = value;
            }
        }

        public Product()
        {
        }
        public Product(DateTime expirationDate)
        {
            ExpirationDate = expirationDate;
        }


        //read-only property (bez settera)- wartość możemy ustawić tylko w konstruktorze
        public DateTime ExpirationDate { get; set; }

        public override string ToString()
        {
            //return $"{Name}; {Category}; {Price}zł; {ExpirationDate.ToShortDateString()}";
            return JsonConvert.SerializeObject(this);
        }
    }
}
