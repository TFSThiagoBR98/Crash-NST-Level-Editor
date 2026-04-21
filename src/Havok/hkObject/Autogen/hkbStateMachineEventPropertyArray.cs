using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 32, ctr: 32)]
    public class hkbStateMachineEventPropertyArray : hkReferencedObject
    {
        public override uint Hash => 0x71957c2d;

        [FieldAttr(nst: 16, ctr: 16)] public hkMemory<hkbEventProperty> _events;
    }
}