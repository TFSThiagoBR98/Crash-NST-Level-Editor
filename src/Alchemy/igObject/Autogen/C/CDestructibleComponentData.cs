namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CDestructibleComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public string? _acceptAttackIdentifier = null;
        [FieldAttr(nst: 32)] public CDestructibleStageList? _stages;
    }
}
