namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Team_Faction_Material_OverrideData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Faction2MaterialOverride = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Faction1MaterialOverride = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _FxMaterial_Neutral = new();
    }
}
