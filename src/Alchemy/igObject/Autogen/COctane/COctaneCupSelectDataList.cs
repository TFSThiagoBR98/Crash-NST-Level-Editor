namespace Alchemy
{
    [ObjectAttr(ctr: 136, align: 8)]
    public class COctaneCupSelectDataList : igObjectList<COctaneCupSelectData>
    {
        [FieldAttr(ctr: 40)] public string? _refName;
        [FieldAttr(ctr: 48)] public string? _cupName;
        [FieldAttr(ctr: 56)] public bool _isHubCup;
        [FieldAttr(ctr: 64)] public igHandleMetaField _cupIcon = new();
        [FieldAttr(ctr: 72)] public igVec4ucMetaField _cupColor = new();
        [FieldAttr(ctr: 80)] public igHandleMetaField _cupScrollingBackgroundImage = new();
        [FieldAttr(ctr: 88)] public igHandleMetaField _cupBackground1 = new();
        [FieldAttr(ctr: 96)] public igHandleMetaField _cupBackground2 = new();
        [FieldAttr(ctr: 104)] public igHandleMetaField _cupBackground3 = new();
        [FieldAttr(ctr: 112)] public igHandleMetaField _cupBackground4 = new();
        [FieldAttr(ctr: 120)] public string? _cupDescription;
        [FieldAttr(ctr: 128)] public CRacerDriverDataList? _specificDrivers;
    }
}
