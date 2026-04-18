namespace Alchemy
{
    [ObjectAttr(nst: 160, align: 8)]
    public class CSetGameSpeedMessage : CEntityMessage
    {
        [FieldAttr(nst: 56)] public float _speed = 1.0f;
        [FieldAttr(nst: 60)] public float _timeInSeconds;
        [FieldAttr(nst: 64)] public igVfxRangedCurveMetaField _gameSpeedCurve = new();
        [FieldAttr(nst: 152)] public igStringRefList? _volumeGroupsToPitch;
    }
}
