namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CKartAnimComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public bool _scaleFeetDown;
        [FieldAttr(ctr: 20)] public float _wheelsRadius;
        [FieldAttr(ctr: 24)] public float _wheelsYawAnimLerpSpeedFactor;
        [FieldAttr(ctr: 28)] public float _hubSwirlRecenterTotalDuration;
        [FieldAttr(ctr: 32)] public float _hubSwirlRecenterInDuration;
        [FieldAttr(ctr: 36)] public float _hubSwirlRecenterOutDuration;
    }
}
