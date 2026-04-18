namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 4)]
    public class CVehicleLevelBorderHelperComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public float _distanceCheckForBorder = 5000.0f;
        [FieldAttr(nst: 28)] public float _detectionZOffset = 200.0f;
        [FieldAttr(nst: 32)] public float _spawnOffset = 200.0f;
    }
}
