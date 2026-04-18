namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CCreditsLine : igObject
    {
        [FieldAttr(ctr: 12)] public EOctaneCreditsLineType _lineType;
        [FieldAttr(ctr: 16)] public string? _header;
        [FieldAttr(ctr: 24)] public igHandleMetaField _image = new();
        [FieldAttr(ctr: 32)] public CCreditsName? _leftName;
        [FieldAttr(ctr: 40)] public CCreditsName? _centerName;
        [FieldAttr(ctr: 48)] public CCreditsName? _rightName;
    }
}
