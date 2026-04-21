using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 136, ctr: 136)]
    public class hkbGenerator : hkbNode
    {
        public override uint Hash => 0xad634f7e;

        [FieldAttr(nst: 80, ctr: 80)] public hkbGeneratorPartitionInfo? _partitionInfo;
        [FieldAttr(nst: 120, ctr: 120)] public uint _syncInfo;
    }
}