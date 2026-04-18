namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CZoneInfoGrandPrixData : igObject
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _level = new();
        [FieldAttr(ctr: 24)] public int _firstPlaceReward;
        [FieldAttr(ctr: 28)] public int _secondPlaceReward;
        [FieldAttr(ctr: 32)] public int _thirdPlaceReward;
        [FieldAttr(ctr: 36)] public int _participationReward;
    }
}
