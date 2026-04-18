namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class CGameSoundMusicEventPattern : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public string? _eventName = null;
        [FieldAttr(nst: 24, ctr: 24)] public int _repeatedMeasureLength;
        [FieldAttr(nst: 28, ctr: 28)] public float _beatOffset;
        [FieldAttr(nst: 32, ctr: 32)] public CGameSoundMusicEventBeatDataList? _beatDataList;
    }
}
