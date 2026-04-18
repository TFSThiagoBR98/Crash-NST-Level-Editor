namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class CCombatFxData : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igHandleMetaField _hitEffect = new();
        [FieldAttr(nst: 24, ctr: 24)] public igHandleMetaField _hitFlashEffect = new();
        [FieldAttr(nst: 32, ctr: 32)] public igHandleMetaField _killHitEffect = new();
        [FieldAttr(nst: 40, ctr: 40)] public igHandleMetaField _killFlashEffect = new();
    }
}
