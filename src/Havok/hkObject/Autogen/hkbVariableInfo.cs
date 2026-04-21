using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 6, ctr: 6)]
    public class hkbVariableInfo : hkObject
    {
        public override uint Hash => 0xa5ae6be2;

        [FieldAttr(nst: 0, ctr: 0)] public hkbRoleAttribute? _role;
        [FieldAttr(nst: 4, ctr: 4)] public EVariableType _type;
    }
}