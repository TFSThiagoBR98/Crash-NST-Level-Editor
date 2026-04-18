namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 4)]
    public class CKartHalfPipeProjectilingParams : igObject
    {
        [FieldAttr(ctr: 12)] public float _minZAxisSpeed;
        [FieldAttr(ctr: 16)] public bool _needToBeBoosting;
    }
}
