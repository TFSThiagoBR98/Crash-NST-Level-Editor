namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class igCommandStream : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public u8 _writeHead = new();
        [FieldAttr(nst: 24, ctr: 24)] public u8 _writeChunkBegin = new();
        [FieldAttr(nst: 32, ctr: 32)] public u8 _writeChunkEnd = new();
        [FieldAttr(nst: 40, ctr: 40)] public u8 _readHead = new();
        [FieldAttr(nst: 48, ctr: 48)] public u8 _readChunkBegin = new();
        [FieldAttr(nst: 56, ctr: 56)] public u8 _readChunkEnd = new();
    }
}
