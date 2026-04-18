namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class WranglerFire_Axe_DOTData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _DotDamageData = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _DotRemovedDamageData = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _EntityMessageVariable_id_vx3bour1_variable = new();
        [FieldAttr(nst: 64)] public float _DotDuration;
        [FieldAttr(nst: 68)] public float _DotInterval;
    }
}
