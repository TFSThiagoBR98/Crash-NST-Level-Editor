namespace Alchemy
{
    [ObjectAttr(nst: 104, ctr: 88, align: 8)]
    public class CCEKillEffects : CCombatNodeEvent
    {
        [FieldAttr(nst: 80, ctr: 64)] public igHandleMetaField _effect = new();
        [FieldAttr(nst: 88, ctr: 72)] public string? _tagName = null;
        [FieldAttr(nst: 96, ctr: 80)] public igVfxManager.EffectKillType _killType;
    }
}
