namespace Alchemy
{
    [ObjectAttr(nst: 176, ctr: 176, align: 16)]
    public class igBitmapFont : igFont
    {
        [FieldAttr(nst: 80, ctr: 72)] public igCharMetricsList? _charMetricsList;
        [FieldAttr(nst: 88, ctr: 80)] public igCharMetricsList? _altCharMetricsList;
        [FieldAttr(nst: 96, ctr: 88)] public igKerningPairHashTable? _kerningPairs;
        [FieldAttr(nst: 104, ctr: 96)] public float _kernAmount = 1.0f;
        [FieldAttr(nst: 112, ctr: 104)] public igTextureBindAttr2? _textureBind;
        [FieldAttr(nst: 120, ctr: 112)] public igTextureBindAttr2? _altTextureBind;
        [FieldAttr(nst: 128, ctr: 120)] public bool _isMasksAndColor;
        [FieldAttr(nst: 132, ctr: 124)] public float _globalKerningLeft;
        [FieldAttr(nst: 136, ctr: 128)] public float _globalKerningRight;
        [FieldAttr(nst: 144, ctr: 136)] public igSizeTypeMetaField _textureResource = new();
        [FieldAttr(nst: 152, ctr: 144)] public igSizeTypeMetaField _altTextureResource = new();
        [FieldAttr(nst: 160, ctr: 152)] public igSizeTypeMetaField _samplerResource = new();
        [FieldAttr(nst: 168, ctr: 160)] public igSizeTypeMetaField _altSamplerResource = new();
        [FieldAttr(ctr: 168)] public igIntList? _bidiLevels;
    }
}
