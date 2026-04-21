using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 184, ctr: 184)]
    public class hkbLayerGenerator : hkbGenerator
    {
        public override uint Hash => 0xb4e0c52f;

        [FieldAttr(nst: 136, ctr: 136)] public hkMemory<hkbLayer> _layers;
        [FieldAttr(nst: 152, ctr: 152)] public i16 _indexOfSyncMasterChild;
        [FieldAttr(nst: 154, ctr: 154)] public u16 _flags;
        [FieldAttr(nst: 156, ctr: 156)] public int _numActiveLayers;
        [FieldAttr(nst: 160, ctr: 160)] public hkMemory<uint> _layerInternalStates;
        [FieldAttr(nst: 176, ctr: 176)] public bool _initSync;
    }
}