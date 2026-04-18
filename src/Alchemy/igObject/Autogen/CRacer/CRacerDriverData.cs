namespace Alchemy
{
    [ObjectAttr(ctr: 160, align: 8)]
    public class CRacerDriverData : CRacerBaseData
    {
        [FieldAttr(ctr: 136)] public EDriverFaction _faction;
        [FieldAttr(ctr: 144)] public CDriverSkinDataList? _skins;
        [FieldAttr(ctr: 152)] public bool _availableInClassicAdventure;
    }
}
