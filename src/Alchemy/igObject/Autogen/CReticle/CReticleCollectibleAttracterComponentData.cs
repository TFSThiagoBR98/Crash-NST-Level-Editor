namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 4)]
    public class CReticleCollectibleAttracterComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public float _minDistanceFromCamera = 100.0f;
        [FieldAttr(nst: 28)] public float _attractRadiusMultiplier = 0.15f;
        [FieldAttr(nst: 32)] public ECombatTargetList _targetList;
        [FieldAttr(nst: 36)] public bool _autoCollect = true;
        [FieldAttr(nst: 40)] public EXBUTTON _attractCollectibleButton = EXBUTTON.B;
        [FieldAttr(nst: 44)] public bool _useVehiclePassengerInput = true;
    }
}
