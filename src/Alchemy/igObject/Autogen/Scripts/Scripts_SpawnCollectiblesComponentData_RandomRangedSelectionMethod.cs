namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8, metaType: typeof(Object))]
    public class Scripts_SpawnCollectiblesComponentData_RandomRangedSelectionMethod : Scripts_SpawnCollectiblesComponentData_CollectibleSelectionMethod
    {
        [FieldAttr(nst: 32)] public igEntityList? Collectibles;
        [FieldAttr(nst: 40)] public RangedFloat? NumCollectiblesToSpawn;
    }
}
