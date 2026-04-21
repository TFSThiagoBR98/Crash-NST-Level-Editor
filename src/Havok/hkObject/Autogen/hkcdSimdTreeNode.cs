using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 112, ctr: 112)]
    public class hkcdSimdTreeNode : hkcdFourAabb
    {
        public override uint Hash => 0xc4e406c7;

        [FieldAttr(nst: 96, ctr: 96)] public uint _data_0;
        [FieldAttr(nst: 100, ctr: 100)] public uint _data_1;
        [FieldAttr(nst: 104, ctr: 104)] public uint _data_2;
        [FieldAttr(nst: 108, ctr: 108)] public uint _data_3;
    }
}