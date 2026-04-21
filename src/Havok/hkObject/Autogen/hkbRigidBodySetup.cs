using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 32, ctr: 32)]
    public class hkbRigidBodySetup : hkObject
    {
        public override uint Hash => 0x3b082f95;

        [FieldAttr(nst: 0, ctr: 0)] public uint _collisionFilterInfo;
        [FieldAttr(nst: 4, ctr: 4)] public EType _type;
        [FieldAttr(nst: 8, ctr: 8)] public hkbShapeSetup? _shapeSetup;
    }
}