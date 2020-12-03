using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentPOP8_JuliePOLICAR
{
    public class Adress
    {
        // Instance varaiables
        internal string adress;
        internal string street;
        internal string city;
        internal string country;

        // Constructor
    public Adress (string street, string city, string country)
        {
            
            this.street = street;
            this.city = city;
            this.country = country;
            adress = street + city + country;
        }

        // Properties
    public string Adresss
        {
            get { return adress; }
            set { adress = street + " " + city + " " +country ; }
        }
    

    public string Street
        {
            get { return street; }
            set { street = value; }
        }

    public string City
        {
            get { return city; }
            set { city = value; }
        }

    public string Country
        {
            get { return country; }
            set { country = value; }
        }

    // Method
    public string FAdress()
        {
            return adress; // so the adress is already created in this class
        }
    }
}
