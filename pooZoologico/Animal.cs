﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooZoologico
{
    public class Animal
    {
        public Animal()
        {
            this.Especie = "";
            this.Peso = 0;
        }
        public Animal(string especie, double peso)
        {
            this.Especie = especie;
            this.Peso = peso;
        }

        public string Especie { get; set; }
        public double Peso { get; set; }
    }
}
