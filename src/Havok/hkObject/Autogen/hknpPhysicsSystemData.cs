using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 120, ctr: 120)]
    public class hknpPhysicsSystemData : hkReferencedObject
    {
        public override uint Hash => 0xb857718b;

        [FieldAttr(nst: 16, ctr: 16)] public hkMemory<hknpMaterial> _materials;
        [FieldAttr(nst: 32, ctr: 32)] public hkMemory<hknpMotionProperties> _motionProperties;
        [FieldAttr(nst: 48, ctr: 48)] public hkMemory<hknpMotionCinfo> _motionCinfos;
        [FieldAttr(nst: 64, ctr: 64)] public hkMemory<hknpBodyCinfo> _bodyCinfos;
        [FieldAttr(nst: 80, ctr: 80)] public hkMemory<hknpConstraintCinfo> _constraintCinfos;
        [FieldAttr(nst: 96, ctr: 96)] public hkMemory<hkReferencedObject> _referencedObjects;
        [FieldAttr(nst: 112, ctr: 112)] public string? _name;
    }
}