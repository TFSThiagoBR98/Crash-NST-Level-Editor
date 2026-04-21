using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 8, ctr: 8)]
    public class hkbVariableBounds : hkObject
    {
        public override uint Hash => 0x9b766364;

        [FieldAttr(nst: 0, ctr: 0)] public hkbVariableValue? _min;
        [FieldAttr(nst: 4, ctr: 4)] public hkbVariableValue? _max;
    }
}