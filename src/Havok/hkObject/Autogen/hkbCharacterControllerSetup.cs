using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 40, ctr: 40)]
    public class hkbCharacterControllerSetup : hkObject
    {
        public override uint Hash => 0xaf5f7339;

        [FieldAttr(nst: 0, ctr: 0)] public hkbRigidBodySetup? _rigidBodySetup;
        [FieldAttr(nst: 32, ctr: 32)] public hkReferencedObject? _controllerCinfo;
    }
}