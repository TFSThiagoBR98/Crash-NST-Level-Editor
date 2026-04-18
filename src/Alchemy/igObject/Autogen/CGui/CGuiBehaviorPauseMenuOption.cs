namespace Alchemy
{
    [ObjectAttr(nst: 200, ctr: 200, align: 8)]
    public class CGuiBehaviorPauseMenuOption : CGuiBehavior
    {
        [FieldAttr(nst: 144, ctr: 144)] public string? _build = "normal,final,beta";
        [FieldAttr(nst: 152, ctr: 152)] public uint _gameMode = 4294967295;
        [FieldAttr(nst: 156, ctr: 156)] public uint _nextGameMode = 4294967295;
        [FieldAttr(nst: 160, ctr: 160)] public bool _visibleInHub = true;
        [FieldAttr(nst: 161, ctr: 161)] public bool _visibleInIntro = true;
        [FieldAttr(nst: 162, ctr: 162)] public bool _visibleForPrimaryPlayerOnly;
        [FieldAttr(nst: 163, ctr: 163)] public bool _visibleOnPeer = true;
        [FieldAttr(nst: 168, ctr: 168)] public igDeviceList? _restrictedDevices;
        [FieldAttr(nst: 176, ctr: 176)] public CPauseMenuOption? _menuOption;
        [FieldAttr(nst: 184, ctr: 184)] public bool _playTransitionAnimation;
        [FieldAttr(nst: 192, ctr: 192)] public CGuiButtonLegendTable? _focusButtonLegendData;
    }
}
