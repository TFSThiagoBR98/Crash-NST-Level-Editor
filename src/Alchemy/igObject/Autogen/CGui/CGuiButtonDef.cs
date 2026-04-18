namespace Alchemy
{
    [ObjectAttr(ctr: 192, align: 8)]
    public class CGuiButtonDef : igGuiListItem
    {
        [FieldAttr(ctr: 128)] public string? _label2;
        [FieldAttr(ctr: 136)] public igHandleMetaField _iconBase = new();
        [FieldAttr(ctr: 144)] public igHandleMetaField _iconBaseAdditive = new();
        [FieldAttr(ctr: 152)] public igHandleMetaField _icon = new();
        [FieldAttr(ctr: 160)] public int _category;
        [FieldAttr(ctr: 164)] public int _id;
        [FieldAttr(ctr: 168)] public int _param;
        [FieldAttr(ctr: 172)] public int _paramExtra;
        [FieldAttr(ctr: 176)] public int _attention;
        [FieldAttr(ctr: 180)] public int _status;
        [FieldAttr(ctr: 184)] public bool _enableRandom;
    }
}
