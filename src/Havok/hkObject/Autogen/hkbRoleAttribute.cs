using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 4, ctr: 4)]
    public class hkbRoleAttribute : hkObject
    {
        public override uint Hash => 0xfecef669;

        [FieldAttr(nst: 0, ctr: 0)] public ERole _role;
        [FieldAttr(nst: 2, ctr: 2)] public ERoleFlags _flags;
    }
}