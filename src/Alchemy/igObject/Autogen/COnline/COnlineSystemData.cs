namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class COnlineSystemData : igSingleton
    {
        [FieldAttr(ctr: 16)] public COnlinePlaylistDataList? _playlistDataList;
        [FieldAttr(ctr: 24)] public CEntity? _lobbyTimerEntityInfo;
    }
}
