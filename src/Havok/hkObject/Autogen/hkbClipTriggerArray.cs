using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 32, ctr: 32)]
    public class hkbClipTriggerArray : hkReferencedObject
    {
        public override uint Hash => 0xf757cd66;

        [FieldAttr(nst: 16, ctr: 16)] public hkMemory<hkbClipTrigger> _triggers;
    }
}