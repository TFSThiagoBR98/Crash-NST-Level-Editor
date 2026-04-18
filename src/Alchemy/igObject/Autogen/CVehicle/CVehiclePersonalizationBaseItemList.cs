namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class CVehiclePersonalizationBaseItemList : igObjectList<CVehiclePersonalizationBaseItem>
    {
        [FieldAttr(nst: 40, ctr: 40)] public CVehiclePersonalizationBaseSharedData? _sharedData;
    }
}
