using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quartet
{
    internal class CarCard
    {
<<<<<<< HEAD
        public enum category { maxspeed, CC, zeroTo60, cylinders, HP, RPM, ID}
        public string name { get; set; }
        public int maxspeed { get; set; }
        public int CC { get; set; }
        public double zeroTo60 { get; set; }
        public int cylinders { get; set; }
        public int HP { get; set; }
        public int RPM { get; set; }
        public int ID { get; set; }

        public CarCard(string name, int maxspeed, int CC, double zeroTo60, int cylinders, int HP, int RPM, int ID)
        {
            this.name = name;
            this.maxspeed = maxspeed;
            this.CC = CC;
            this.zeroTo60 = zeroTo60;
            this.cylinders = cylinders;
            this.HP = HP;
            this.RPM = RPM;
            this.ID = ID;
        }
        public CarCard compare(CarCard other, category c)
        {
            if (other == null) return this;
            if (c == category.maxspeed)
                if (maxspeed > other.maxspeed)
                    return this;
                else
                    return other;

            if (c == category.CC)
                if (CC > other.CC)
                    return this;
                else
                    return other;

            if (c == category.zeroTo60)
                if (zeroTo60 > other.zeroTo60)
                    return this;
                else
                    return other;

            if (c == category.cylinders)
                if (cylinders > other.cylinders)
                    return this;
                else
                return other;

            if (c == category.HP)
                if (HP > other.HP)
                    return this;
                else
                return other;

            if (c == category.RPM)
                if (RPM > other.RPM)
                    return this;
                else
                return other;

            return null;
        }

        public override string ToString()
        {
            return name + ":\n\tmaxspeed:" + maxspeed 
                + "\n\tzeroTo60:" + zeroTo60
                + "\n\tcylinders:" + cylinders
                + "\n\tHP:" + HP
                + "\n\tRPM:" + RPM
                + "\n\tID:" + ID;
        }
=======
       public int maxspeed { get; set; }
        public double zeroTO60 { get; set; }
        public int HP { get; set; }
        public int CC { get; set; }
        public int cylinders { get; set; }
        public int RPM { get; set; }
>>>>>>> main
    }
}
