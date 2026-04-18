namespace Alchemy
{
    [ObjectAttr(ctr: 136, align: 8)]
    public class CMultiplayerCrystalGrabComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public float _dropRadius;
        [FieldAttr(ctr: 20)] public float _dropRadiusMin;
        [FieldAttr(ctr: 24)] public float _dropGroundHeight;
        [FieldAttr(ctr: 28)] public float _groundCheckUpDistance;
        [FieldAttr(ctr: 32)] public float _groundCheckDownDistance;
        [FieldAttr(ctr: 36)] public float _wallCheckHeight;
        [FieldAttr(ctr: 40)] public float _wallDropOffset;
        [FieldAttr(ctr: 44)] public igVfxRangedCurveMetaField _popOutCurve = new();
        [FieldAttr(ctr: 128)] public float _popOutDuration;
    }
}
