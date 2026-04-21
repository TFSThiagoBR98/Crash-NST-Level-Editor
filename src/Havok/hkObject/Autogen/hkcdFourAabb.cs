using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 96, ctr: 96)]
    public class hkcdFourAabb : hkObject
    {
        public override uint Hash => 0xad9bb6f1;

        [FieldAttr(nst: 0, ctr: 0)] public Vector4 _lx;
        [FieldAttr(nst: 16, ctr: 16)] public Vector4 _hx;
        [FieldAttr(nst: 32, ctr: 32)] public Vector4 _ly;
        [FieldAttr(nst: 48, ctr: 48)] public Vector4 _hy;
        [FieldAttr(nst: 64, ctr: 64)] public Vector4 _lz;
        [FieldAttr(nst: 80, ctr: 80)] public Vector4 _hz;
    }
}