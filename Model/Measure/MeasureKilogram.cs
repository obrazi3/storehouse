﻿
namespace Model
{
   public class MeasureKilogram : Measure
    {
        public MeasureKilogram() : base("Килограмм") { }

        public override object Clone()
        {
            return new MeasureKilogram();
        }
    }
}
