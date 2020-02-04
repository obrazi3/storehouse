
namespace Model
{
   public class MeasureLiter:Measure
    {
        public MeasureLiter() : base("Литр") { }

        public override object Clone()
        {
            return new MeasureLiter();
        }
    }
}
