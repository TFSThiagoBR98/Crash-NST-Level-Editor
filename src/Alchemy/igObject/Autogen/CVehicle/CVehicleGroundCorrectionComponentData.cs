namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 4)]
    public class CVehicleGroundCorrectionComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public float _groundSpawnOffset = 150.0f;
    }
}
