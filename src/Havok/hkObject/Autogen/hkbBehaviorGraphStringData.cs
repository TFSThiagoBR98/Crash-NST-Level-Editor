using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 80, ctr: 80)]
    public class hkbBehaviorGraphStringData : hkReferencedObject
    {
        public override uint Hash => 0x1bd27f38;

        [FieldAttr(nst: 16, ctr: 16)] public hkMemory<string> _eventNames;
        [FieldAttr(nst: 32, ctr: 32)] public hkMemory<string> _attributeNames;
        [FieldAttr(nst: 48, ctr: 48)] public hkMemory<string> _variableNames;
        [FieldAttr(nst: 64, ctr: 64)] public hkMemory<string> _characterPropertyNames;
    }
}