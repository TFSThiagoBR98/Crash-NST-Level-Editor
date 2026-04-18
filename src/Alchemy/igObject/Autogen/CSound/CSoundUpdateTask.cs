namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CSoundUpdateTask : igObject
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _sound = new();
        [FieldAttr(ctr: 24)] public igHandleMetaField _owner = new();
    }
}
