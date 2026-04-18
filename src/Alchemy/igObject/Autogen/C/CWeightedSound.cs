namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class CWeightedSound : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public string? _sound = null;
        [FieldAttr(nst: 24, ctr: 24)] public igHandleMetaField _soundHandle = new();
        [FieldAttr(nst: 32, ctr: 32)] public int _weight = 1;
    }
}
