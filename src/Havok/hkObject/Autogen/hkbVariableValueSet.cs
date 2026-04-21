using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 64, ctr: 64)]
    public class hkbVariableValueSet : hkReferencedObject
    {
        public override uint Hash => 0xeb5f7e25;

        [FieldAttr(nst: 16, ctr: 16)] public hkMemory<hkbVariableValue> _wordVariableValues;
        [FieldAttr(nst: 32, ctr: 32)] public hkMemory<Vector4> _quadVariableValues;
        [FieldAttr(nst: 48, ctr: 48)] public hkMemory<hkReferencedObject> _variantVariableValues;
    }
}