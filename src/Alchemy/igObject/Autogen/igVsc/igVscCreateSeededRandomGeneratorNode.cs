namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class igVscCreateSeededRandomGeneratorNode : igVscActionNode
    {
        [FieldAttr(ctr: 16, refCount: false)] public igVscIntAccessor? _seed;
        [FieldAttr(ctr: 24, refCount: false)] public igVscObjectAccessor? _randomGenerator;
        [FieldAttr(ctr: 32, refCount: false)] public igVscActionNode? _out;
    }
}
