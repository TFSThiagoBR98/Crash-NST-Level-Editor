namespace Alchemy
{
    [ObjectAttr(ctr: 120, align: 4, metaType: typeof(CVscComponentData))]
    public class common_TrackingMissileData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Sound = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Vfx_Effect_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Vfx_Effect_0x30 = new();
        [FieldAttr(ctr: 56)] public int _Int;
        [FieldAttr(ctr: 64)] public igHandleMetaField _Component_Data = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Vfx_Effect_0x48 = new();
        [FieldAttr(ctr: 80)] public igHandleMetaField _common_BombDatas008 = new();
        [FieldAttr(ctr: 88)] public igHandleMetaField _Vfx_Effect_0x58 = new();
        [FieldAttr(ctr: 96)] public igHandleMetaField _Vfx_Effect_0x60 = new();
        [FieldAttr(ctr: 104)] public igHandleMetaField _Bolt_Point_0x68 = new();
        [FieldAttr(ctr: 112)] public igHandleMetaField _Bolt_Point_0x70 = new();
    }
}
