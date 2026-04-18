namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 8)]
    public class CVehiclePersonalizationBoostItem : CVehiclePersonalizationBaseItem
    {
        [FieldAttr(nst: 64)] public igHandleMetaField _data = new();
        [FieldAttr(nst: 72)] public EVehiclePersonalizationBoost _boost = EVehiclePersonalizationBoost.eVPB_None;
    }
}
