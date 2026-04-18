namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 72, align: 8)]
    public class CAudioGraphDriverModeStickBased : CAudioGraphDriverMode
    {
        [FieldAttr(nst: 56, ctr: 52)] public float _fullStickGraphInput = 0.89999998f;
        [FieldAttr(nst: 68, ctr: 56)] public float _targetGraphInput;
        [FieldAttr(nst: 72, ctr: 60)] public float _currentGraphInput;
        [FieldAttr(nst: 64, ctr: 64)] public float _graphInputChangePerSecond = 2.0f;
        [FieldAttr(nst: 60, ctr: 68)] public float _noStickGraphInput;
    }
}
