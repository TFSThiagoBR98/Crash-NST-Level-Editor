namespace Alchemy
{
    [ObjectAttr(ctr: 128, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Minimap_HUB_Race_Pad_Icon : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Animation_Tag_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Gui_Animation_Tag_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Animation_Tag_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Gui_Animation_Tag_0x40 = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Gui_Animation_Tag_0x48 = new();
        [FieldAttr(ctr: 80)] public igHandleMetaField _Gui_Animation_Tag_0x50 = new();
        [FieldAttr(ctr: 88)] public EZoneCollectibleType _E_Zone_Collectible_Type_0x58;
        [FieldAttr(ctr: 96)] public igHandleMetaField _Gui_Animation_Tag_0x60 = new();
        [FieldAttr(ctr: 104)] public bool _Bool;
        [FieldAttr(ctr: 108)] public int _Int;
        [FieldAttr(ctr: 112)] public igHandleMetaField _Entity = new();
        [FieldAttr(ctr: 120)] public EZoneCollectibleType _E_Zone_Collectible_Type_0x78;
        [FieldAttr(ctr: 124)] public EZoneCollectibleType _E_Zone_Collectible_Type_0x7c;
    }
}
