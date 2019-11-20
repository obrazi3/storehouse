
using System;

namespace Model
{
    public abstract class Measure : ICloneable
    {
        public string TypeMeasure { private set; get; }

        public Measure(string typeMeasure)
        {
            this.TypeMeasure = typeMeasure;
        }

        public abstract object Clone();

        public override bool Equals(object o)
        {
            return TypeMeasure.Equals(((Measure)o).TypeMeasure);
        }
    }
}
