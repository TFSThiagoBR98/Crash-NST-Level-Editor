namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Octane_EndBattleCamera_ManagerData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Camera_Base_0x20 = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Camera_Base_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Camera_Base_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Component_Data = new();
        [FieldAttr(ctr: 64)] public float _Float;
    }
}
