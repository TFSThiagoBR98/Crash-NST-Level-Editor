namespace Alchemy
{
    [ObjectAttr(ctr: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Octane_MinimapData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public float _Float;
        [FieldAttr(ctr: 36)] public igVec2fMetaField _Vec_2F_0x24 = new();
        [FieldAttr(ctr: 44)] public igVec2fMetaField _Vec_2F_0x2c = new();
        [FieldAttr(ctr: 52)] public igVec2fMetaField _Vec_2F_0x34 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Fx_Material = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Gui_Project = new();
        [FieldAttr(ctr: 80)] public ERacingMinimapDirection _E_Racing_Minimap_Direction;
    }
}
