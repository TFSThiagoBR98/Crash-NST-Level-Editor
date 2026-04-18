namespace Alchemy
{
    [ObjectAttr(nst: 96, ctr: 96, align: 4)]
    public class CCollectibleSystemData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _xpScalarEasy = 1.0f;
        [FieldAttr(nst: 20, ctr: 16)] public float _xpScalarMedium = 1.0f;
        [FieldAttr(nst: 24, ctr: 20)] public float _xpScalarHard = 1.1f;
        [FieldAttr(nst: 28, ctr: 24)] public float _xpScalarNightmare = 1.2f;
        [FieldAttr(nst: 32, ctr: 28)] public float _vehicleXpScalarEasy = 1.0f;
        [FieldAttr(nst: 36, ctr: 32)] public float _vehicleXpScalarMedium = 1.0f;
        [FieldAttr(nst: 40, ctr: 36)] public float _vehicleXpScalarHard = 1.1f;
        [FieldAttr(nst: 44, ctr: 40)] public float _vehicleXpScalarNightmare = 1.2f;
        [FieldAttr(nst: 48, ctr: 44)] public float _moneyScalarEasy = 1.0f;
        [FieldAttr(nst: 52, ctr: 48)] public float _moneyScalarMedium = 1.0f;
        [FieldAttr(nst: 56, ctr: 52)] public float _moneyScalarHard = 1.1f;
        [FieldAttr(nst: 60, ctr: 56)] public float _moneyScalarNightmare = 1.2f;
        [FieldAttr(nst: 64, ctr: 60)] public float _stardustScalarEasy = 1.0f;
        [FieldAttr(nst: 68, ctr: 64)] public float _stardustScalarMedium = 1.0f;
        [FieldAttr(nst: 72, ctr: 68)] public float _stardustScalarHard = 1.1f;
        [FieldAttr(nst: 76, ctr: 72)] public float _stardustScalarNightmare = 1.2f;
        [FieldAttr(nst: 80, ctr: 76)] public float _unownedSoulGemWeight = 0.85f;
        [FieldAttr(nst: 84, ctr: 80)] public float _upgradedSoulGemWeight = 0.85f;
        [FieldAttr(nst: 88, ctr: 84)] public float _normalSoulGemWeight = 0.15f;
        [FieldAttr(nst: 92, ctr: 88)] public uint _unownedSoulGemInterval = 259200;
    }
}
