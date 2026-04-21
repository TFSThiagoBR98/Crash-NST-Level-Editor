using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 152, ctr: 152)]
    public class hkbBehaviorReferenceGenerator : hkbGenerator
    {
        public override uint Hash => 0x154fcfaa;

        [FieldAttr(nst: 136, ctr: 136)] public string? _behaviorName;
        [FieldAttr(nst: 144, ctr: 144)] public hkbBehaviorGraph? _behavior;
    }
}