namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class CAIAggroRule : igObject
    {
        [FieldAttr(nst: 16)] public CFilterEntities? _filter;
        [FieldAttr(nst: 24)] public float _aggroAmount = 1.0f;
        [FieldAttr(nst: 28)] public float _distanceMax;
        [FieldAttr(nst: 32)] public float _aggroMultiplierMinDistance;
        [FieldAttr(nst: 36)] public float _aggroMultiplierAtMinDistance = 1.0f;
        [FieldAttr(nst: 40)] public float _aggroMultiplierAtMaxDistance = 1.0f;
        [FieldAttr(nst: 44)] public uint _validWithStatus = 3;
    }
}
