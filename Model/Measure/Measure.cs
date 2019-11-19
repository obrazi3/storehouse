
using System;

namespace Model
{
   abstract class Measure:ICloneable
    {
        public string TypeMeasure { private set; get; }

        public Measure(string typeMeasure)
        {
            this.TypeMeasure = typeMeasure;
        }

        public abstract object Clone();
    }
}
