using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 224, ctr: 224)]
    public class hkbBlenderGenerator : hkbGenerator
    {
        public override uint Hash => 0xce45c088;

        [FieldAttr(nst: 136, ctr: 132)] public float _referencePoseWeightThreshold;
        [FieldAttr(nst: 140, ctr: 136)] public float _blendParameter;
        [FieldAttr(nst: 144, ctr: 140)] public float _minCyclicBlendParameter;
        [FieldAttr(nst: 148, ctr: 144)] public float _maxCyclicBlendParameter;
        [FieldAttr(nst: 152, ctr: 148)] public i16 _indexOfSyncMasterChild;
        [FieldAttr(nst: 154, ctr: 150)] public i16 _flags;
        [FieldAttr(nst: 156, ctr: 152)] public bool _subtractLastChild;
        [FieldAttr(nst: 160, ctr: 160)] public hkMemory<hkbBlenderGeneratorChild> _children;
        [FieldAttr(nst: 176, ctr: 176)] public hkMemory<uint> _childrenInternalStates;
        [FieldAttr(nst: 192, ctr: 192)] public hkMemory<i16> _sortedChildren;
        [FieldAttr(nst: 208, ctr: 208)] public float _endIntervalWeight;
        [FieldAttr(nst: 212, ctr: 212)] public int _numActiveChildren;
        [FieldAttr(nst: 216, ctr: 216)] public i16 _beginIntervalIndex;
        [FieldAttr(nst: 218, ctr: 218)] public i16 _endIntervalIndex;
        [FieldAttr(nst: 220, ctr: 220)] public bool _initSync;
        [FieldAttr(nst: 221, ctr: 221)] public bool _doSubtractiveBlend;
    }
}