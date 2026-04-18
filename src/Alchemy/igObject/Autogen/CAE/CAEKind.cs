namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CAEKind : igObject
    {
        [FieldAttr(ctr: 12)] public uint _id;
        [FieldAttr(ctr: 16)] public string? _name;
        [FieldAttr(ctr: 24)] public bool _isLoaded;
    }
}
