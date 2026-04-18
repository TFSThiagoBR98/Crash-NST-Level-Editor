namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class igStreamingChunkInfo : igInfo
    {
        [FieldAttr(nst: 40, ctr: 40)] public igVectorMetaField<ChunkFileInfoMetaField> _required = new();
    }
}
