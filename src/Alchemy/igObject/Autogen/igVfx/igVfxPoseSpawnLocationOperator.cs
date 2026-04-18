namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 40, align: 8)]
    public class igVfxPoseSpawnLocationOperator : igVfxLoadOperator
    {
        [FieldAttr(nst: 32, ctr: 24)] public igVfxSpawnLocationData? _spawnLocation;
        [FieldAttr(nst: 40, ctr: 32)] public uint _primitive;
    }
}
