namespace Alchemy
{
    [ObjectAttr(ctr: 160, align: 4, metaType: typeof(CVscComponentData))]
    public class carnivorous_plant_behaviorData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Kart_Max_Speed_Modifier_Data = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Player_Start_Entity_Handle_List = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Camera_Base_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Bolt_Point_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Vfx_Effect_0x40 = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Vfx_Effect_0x48 = new();
        [FieldAttr(ctr: 80)] public igHandleMetaField _Vfx_Effect_0x50 = new();
        [FieldAttr(ctr: 88)] public igHandleMetaField _Bolt_Point_0x58 = new();
        [FieldAttr(ctr: 96)] public igHandleMetaField _Entity = new();
        [FieldAttr(ctr: 104)] public igHandleMetaField _Sound = new();
        [FieldAttr(ctr: 112)] public igHandleMetaField _Camera_Base_0x70 = new();
        [FieldAttr(ctr: 120)] public igHandleMetaField _Rumble_Data = new();
        [FieldAttr(ctr: 128)] public igHandleMetaField _Camera = new();
        [FieldAttr(ctr: 136)] public igHandleMetaField _Bolt_Point_List = new();
        [FieldAttr(ctr: 144)] public igHandleMetaField _Bolt_Point_0x90 = new();
        [FieldAttr(ctr: 152)] public int _Int;
    }
}
