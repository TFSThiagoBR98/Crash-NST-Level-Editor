namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 64, align: 8)]
    public class CSplineConvergeWithinLocalOffsetAttachBehavior : CSplineAttachBehavior
    {
        [FieldAttr(nst: 24, ctr: 16)] public float _convergeRatio = 0.3f;
        [FieldAttr(nst: 28, ctr: 20)] public bool _convergeX = true;
        [FieldAttr(nst: 32, ctr: 24)] public float _convergeOffsetX = 100.0f;
        [FieldAttr(nst: 36, ctr: 28)] public bool _convergeY = true;
        [FieldAttr(nst: 40, ctr: 32)] public float _convergeOffsetY = 100.0f;
        [FieldAttr(nst: 44, ctr: 36)] public bool _convergeZ = true;
        [FieldAttr(nst: 48, ctr: 40)] public float _convergeOffsetZ = 100.0f;
        [FieldAttr(nst: 52, ctr: 44)] public bool _convergeCompleted;
        [FieldAttr(nst: 56, ctr: 48)] public igVec3fMetaField _startAxesOffset = new();
    }
}
