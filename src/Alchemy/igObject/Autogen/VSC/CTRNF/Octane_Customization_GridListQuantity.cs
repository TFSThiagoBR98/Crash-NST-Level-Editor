namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Customization_GridListQuantity : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public int _Int_0x28;
        [FieldAttr(ctr: 44)] public int _Int_0x2c;
        [FieldAttr(ctr: 48)] public igHandleMetaField _Localized_String = new();
        [FieldAttr(ctr: 56)] public string? _String = null;
    }
}
