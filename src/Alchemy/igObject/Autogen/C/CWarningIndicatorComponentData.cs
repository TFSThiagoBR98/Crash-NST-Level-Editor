namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 8)]
    public class CWarningIndicatorComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public igHandleMetaField _warningEffect = new();
        [FieldAttr(nst: 32)] public CBoltPoint? _warningEffectBolt;
        [FieldAttr(nst: 40)] public CQueryFilter? _filterTargets;
        [FieldAttr(nst: 48)] public float _filterTargetingAngleRange;
    }
}
