namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 8)]
    public class CDestructibleStage : igObject
    {
        [FieldAttr(nst: 16)] public float _percentHealth = 1.0f;
        [FieldAttr(nst: 20)] public EVulnerability _vulnerability;
        [FieldAttr(nst: 24)] public string? _model = null;
        [FieldAttr(nst: 32)] public bool _skylandersCanDamage = true;
        [FieldAttr(nst: 33)] public bool _vehiclesCanDamage = true;
        [FieldAttr(nst: 40)] public igHandleMetaField _onDamageVfx = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _onDamageSfx = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _onStageEndVfx = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _onStageEndSfx = new();
    }
}
