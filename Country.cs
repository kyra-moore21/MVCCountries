﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    internal class Country
    {
        public string Name { get; set; }
        public string Continent { get; set; }
        public List<string> Colors { get; set; }
        public Country(string _name, string _Continent, List<string> _Colors)
        {
            Name = _name;
            Continent = _Continent;
            Colors = _Colors;
        }
    }
}
