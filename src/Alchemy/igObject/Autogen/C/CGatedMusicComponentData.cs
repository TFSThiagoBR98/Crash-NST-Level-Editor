namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CGatedMusicComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public CGameSoundMusicSettings? _onEnterMusicSettings;
        [FieldAttr(nst: 32)] public CGameSoundMusicSettings? _onExitMusicSettings;
    }
}
