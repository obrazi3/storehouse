
namespace Model
{
    class MeasurePiece : Measure
    {
        public MeasurePiece() : base("Штука") { }

        public override object Clone()
        {
            return (object)new MeasurePiece();
        }
    }
}
