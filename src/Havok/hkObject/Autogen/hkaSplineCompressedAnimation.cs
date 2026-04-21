using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 176, ctr: 176)]
    public class hkaSplineCompressedAnimation : hkaAnimation
    {
        public override uint Hash => 0x8c3b5f7e;

        [FieldAttr(nst: 56, ctr: 56)] public int _numFrames;
        [FieldAttr(nst: 60, ctr: 60)] public int _numBlocks;
        [FieldAttr(nst: 64, ctr: 64)] public int _maxFramesPerBlock;
        [FieldAttr(nst: 68, ctr: 68)] public int _maskAndQuantizationSize;
        [FieldAttr(nst: 72, ctr: 72)] public float _blockDuration;
        [FieldAttr(nst: 76, ctr: 76)] public float _blockInverseDuration;
        [FieldAttr(nst: 80, ctr: 80)] public float _frameDuration;
        [FieldAttr(nst: 88, ctr: 88)] public hkMemory<uint> _blockOffsets;
        [FieldAttr(nst: 104, ctr: 104)] public hkMemory<uint> _floatBlockOffsets;
        [FieldAttr(nst: 120, ctr: 120)] public hkMemory<uint> _transformOffsets;
        [FieldAttr(nst: 136, ctr: 136)] public hkMemory<uint> _floatOffsets;
        [FieldAttr(nst: 152, ctr: 152)] public hkMemory<u8> _data;
        [FieldAttr(nst: 168, ctr: 168)] public int _endian;
    }
}