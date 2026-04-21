using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 240, ctr: 240)]
    public class hkbCharacterData : hkReferencedObject
    {
        public override uint Hash => 0xfec46c1f;

        [FieldAttr(nst: 16, ctr: 16)] public hkbCharacterControllerSetup? _characterControllerSetup;
        [FieldAttr(nst: 64, ctr: 64)] public Vector4 _modelUpMS;
        [FieldAttr(nst: 80, ctr: 80)] public Vector4 _modelForwardMS;
        [FieldAttr(nst: 96, ctr: 96)] public Vector4 _modelRightMS;
        [FieldAttr(nst: 112, ctr: 112)] public hkMemory<hkbVariableInfo> _characterPropertyInfos;
        [FieldAttr(nst: 128, ctr: 128)] public hkMemory<int> _numBonesPerLod;
        [FieldAttr(nst: 144, ctr: 144)] public hkbVariableValueSet? _characterPropertyValues;
        [FieldAttr(nst: 152, ctr: 152)] public hkbFootIkDriverInfo? _footIkDriverInfo;
        [FieldAttr(nst: 160, ctr: 160)] public hkbHandIkDriverInfo? _handIkDriverInfo;
        [FieldAttr(nst: 168, ctr: 168)] public hkReferencedObject? _aiControlDriverInfo;
        [FieldAttr(nst: 176, ctr: 176)] public hkbCharacterStringData? _stringData;
        [FieldAttr(nst: 184, ctr: 184)] public hkbMirroredSkeletonInfo? _mirroredSkeletonInfo;
        [FieldAttr(nst: 192, ctr: 192)] public hkMemory<i16> _boneAttachmentBoneIndices;
        [FieldAttr(nst: 208, ctr: 208)] public hkMemory<Matrix4x4> _boneAttachmentTransforms;
        [FieldAttr(nst: 224, ctr: 224)] public float _scale;
        [FieldAttr(nst: 228, ctr: 228)] public i16 _numHands;
        [FieldAttr(nst: 230, ctr: 230)] public i16 _numFloatSlots;
    }
}