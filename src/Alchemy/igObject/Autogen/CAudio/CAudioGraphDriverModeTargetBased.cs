namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 64, align: 8)]
    public class CAudioGraphDriverModeTargetBased : CAudioGraphDriverMode
    {
        [FieldAttr(nst: 56, ctr: 52)] public float _targetGraphInput = 0.89999998f;
        [FieldAttr(nst: 60, ctr: 56)] public float _graphInputChangePerSecond = 2.0f;
        [FieldAttr(nst: 64, ctr: 60)] public float _currentGraphInput;
    }
}
