namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class OctaneCustomizationLockStatus_Root : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public bool _Bool_0x28;
        [FieldAttr(ctr: 41)] public bool _Bool_0x29;
        [FieldAttr(ctr: 48)] public string? _String = null;
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Placeable_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Gui_Placeable_0x40 = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Material = new();
    }
}
