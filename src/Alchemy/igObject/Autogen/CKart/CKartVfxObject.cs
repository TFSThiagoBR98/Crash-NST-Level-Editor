namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CKartVfxObject : igObject
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _localEffect = new();
        [FieldAttr(ctr: 24)] public igHandleMetaField _aiEffect = new();
        [FieldAttr(ctr: 32)] public CKartEffectAudio? _localSound;
        [FieldAttr(ctr: 40)] public CKartEffectAudio? _otherSound;
    }
}
