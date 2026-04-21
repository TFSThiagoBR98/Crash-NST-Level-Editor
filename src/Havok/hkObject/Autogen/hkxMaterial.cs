using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 224, ctr: 224)]
    public class hkxMaterial : hkxAttributeHolder
    {
        public override uint Hash => 0x785ec362;

        [FieldAttr(nst: 32, ctr: 32)] public string? _name;
        [FieldAttr(nst: 40, ctr: 40)] public hkMemory<hkxMaterialTextureStage> _stages;
        [FieldAttr(nst: 64, ctr: 64)] public Vector4 _diffuseColor;
        [FieldAttr(nst: 80, ctr: 80)] public Vector4 _ambientColor;
        [FieldAttr(nst: 96, ctr: 96)] public Vector4 _specularColor;
        [FieldAttr(nst: 112, ctr: 112)] public Vector4 _emissiveColor;
        [FieldAttr(nst: 128, ctr: 128)] public hkMemory<hkxMaterial> _subMaterials;
        [FieldAttr(nst: 144, ctr: 144)] public hkReferencedObject? _extraData;
        [FieldAttr(nst: 152, ctr: 152)] public float _uvMapScale_0;
        [FieldAttr(nst: 156, ctr: 156)] public float _uvMapScale_1;
        [FieldAttr(nst: 160, ctr: 160)] public float _uvMapOffset_0;
        [FieldAttr(nst: 164, ctr: 164)] public float _uvMapOffset_1;
        [FieldAttr(nst: 168, ctr: 168)] public float _uvMapRotation;
        [FieldAttr(nst: 172, ctr: 172)] public EUVMappingAlgorithm _uvMapAlgorithm;
        [FieldAttr(nst: 176, ctr: 176)] public float _specularMultiplier;
        [FieldAttr(nst: 180, ctr: 180)] public float _specularExponent;
        [FieldAttr(nst: 184, ctr: 184)] public ETransparency _transparency;
        [FieldAttr(nst: 192, ctr: 192)] public u64 _userData;
        [FieldAttr(nst: 200, ctr: 200)] public hkMemory<hkxMaterialProperty> _properties;
    }
}