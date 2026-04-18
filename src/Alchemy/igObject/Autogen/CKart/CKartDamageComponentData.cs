namespace Alchemy
{
    [ObjectAttr(ctr: 112, align: 8)]
    public class CKartDamageComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public string? _damageEventName;
        [FieldAttr(ctr: 24)] public CKartDamageData? _spinOut;
        [FieldAttr(ctr: 32)] public CKartDamageData? _wallHit;
        [FieldAttr(ctr: 40)] public CKartDamageData? _explosive;
        [FieldAttr(ctr: 48)] public CKartDamageData? _eaten;
        [FieldAttr(ctr: 56)] public CKartDamageData? _fire;
        [FieldAttr(ctr: 64)] public CKartDamageData? _electrified;
        [FieldAttr(ctr: 72)] public CKartDamageData? _poisoned;
        [FieldAttr(ctr: 80)] public CKartDamageData? _ntropied;
        [FieldAttr(ctr: 88)] public CKartDamageData? _crushed;
        [FieldAttr(ctr: 96)] public CKartDamageData? _crushedAndStopped;
        [FieldAttr(ctr: 104)] public CKartDamageData? _greenBeaker;
    }
}
