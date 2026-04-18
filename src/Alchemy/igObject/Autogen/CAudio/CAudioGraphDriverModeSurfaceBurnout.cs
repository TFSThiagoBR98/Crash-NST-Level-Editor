namespace Alchemy
{
    [ObjectAttr(nst: 216, ctr: 208, align: 8)]
    public class CAudioGraphDriverModeSurfaceBurnout : CAudioGraphDriverModeTargetBased
    {
        [FieldAttr(nst: 72, ctr: 64)] public float _maxSpeedRatio = 0.5f;
        [FieldAttr(nst: 76, ctr: 68)] public float _forwardSpeedChangeThresholdLow = 50.0f;
        [FieldAttr(nst: 80, ctr: 72)] public float _forwardSpeedChangeThresholdHigh = 200.0f;
        [FieldAttr(nst: 84, ctr: 76)] public int _forwardSpeedHistoryCount = 5;
        [FieldAttr(nst: 88, ctr: 80)] public float[] _forwardSpeedHistory = new float[30];
        [FieldAttr(nst: 208, ctr: 200)] public int _historyCounter;
    }
}
