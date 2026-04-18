namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 88, align: 8)]
    public class igImage2 : igNamedObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public u16 _width;
        [FieldAttr(nst: 26, ctr: 26)] public u16 _height;
        [FieldAttr(nst: 28, ctr: 28)] public u16 _depth;
        [FieldAttr(nst: 30, ctr: 30)] public u16 _levelCount;
        [FieldAttr(nst: 32, ctr: 32)] public u16 _imageCount;
        [FieldAttr(nst: 40, ctr: 40)] public igMetaImage? _format;
        [FieldAttr(nst: 48, ctr: 48)] public uint _bitfield;
        [FieldAttr(nst: 52, ctr: 52)] public uint _userFlags;
        [FieldAttr(nst: 56, ctr: 56)] public igMemoryRef<u8> _data = new();
        [FieldAttr(nst: 72, ctr: 72)] public int _texHandle = -1;
        [FieldAttr(nst: 80, ctr: 80)] public igObject? _graphicsHelper;
    }
}
