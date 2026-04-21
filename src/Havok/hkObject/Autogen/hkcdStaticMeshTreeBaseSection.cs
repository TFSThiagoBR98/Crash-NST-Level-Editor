using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 96, ctr: 96)]
    public class hkcdStaticMeshTreeBaseSection : hkcdStaticTreeTreehkcdStaticTreeDynamicStorage4
    {
        public override uint Hash => 0xfd01ccd8;

        [FieldAttr(nst: 48, ctr: 48)] public float _codecParms_0;
        [FieldAttr(nst: 52, ctr: 52)] public float _codecParms_1;
        [FieldAttr(nst: 56, ctr: 56)] public float _codecParms_2;
        [FieldAttr(nst: 60, ctr: 60)] public float _codecParms_3;
        [FieldAttr(nst: 64, ctr: 64)] public float _codecParms_4;
        [FieldAttr(nst: 68, ctr: 68)] public float _codecParms_5;
        [FieldAttr(nst: 72, ctr: 72)] public uint _firstPackedVertex;
        [FieldAttr(nst: 76, ctr: 76)] public uint _sharedVertices;
        [FieldAttr(nst: 80, ctr: 80)] public uint _primitives;
        [FieldAttr(nst: 84, ctr: 84)] public uint _dataRuns;
        [FieldAttr(nst: 88, ctr: 88)] public u8 _numPackedVertices;
        [FieldAttr(nst: 89, ctr: 89)] public u8 _numSharedIndices;
        [FieldAttr(nst: 90, ctr: 90)] public u16 _leafIndex;
        [FieldAttr(nst: 92, ctr: 92)] public u8 _page;
        [FieldAttr(nst: 93, ctr: 93)] public u8 _flags;
        [FieldAttr(nst: 94, ctr: 94)] public u8 _layerData;
        [FieldAttr(nst: 95, ctr: 95)] public u8 _unusedData;
    }
}