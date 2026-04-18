namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 8)]
    public class CAudioGraphDriverModeSeaExpedition : CAudioGraphDriverMode
    {
        [FieldAttr(nst: 56)] public float _defaultEngineValue = 0.2f;
        [FieldAttr(nst: 60)] public float _ascendingEngineValue = 0.8f;
        [FieldAttr(nst: 64)] public float _maxEngineValueChangePerSecond = 1.0f;
        [FieldAttr(nst: 68)] public float _currentEngineValue;
    }
}
