using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distributeur
{
    public abstract class Recette
    {
        public double Eau = 0.2;
        public double marge = 30;

        public abstract double GetValue();

        public double GetPrice()
        {
            return GetValue() + (GetValue() * marge / 100);
        }

        public override string ToString()
        {
            return "Le prix est : " + GetPrice() + " Eur";
        }
    }


    public class Expresso : Recette
    {
        public double Cafe = 1;

        public override double GetValue()
        {
            return Cafe + Eau;
        }


    }

    public class Allenge : Expresso
    {
        public override double GetValue()
        {
            return 2 * Cafe + Eau;
        }


    }

    public class Capuccino : Expresso
    {
        protected double Creme = 0.5;
        protected double Choclate = 1;
        public override double GetValue()
        {
            return Choclate + Creme + Cafe + Eau;
        }


    }

    public class Chocolat : Recette
    {
        protected double Lait = 0.4;
        protected double Choclate = 1;
        protected double Sucre = 0.1;
        public override double GetValue()
        {
            return 3 * Choclate + 2 * Lait + Sucre + Eau;
        }
    }

    public class The : Recette
    {
        protected double Tea = 2;
        public override double GetValue()
        {
            return Tea + 2 * Eau;
        }

    }

}
