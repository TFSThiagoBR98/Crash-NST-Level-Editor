namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CLevelChunkInfo : CChunkInfo
    {
        [FieldAttr(ctr: 32)] public string? _levelName;
    }
}
