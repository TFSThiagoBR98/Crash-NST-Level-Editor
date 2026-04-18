namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class igDebugGeometryDrawCall : igDrawCall
    {
        [FieldAttr(nst: 24, ctr: 16)] public igRawRefMetaField _data = new();
        [FieldAttr(nst: 32, ctr: 24, refCount: false)] public igMemoryCommandStream? _state;
    }
}
