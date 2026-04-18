namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4)]
    public class CAirArcadeControllerComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public EXBUTTON _barrelRollButton = EXBUTTON.JUMP;
        [FieldAttr(nst: 28)] public EXBUTTON _barrelRollButtonSecondary = EXBUTTON.L2;
        [FieldAttr(nst: 32)] public float _barrelRollPushForce = 1.5f;
        [FieldAttr(nst: 36)] public float _barrelRollTime = 0.5f;
        [FieldAttr(nst: 40)] public float _barrelRollCooldownTime = 0.75f;
        [FieldAttr(nst: 44)] public float _vehicleScreenMovementSpeed = 1.5f;
        [FieldAttr(nst: 48)] public float _screenLeftLimit = -0.89999998f;
        [FieldAttr(nst: 52)] public float _screenRightLimit = 0.89999998f;
        [FieldAttr(nst: 56)] public float _screenTopLimit = 0.89999998f;
        [FieldAttr(nst: 60)] public float _screenBottomLimit = -0.89999998f;
    }
}
