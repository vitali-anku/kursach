﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_lab
{
    [Serializable]
    public class Stud
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Spec { get; set; }
        public string BirthDay { get; set; }
        public string k { get; set; }
        public string group { get; set; }
        public string gender { get; set; }
        public string sr { get; set; }
        public string City { get; set; }
        public string street { get; set; }
        public string house { get; set; }
        public string apartament { get; set; }
        
        public Stud()
        {

        }

        public Stud(string name, int age, string spec, string birthday,
            string k, string group, string gender, string sr,
            AddressWithCity add)
        {
            Name = name;
            Age = age;
            Spec = spec;
            BirthDay = birthday;
            this.k = k;
            this.group = group;
            this.gender = gender;
            this.sr = sr;
            AddressWithCity address = add;
            City = add.city.city;
            street = add.address.street;
            house = add.address.house;
            apartament = add.address.apartament;
        }
    }

    public class AddressWithCity
    {
        public City city;
        public Address address;

        public AddressWithCity(City c, Address a)
        {
            city = c;
            address = a;
        }
    }

    public class City
    {
        public string city { get; set; }
    }

    public class Address
    {
        public string street { get; set; }
        public string house { get; set; }
        public string apartament { get; set; }
    }
}
