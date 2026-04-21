using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 112, ctr: 112)]
    public class hkbBehaviorGraphData : hkReferencedObject
    {
        public override uint Hash => 0x907a8222;

        [FieldAttr(nst: 16, ctr: 16)] public hkMemory<float> _attributeDefaults;
        [FieldAttr(nst: 32, ctr: 32)] public hkMemory<hkbVariableInfo> _variableInfos;
        [FieldAttr(nst: 48, ctr: 48)] public hkMemory<hkbVariableInfo> _characterPropertyInfos;
        [FieldAttr(nst: 64, ctr: 64)] public hkMemory<hkbEventInfo> _eventInfos;
        [FieldAttr(nst: 80, ctr: 80)] public hkMemory<hkbVariableBounds> _variableBounds;
        [FieldAttr(nst: 96, ctr: 96)] public hkbVariableValueSet? _variableInitialValues;
        [FieldAttr(nst: 104, ctr: 104)] public hkbBehaviorGraphStringData? _stringData;
    }
}