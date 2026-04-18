namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Prehistoric_Hazard_GrassData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Damage_Data = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Game_Bool_Variable = new();
    }
}
