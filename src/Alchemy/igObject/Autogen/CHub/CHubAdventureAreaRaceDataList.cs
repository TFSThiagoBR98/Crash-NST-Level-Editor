namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CHubAdventureAreaRaceDataList : igObjectList<CHubAdventureAreaRaceData>
    {
        [FieldAttr(ctr: 40)] public string? _areasCategoryName;
        [FieldAttr(ctr: 48)] public string? _otherPagesCategoryName;
    }
}
