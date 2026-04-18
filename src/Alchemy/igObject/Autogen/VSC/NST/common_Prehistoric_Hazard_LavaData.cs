namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Prehistoric_Hazard_LavaData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Collision_Material = new();
        [FieldAttr(nst: 48)] public string? _CrashDeath = null;
        [FieldAttr(nst: 56)] public bool _Bool;
    }
}
