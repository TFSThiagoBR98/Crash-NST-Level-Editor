namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 8)]
    public class CEnvironmentMapData : igObject
    {
        [FieldAttr(ctr: 16)] public string? _environmentMap;
        [FieldAttr(ctr: 24)] public int _index;
        [FieldAttr(ctr: 32)] public igHandleMetaField _handleName = new();
        [FieldAttr(ctr: 72)] public igObjectDirectory? _environmentMapDirectory;
    }
}
