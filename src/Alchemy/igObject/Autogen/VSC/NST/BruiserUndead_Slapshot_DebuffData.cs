namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class BruiserUndead_Slapshot_DebuffData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _Duration;
        [FieldAttr(nst: 44)] public float _MinTimeScale;
        [FieldAttr(nst: 48)] public float _MaxTimeScale;
        [FieldAttr(nst: 56)] public igHandleMetaField _DebuffVfx = new();
    }
}
