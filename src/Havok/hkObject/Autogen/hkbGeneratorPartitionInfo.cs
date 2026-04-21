using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 40, ctr: 40)]
    public class hkbGeneratorPartitionInfo : hkObject
    {
        public override uint Hash => 0xc5cf46e6;

        [FieldAttr(nst: 0, ctr: 0)] public uint _boneMask_0;
        [FieldAttr(nst: 4, ctr: 4)] public uint _boneMask_1;
        [FieldAttr(nst: 8, ctr: 8)] public uint _boneMask_2;
        [FieldAttr(nst: 12, ctr: 12)] public uint _boneMask_3;
        [FieldAttr(nst: 16, ctr: 16)] public uint _boneMask_4;
        [FieldAttr(nst: 20, ctr: 20)] public uint _boneMask_5;
        [FieldAttr(nst: 24, ctr: 24)] public uint _boneMask_6;
        [FieldAttr(nst: 28, ctr: 28)] public uint _boneMask_7;
        [FieldAttr(nst: 32, ctr: 32)] public uint _partitionMask;
        [FieldAttr(nst: 36, ctr: 36)] public i16 _numBones;
        [FieldAttr(nst: 38, ctr: 38)] public i16 _numMaxPartitions;
    }
}