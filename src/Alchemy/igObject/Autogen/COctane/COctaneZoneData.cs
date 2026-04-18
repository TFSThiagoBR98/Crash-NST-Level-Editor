namespace Alchemy
{
    [ObjectAttr(ctr: 144, align: 8)]
    public class COctaneZoneData : CMarketplaceItem
    {
        [FieldAttr(ctr: 80)] public string? _levelAreaName;
        [FieldAttr(ctr: 88)] public igHandleMetaField _levelIcon = new();
        [FieldAttr(ctr: 96)] public igHandleMetaField _levelBackground = new();
        [FieldAttr(ctr: 104)] public bool _hasWon;
        [FieldAttr(ctr: 105)] public bool _hasPodiumEvent;
        [FieldAttr(ctr: 112)] public igStringRefList? _driversName;
        [FieldAttr(ctr: 120)] public COctaneMapTimeTrialData? _mapTimes;
        [FieldAttr(ctr: 128)] public igVec3fMetaField _minimapPivotToCenterOffset = new();
        [FieldAttr(ctr: 140)] public EOctaneTheme _theme;
    }
}
