using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 88, ctr: 88)]
    public class hkbModifier : hkbNode
    {
        public override uint Hash => 0xc811e80c;

        [FieldAttr(nst: 80, ctr: 80)] public bool _enable;
        [FieldAttr(nst: 81, ctr: 81)] public bool _padModifier_0;
        [FieldAttr(nst: 82, ctr: 82)] public bool _padModifier_1;
        [FieldAttr(nst: 83, ctr: 83)] public bool _padModifier_2;
    }
}