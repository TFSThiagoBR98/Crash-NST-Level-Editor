namespace Alchemy
{
    [ObjectAttr(nst: 208, ctr: 208, align: 16)]
    public class CCloudParticleSortedMaterial : igFxMaterial
    {
        [ObjectAttr(size: 4)]
        public class TextureBitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _textureCompression_diffuse;
            [FieldAttr(offset: 1, size: 1)] public bool _textureMips_diffuse;
            [FieldAttr(offset: 2, size: 1)] public bool _textureAllowDownsample_diffuse;
        }

        [FieldAttr(nst: 120, ctr: 120)] public TextureBitfield _textureBitfield = new();
        [FieldAttr(nst: 128, ctr: 128)] public string? _textureName_diffuse = null;
        [FieldAttr(nst: 144, ctr: 144)] public igVec4fMetaField _color = new();
        [FieldAttr(nst: 160, ctr: 160)] public igVec4fMetaField _rotationParams = new();
        [FieldAttr(nst: 176, ctr: 176)] public float _minRotationSpeed;
        [FieldAttr(nst: 180, ctr: 180)] public float _maxRotationSpeed;
        [FieldAttr(nst: 184, ctr: 184)] public float _particleSoftness = 100.0f;
        [FieldAttr(nst: 188, ctr: 188)] public float _particleSoftnessInverse;
        [FieldAttr(nst: 192, ctr: 192)] public bool _softParticle;
    }
}
