namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CKartEffectAudio : igObject
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _oneShot = new();
        [FieldAttr(ctr: 24)] public igHandleMetaField _loop = new();
    }
}
