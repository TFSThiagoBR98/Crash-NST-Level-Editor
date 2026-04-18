namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CKartCustomizationGroup : igObject
    {
        [FieldAttr(ctr: 12)] public int _groupIndex;
        [FieldAttr(ctr: 16)] public string? _groupName;
        [FieldAttr(ctr: 24)] public EKartStickerFilterGroup _filterGroup;
    }
}
