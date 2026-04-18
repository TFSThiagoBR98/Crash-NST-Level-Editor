namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class CWorldCollectibleModifierItem : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public string? _modelName = null;
        [FieldAttr(nst: 24, ctr: 24)] public igHandleMetaField _idleVfxHandle = new();
        [FieldAttr(nst: 32, ctr: 32)] public igHandleMetaField _trailVfxHandle = new();
        [FieldAttr(nst: 40, ctr: 40)] public igHandleMetaField _collectBeginVfxHandle = new();
        [FieldAttr(nst: 48, ctr: 48)] public igHandleMetaField _collectEndVfxHandle = new();
    }
}
