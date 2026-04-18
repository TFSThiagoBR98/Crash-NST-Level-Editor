namespace Alchemy
{
    [ObjectAttr(nst: 192, ctr: 176, align: 16)]
    public class COcclusionBox : igObject
    {
        [ObjectAttr(size: 4)]
        public class OcclusionFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _invertVisibility;
            [FieldAttr(offset: 1, size: 4)] public int _flags;
            [FieldAttr(offset: 5, size: 1)] public bool _state;
        }

        [FieldAttr(nst: 16, ctr: 16)] public igMatrix44fMetaField _inverseMatrix = new();
        [FieldAttr(nst: 80)] public igEntityHandleList? _entities;
        [FieldAttr(nst: 88)] public CGameEntityHandleList? _dynamicEntities;
        [FieldAttr(nst: 96)] public CGameEntityHandleList? _messageReceivingEntities;
        [FieldAttr(ctr: 80)] public ChunkOcclusionDataList? _chunkOcclusionData;
        [FieldAttr(nst: 104, ctr: 88)] public int[] _activeCount = new int[4];
        [FieldAttr(nst: 112, ctr: 104)] public igVec3fMetaField _position = new();
        [FieldAttr(nst: 124, ctr: 116)] public igVec3fMetaField _rotation = new();
        [FieldAttr(nst: 136, ctr: 128)] public igVec3fMetaField _scale = new();
        [FieldAttr(nst: 148, ctr: 140)] public igVec3fMetaField _min = new();
        [FieldAttr(nst: 160, ctr: 152)] public igVec3fMetaField _max = new();
        [FieldAttr(nst: 172, ctr: 164)] public OcclusionFlags _occlusionFlags = new();
        [FieldAttr(nst: 176, ctr: 168)] public bool _inverseMatrixDirty = true;
    }
}
