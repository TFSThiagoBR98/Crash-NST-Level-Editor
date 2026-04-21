using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 40, ctr: 40)]
    public class hkbVariableBindingSet : hkReferencedObject
    {
        public override uint Hash => 0xe942f339;

        [FieldAttr(nst: 16, ctr: 16)] public hkMemory<hkbVariableBindingSetBinding> _bindings;
        [FieldAttr(nst: 32, ctr: 32)] public int _indexOfBindingToEnable;
        [FieldAttr(nst: 36, ctr: 36)] public bool _hasOutputBinding;
        [FieldAttr(nst: 37, ctr: 37)] public bool _initializedOffsets;
    }
}