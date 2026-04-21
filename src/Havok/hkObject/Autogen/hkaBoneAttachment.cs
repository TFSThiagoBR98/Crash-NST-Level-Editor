using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 128, ctr: 128)]
    public class hkaBoneAttachment : hkReferencedObject
    {
        public override uint Hash => 0xb566faa5;

        [FieldAttr(nst: 16, ctr: 16)] public string? _originalSkeletonName;
        [FieldAttr(nst: 32, ctr: 32)] public Matrix4x4 _boneFromAttachment;
        [FieldAttr(nst: 96, ctr: 96)] public hkReferencedObject? _attachment;
        [FieldAttr(nst: 104, ctr: 104)] public string? _name;
        [FieldAttr(nst: 112, ctr: 112)] public i16 _boneIndex;
    }
}