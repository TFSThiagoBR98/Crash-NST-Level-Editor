namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CCharacter : igObject
    {
        [FieldAttr(ctr: 12)] public EState _state;
        [FieldAttr(ctr: 16)] public string? _name;
        [FieldAttr(ctr: 24)] public int _loadCount;
        [FieldAttr(ctr: 32)] public igObject? _chunk;
    }
}
