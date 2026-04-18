namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 4)]
    public class CControllerVibrationData : igObject
    {
        public enum EControllerVibrationPreset
        {
            eCVP_Invalid = -1,
            eCVP_Weakest = 0,
            eCVP_Weak = 1,
            eCVP_Medium = 2,
            eCVP_Strong = 3,
            eCVP_Strongest = 4,
            eCVP_WeakPain = 5,
            eCVP_MediumPain = 6,
            eCVP_StrongPain = 7,
        }

        [FieldAttr(nst: 16, ctr: 12)] public EMotor _motor = EMotor.EMOTOR_RUMBLE;
        [FieldAttr(nst: 20, ctr: 16)] public float _strength = 0.5f;
        [FieldAttr(nst: 24, ctr: 20)] public float _duration = 0.5f;
    }
}
