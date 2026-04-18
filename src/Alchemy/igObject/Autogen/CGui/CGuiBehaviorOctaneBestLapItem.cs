namespace Alchemy
{
    [ObjectAttr(ctr: 176, align: 8)]
    public class CGuiBehaviorOctaneBestLapItem : CGuiBehavior
    {
        [FieldAttr(ctr: 144, refCount: false)] public igGuiPlaceable? _playerName;
        [FieldAttr(ctr: 152, refCount: false)] public igGuiPlaceable? _driverIcon;
        [FieldAttr(ctr: 160, refCount: false)] public igGuiPlaceable? _time;
        [FieldAttr(ctr: 168)] public string? _currentZoneName;
    }
}
