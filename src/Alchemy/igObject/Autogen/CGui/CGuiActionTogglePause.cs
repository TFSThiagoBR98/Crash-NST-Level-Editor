namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 8)]
    public class CGuiActionTogglePause : igGuiAction
    {
        [FieldAttr(nst: 48)] public bool _pause;
        [FieldAttr(nst: 52)] public ESoundPauseType _soundPauseType = ESoundPauseType.eSPT_PauseMenu;
    }
}
