﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testek
{
    internal class Henger : Testek
    {
        double sugar;
        double magassag;

        public Henger(double egy, double ketto) : base("Henger")
        {
            this.sugar = egy;
            this.magassag = ketto;
        }

        public override double Felszin()
        {
            //A = 2 r 2 π + 2 r π ⋅ m
            return Math.Round( 2 * (sugar * sugar) * Math.PI + 2 * sugar * Math.PI * magassag);
        }
        public override double Terfogat()
        {
            //V = r 2 π ⋅ m
            return Math.Round( (sugar * sugar) * Math.PI * magassag);
        }


    }
}
