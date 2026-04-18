namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CRacerLodComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public CRacerLODList? _racerLODList;
    }
}
