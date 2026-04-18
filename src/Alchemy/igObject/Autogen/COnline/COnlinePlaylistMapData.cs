namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class COnlinePlaylistMapData : igObject
    {
        [FieldAttr(ctr: 16)] public string? _mapName;
        [FieldAttr(ctr: 24)] public int _mapWeight;
        [FieldAttr(ctr: 32)] public CPlaylistModesWeightsTable? _modesWeights;
    }
}
