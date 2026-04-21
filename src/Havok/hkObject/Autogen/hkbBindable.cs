using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 48, ctr: 48)]
    public class hkbBindable : hkReferencedObject
    {
        public override uint Hash => 0x654ce763;

        [FieldAttr(nst: 16, ctr: 16)] public hkbVariableBindingSet? _variableBindingSet;
        [FieldAttr(nst: 24, ctr: 24)] public hkMemory<hkbBindable> _cachedBindables;
        [FieldAttr(nst: 40, ctr: 40)] public bool _areBindablesCached;
        [FieldAttr(nst: 41, ctr: 41)] public bool _hasEnableChanged;
    }
}