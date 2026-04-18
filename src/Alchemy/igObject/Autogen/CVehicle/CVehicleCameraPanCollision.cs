namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 8)]
    public class CVehicleCameraPanCollision : CVehicleCameraCollision
    {
        [FieldAttr(nst: 48)] public float _rayLength = 300.0f;
        [FieldAttr(nst: 52)] public float _rayFractionToConsiderAsGlitch = 0.5f;
    }
}
