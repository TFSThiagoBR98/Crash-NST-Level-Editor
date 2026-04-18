namespace Alchemy
{
    [ObjectAttr(nst: 224, ctr: 224, align: 16)]
    public class CGuiMaterial : igFxMaterial
    {
        [ObjectAttr(size: 4)]
        public class Bitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _textureCompression_diffuse;
            [FieldAttr(offset: 1, size: 1)] public bool _textureMips_diffuse;
            [FieldAttr(offset: 2, size: 1)] public bool _textureAllowDownsample_diffuse;
        }

        [FieldAttr(nst: 120, ctr: 120)] public u8 _bfStorage__0;
        [FieldAttr(nst: 124, ctr: 124)] public Bitfield _bitfield = new();
        [FieldAttr(nst: 128, ctr: 128)] public u8 _bfStorage__1;
        [FieldAttr(nst: 136, ctr: 136)] public string? _textureName_diffuse = null;
        [FieldAttr(nst: 144, ctr: 144)] public igMatrix44fMetaField _textureTransform = new();
        [FieldAttr(nst: 208, ctr: 208)] public string? _textureName = null;
    }
}
