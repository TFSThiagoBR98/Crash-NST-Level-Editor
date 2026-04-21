using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 432, ctr: 424)]
    public class hkbBehaviorGraph : hkbGenerator
    {
        public override uint Hash => 0xfdedb83b;

        [FieldAttr(nst: 136, ctr: 132)] public EVariableMode _variableMode;
        [FieldAttr(nst: 144, ctr: 136)] public hkMemory<u16> _uniqueIdPool;
        [FieldAttr(nst: 160, ctr: 152)] public uint _idToStateMachineTemplateMap;
        [FieldAttr(nst: 168, ctr: 160)] public hkMemory<int> _mirroredExternalIdMap;
        [FieldAttr(nst: 184, ctr: 176)] public uint _pseudoRandomGenerator;
        [FieldAttr(nst: 192, ctr: 184)] public hkbGenerator? _rootGenerator;
        [FieldAttr(nst: 200, ctr: 192)] public hkbBehaviorGraphData? _data;
        [FieldAttr(nst: 208, ctr: 200)] public hkbBehaviorGraph? _template;
        [FieldAttr(nst: 216, ctr: 208)] public hkbGenerator? _rootGeneratorClone;
        [FieldAttr(nst: 224, ctr: 216)] public uint _activeNodes;
        [FieldAttr(nst: 232, ctr: 224)] public uint _globalTransitionData;
        [FieldAttr(nst: 240, ctr: 232)] public uint _eventIdMap;
        [FieldAttr(nst: 248, ctr: 240)] public uint _attributeIdMap;
        [FieldAttr(nst: 256, ctr: 248)] public uint _variableIdMap;
        [FieldAttr(nst: 264, ctr: 256)] public uint _characterPropertyIdMap;
        [FieldAttr(nst: 272, ctr: 264)] public hkbVariableValueSet? _variableValueSet;
        [FieldAttr(nst: 280, ctr: 272)] public uint _nodeTemplateToCloneMap;
        [FieldAttr(nst: 288, ctr: 280)] public uint _stateListenerTemplateToCloneMap;
        [FieldAttr(nst: 296, ctr: 288)] public hkMemory<hkbNode> _recentlyCreatedClones;
        [FieldAttr(nst: 312, ctr: 304)] public uint _nodePartitionInfo;
        [FieldAttr(nst: 320, ctr: 312)] public int _numIntermediateOutputs;
        [FieldAttr(nst: 328, ctr: 320)] public hkMemory<i16> _intermediateOutputSizes;
        [FieldAttr(nst: 344, ctr: 336)] public hkMemory<uint> _jobs;
        [FieldAttr(nst: 360, ctr: 352)] public hkMemory<uint> _allPartitionMemory;
        [FieldAttr(nst: 376, ctr: 368)] public hkMemory<int> _internalToRootVariableIdMap;
        [FieldAttr(nst: 392, ctr: 384)] public hkMemory<int> _internalToCharacterCharacterPropertyIdMap;
        [FieldAttr(nst: 408, ctr: 400)] public hkMemory<int> _internalToRootAttributeIdMap;
        [FieldAttr(nst: 424, ctr: 416)] public u16 _nextUniqueId;
        [FieldAttr(nst: 426, ctr: 418)] public bool _isActive;
        [FieldAttr(nst: 427, ctr: 419)] public bool _isLinked;
        [FieldAttr(nst: 428, ctr: 420)] public bool _updateActiveNodes;
        [FieldAttr(nst: 429, ctr: 421)] public bool _updateActiveNodesForEnable;
        [FieldAttr(nst: 430, ctr: 422)] public bool _checkNodeValidity;
        [FieldAttr(nst: 431, ctr: 423)] public bool _stateOrTransitionChanged;
    }
}