namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class CChangeSkin2ShardComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public CChangeSkin2ComponentItemHashTable? _skinShards;
    }
}
