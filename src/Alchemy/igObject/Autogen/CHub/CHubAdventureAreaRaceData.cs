namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CHubAdventureAreaRaceData : igObject
    {
        [FieldAttr(ctr: 16)] public string? _areaName;
        [FieldAttr(ctr: 24)] public EOctaneAdventureArea _areaIndex;
        [FieldAttr(ctr: 32)] public igHandleMetaField _areaIcon = new();
        [FieldAttr(ctr: 40)] public igIntList? _hubZoneIndexes;
    }
}
