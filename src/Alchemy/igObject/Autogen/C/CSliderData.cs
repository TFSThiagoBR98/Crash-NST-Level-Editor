namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8, meta: true)]
    public class CSliderData : Object
    {
        [FieldAttr(nst: 32)] public float _startingValue;
        [FieldAttr(nst: 36)] public float _endingValue;
        [FieldAttr(nst: 40)] public float _totalDuration;
        [FieldAttr(nst: 44)] public float _easeInDuration;
        [FieldAttr(nst: 48)] public float _easeOutDuration;
        [FieldAttr(nst: 52)] public EigEaseType _easeType = EigEaseType.kEaseTypeQuadratic;
        [FieldAttr(nst: 56)] public ESliderMode _mode;
    }
}
