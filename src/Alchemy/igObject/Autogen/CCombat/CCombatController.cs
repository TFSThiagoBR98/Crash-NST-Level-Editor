namespace Alchemy
{
    [ObjectAttr(nst: 160, ctr: 152, align: 8)]
    public class CCombatController : CCoreCameraController
    {
        [FieldAttr(nst: 144)] public CStackBlender.EBlendType _yawBlendType_1;
        [FieldAttr(nst: 148)] public float _yawDamping_1 = 0.02f;
        [FieldAttr(ctr: 136)] public EBlendType _yawBlendType2;
        [FieldAttr(ctr: 140)] public float _yawDamping2;
        [FieldAttr(nst: 152, ctr: 144)] public bool _autoEnable = true;
        [FieldAttr(nst: 156, ctr: 148)] public float _durationBeforeMaintainHeading = 1.0f;
    }
}
