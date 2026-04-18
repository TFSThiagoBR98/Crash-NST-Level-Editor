namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class igMetaImage : igObject
    {
        [ObjectAttr(size: 1)]
        public class Properties : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _isTile;
            [FieldAttr(offset: 1, size: 1)] public bool _isCanonical;
            [FieldAttr(offset: 2, size: 1)] public bool _isCompressed;
            [FieldAttr(offset: 3, size: 1)] public bool _hasPalette;
            [FieldAttr(offset: 4, size: 1)] public bool _isSrgb;
            [FieldAttr(offset: 5, size: 1)] public bool _isFloatingPoint;
        }

        [FieldAttr(nst: 16, ctr: 16, refCount: false)] public igMetaImage? _canonical;
        [FieldAttr(nst: 24, ctr: 24)] public Properties _properties = new();
        [FieldAttr(ctr: 25)] public u8 _blockWidth;
        [FieldAttr(ctr: 26)] public u8 _blockHeight;
        [FieldAttr(nst: 32, ctr: 32)] public string? _name = null;
        [FieldAttr(nst: 40, ctr: 40)] public u8 _bitsPerPixel;
        [FieldAttr(nst: 48, ctr: 48)] public igNonRefCountedMetaImageList? _formats;
        [FieldAttr(nst: 56, ctr: 56)] public igImage2ConvertFunctionList? _functions;
    }
}
