namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4)]
    public class CKartControlSchemeData : igObject
    {
        [FieldAttr(ctr: 12)] public EXBUTTON _accelerate;
        [FieldAttr(ctr: 16)] public EXBUTTON _reverse;
        [FieldAttr(ctr: 20)] public EXBUTTON _brake;
        [FieldAttr(ctr: 24)] public EXBUTTON _turnLeft;
        [FieldAttr(ctr: 28)] public EXBUTTON _turnRight;
        [FieldAttr(ctr: 32)] public EAnalogStick _turnAnalog;
        [FieldAttr(ctr: 36)] public EXBUTTON _toggleSpeedometer;
        [FieldAttr(ctr: 40)] public EXBUTTON _usePowerUpInput;
        [FieldAttr(ctr: 44)] public EXBUTTON _firstJumpDriftInput;
        [FieldAttr(ctr: 48)] public EXBUTTON _secondJumpDriftInput;
        [FieldAttr(ctr: 52)] public EXBUTTON _cameraModeToggle;
        [FieldAttr(ctr: 56)] public EXBUTTON _cameraReverse;
    }
}
