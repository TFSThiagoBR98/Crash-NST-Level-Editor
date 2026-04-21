using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 272, ctr: 272)]
    public class hknpRefWorldCinfo : hkReferencedObject
    {
        public override uint Hash => 0xfbaaa6df;

        [FieldAttr(nst: 16, ctr: 16)] public hknpWorldCinfo? _info;
    }
}