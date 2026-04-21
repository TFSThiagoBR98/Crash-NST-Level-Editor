using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 40, ctr: 40)]
    public class hkbVariableBindingSetBinding : hkObject
    {
        public override uint Hash => 0x4d592f72;

        [FieldAttr(nst: 0, ctr: 0)] public string? _memberPath;
        [FieldAttr(nst: 8, ctr: 8)] public uint _memberClass;
        [FieldAttr(nst: 16, ctr: 16)] public int _offsetInObjectPlusOne;
        [FieldAttr(nst: 20, ctr: 20)] public int _offsetInArrayPlusOne;
        [FieldAttr(nst: 24, ctr: 24)] public int _rootVariableIndex;
        [FieldAttr(nst: 28, ctr: 28)] public int _variableIndex;
        [FieldAttr(nst: 32, ctr: 32)] public i8 _bitIndex;
        [FieldAttr(nst: 33, ctr: 33)] public EBindingType _bindingType;
        [FieldAttr(nst: 34, ctr: 34)] public EType _memberType;
        [FieldAttr(nst: 35, ctr: 35)] public i8 _variableType;
        [FieldAttr(nst: 36, ctr: 36)] public EInternalBindingFlags _flags;
    }
}