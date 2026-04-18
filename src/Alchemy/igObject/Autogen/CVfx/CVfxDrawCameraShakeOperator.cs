namespace Alchemy
{
    [ObjectAttr(nst: 160, ctr: 144, align: 8)]
    public class CVfxDrawCameraShakeOperator : igVfxDrawOperator
    {
        [FieldAttr(nst: 32, ctr: 20)] public igVfxRangedCurveMetaField _magnitude = new();
        [FieldAttr(nst: 116, ctr: 104)] public igRangedFloatMetaField _scale = new();
        [FieldAttr(nst: 124, ctr: 112)] public igRangedFloatMetaField _speed = new();
        [FieldAttr(nst: 132, ctr: 120)] public bool _isForceFeedbackEnabled = true;
        [FieldAttr(nst: 133, ctr: 121)] public bool _isFalloffEnabled = true;
        [FieldAttr(nst: 136, ctr: 124)] public igRangedFloatMetaField _innerRadius = new();
        [FieldAttr(nst: 144, ctr: 132)] public igRangedFloatMetaField _outerRadius = new();
        [FieldAttr(nst: 152, ctr: 140)] public uint _instanceData;
    }
}
