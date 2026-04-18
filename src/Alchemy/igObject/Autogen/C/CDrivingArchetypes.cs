namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CDrivingArchetypes : igSingleton
    {
        [FieldAttr(ctr: 16)] public CDrivingArchetypeDataHashmap? _archetypes;
        [FieldAttr(ctr: 24)] public CDrivingArchetypeData? _aiArchetype;
        [FieldAttr(ctr: 32)] public CDrivingArchetypeData? _bossAiArchetype;
        [FieldAttr(ctr: 40)] public CDrivingArchetypeData? _aiBattleArchetype;
    }
}
