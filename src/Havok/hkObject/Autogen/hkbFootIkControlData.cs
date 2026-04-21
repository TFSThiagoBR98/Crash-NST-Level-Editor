using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 80, ctr: 80)]
    public class hkbFootIkControlData : hkObject
    {
        public override uint Hash => 0x7f18a9a6;

        [FieldAttr(nst: 0, ctr: 0)] public hkbFootIkGains? _gains;
        [FieldAttr(nst: 40, ctr: 40)] public hkMemory<uint> _mem;
        [FieldAttr(nst: 56, ctr: 56)] public int _unk0;
        [FieldAttr(nst: 60, ctr: 60)] public int _unk1;
        [FieldAttr(nst: 64, ctr: 64)] public int _unk2;
        [FieldAttr(nst: 68, ctr: 68)] public int _unk3;
        [FieldAttr(nst: 72, ctr: 72)] public int _unk4;
        [FieldAttr(nst: 76, ctr: 76)] public int _unk5;
    }
}