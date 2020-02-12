using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary
    {
    public class Pug : Dog
        {
        public bool IsSmall { get; set; }
        



        public Pug (string Name) : base(Name)
            {
            IsSmall = true;
            this.LongTail = false;
            
            }
        public Pug() : this("Spot")
            {
            this.Muzzle = MuzzleType.Collapsed;
            }
        public override string GetTypeDog()
            {
            return "Pug";
            }
        }
    }
