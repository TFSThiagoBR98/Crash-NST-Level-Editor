namespace Alchemy
{
    [ObjectAttr(nst: 152, ctr: 152, align: 8)]
    public class igDynamicBuffer : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igMemoryRef<u8>[] _buffer = new igMemoryRef<u8>[3];
        [FieldAttr(nst: 64, ctr: 64)] public igSizeTypeMetaField[] _resource = new igSizeTypeMetaField[3];
        [FieldAttr(nst: 88, ctr: 88)] public igDeferredDynamicBufferSwapMetaField[] _deferredSwap = new igDeferredDynamicBufferSwapMetaField[2];
        [FieldAttr(nst: 136, ctr: 136)] public uint _deferredSwapIndex;
        [FieldAttr(nst: 140, ctr: 140)] public uint _offset;
        [FieldAttr(nst: 144, ctr: 144)] public uint _alignment;
        [FieldAttr(nst: 148, ctr: 148)] public bool _tripleBuffer;
    }
}
