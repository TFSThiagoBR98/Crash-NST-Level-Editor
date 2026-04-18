namespace Alchemy
{
    [ObjectAttr(ctr: 224, align: 16)]
    public class CStreamingLevelAreaData : igObject
    {
        [FieldAttr(ctr: 12)] public igVec3fMetaField _position = new();
        [FieldAttr(ctr: 24)] public igVec3fMetaField _rotation = new();
        [FieldAttr(ctr: 36)] public igVec3fMetaField _scale = new();
        [FieldAttr(ctr: 48)] public igVec3fMetaField _min = new();
        [FieldAttr(ctr: 60)] public igVec3fMetaField _max = new();
        [FieldAttr(ctr: 72)] public CLevelChunkInfoHandleList? _chunks;
        [FieldAttr(ctr: 80)] public CLevelChunkInfoHandleList? _neighbors;
        [FieldAttr(ctr: 88)] public CLevelChunkInfoHandleList? _precacheChunks;
        [FieldAttr(ctr: 96)] public int _priority;
        [FieldAttr(ctr: 104)] public igStringRefList? _chunksToSpawn;
        [FieldAttr(ctr: 112)] public igStringRefList? _chunksToLoad;
        [FieldAttr(ctr: 120)] public igStringRefList? _chunksToPrecache;
        [FieldAttr(ctr: 128)] public igStringRefList? _allChunks;
        [FieldAttr(ctr: 144)] public igMatrix44fMetaField _inverseMatrix = new();
        [FieldAttr(ctr: 208)] public bool _inverseMatrixDirty;
    }
}
