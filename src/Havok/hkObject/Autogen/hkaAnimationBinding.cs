using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 88, ctr: 88)]
    public class hkaAnimationBinding : hkReferencedObject
    {
        public override uint Hash => 0xfaf9150;

        [FieldAttr(nst: 16, ctr: 16)] public string? _originalSkeletonName;
        [FieldAttr(nst: 24, ctr: 24)] public hkaAnimation? _animation;
        [FieldAttr(nst: 32, ctr: 32)] public hkMemory<i16> _transformTrackToBoneIndices;
        [FieldAttr(nst: 48, ctr: 48)] public hkMemory<i16> _floatTrackToFloatSlotIndices;
        [FieldAttr(nst: 64, ctr: 64)] public hkMemory<i16> _partitionIndices;
        [FieldAttr(nst: 80, ctr: 80)] public EBlendHint _blendHint;
    }
}