
namespace Model
{
    public class MeasurePiece : Measure
    {
        public MeasurePiece() : base("Штука") { }

        public override object Clone()
        {
            return new MeasurePiece();
        }
    }
}
