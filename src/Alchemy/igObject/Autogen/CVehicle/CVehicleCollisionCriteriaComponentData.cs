namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class CVehicleCollisionCriteriaComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public CVehicleCollisionResponseCriteriaTable? _collisionResponseCriteria;
    }
}
