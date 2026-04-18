namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 8)]
    public class igBufferedFile : igFile
    {
        [FieldAttr(ctr: 36)] public EMode _lastOperation;
        [FieldAttr(ctr: 40)] public igMemoryRef<u8> _buffer = new();
        [FieldAttr(ctr: 56)] public i64 _bufferPos;
        [FieldAttr(ctr: 64)] public i64 _bufferLen;
        [FieldAttr(ctr: 72)] public uint _mode;
    }
}
