namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CHubMinimapComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public CHUBMinimapRegionDataTable? _regionDataList;
    }
}
