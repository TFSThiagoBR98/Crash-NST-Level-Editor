namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class CSoundHandleOrName : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igHandleMetaField _soundHandle = new();
        [FieldAttr(nst: 24, ctr: 24)] public string? _soundName = null;
    }
}
