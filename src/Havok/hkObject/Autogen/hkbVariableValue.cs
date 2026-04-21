using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 4, ctr: 4)]
    public class hkbVariableValue : hkObject
    {
        public override uint Hash => 0xb99bd6a;

        [FieldAttr(nst: 0, ctr: 0)] public int _value;
    }
}