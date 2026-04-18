namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 4)]
    public class CFilterByAngleRange : CFilterMethod
    {
        public enum EDirection
        {
            ED_Forwards = 0,
            ED_Backwards = 1,
            ED_Leftwards = 2,
            ED_Rightwards = 3,
            ED_LastPressedStickDirection = 4,
        }

        [FieldAttr(nst: 24, ctr: 16)] public EDirection _referenceDirection;
        [FieldAttr(nst: 28, ctr: 20)] public float _minAngle;
        [FieldAttr(nst: 32, ctr: 24)] public float _maxAngle;
    }
}
