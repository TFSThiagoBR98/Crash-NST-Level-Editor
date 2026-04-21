using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 80, ctr: 80)]
    public class hkaMeshBinding : hkReferencedObject
    {
        public override uint Hash => 0x32b0ecb6;

        [FieldAttr(nst: 16, ctr: 16)] public hkxMesh? _mesh;
        [FieldAttr(nst: 24, ctr: 24)] public string? _originalSkeletonName;
        [FieldAttr(nst: 32, ctr: 32)] public string? _name;
        [FieldAttr(nst: 40, ctr: 40)] public hkaSkeleton? _skeleton;
        [FieldAttr(nst: 48, ctr: 48)] public hkMemory<hkaMeshBindingMapping> _mappings;
        [FieldAttr(nst: 64, ctr: 64)] public hkMemory<Matrix4x4> _boneFromSkinMeshTransforms;
    }
}