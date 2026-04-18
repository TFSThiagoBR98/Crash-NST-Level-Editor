namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 72, align: 8)]
    public class CVehicleCollisionResponse : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public CVehicleSystemData.EVehicleCollisionReaction _reaction;
        [FieldAttr(nst: 24, ctr: 16)] public CVehicleCollisionExtraResponseBase? _extraResponse;
        [FieldAttr(nst: 32, ctr: 24)] public igHandleMetaField _hitEffect = new();
        [FieldAttr(nst: 40, ctr: 32)] public string? _hitEffectCooldownGroup = null;
        [FieldAttr(nst: 48, ctr: 40)] public float _hitEffectCooldownDuration;
        [FieldAttr(nst: 52, ctr: 44)] public EVehicleCollisionTweakAxis _tweakAxis = EVehicleCollisionTweakAxis.eVCTA_None;
        [FieldAttr(nst: 56, ctr: 48)] public float _physicalResponseFactor = 1.0f;
        [FieldAttr(nst: 60, ctr: 52)] public igVec3fMetaField _physicalRotationFactor = new();
        [FieldAttr(nst: 72, ctr: 64)] public bool _shouldRemoveBoosts = true;
    }
}
