namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class igVfxSpawnGroupPassInfo : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVectorMetaField<u16> _passIds = new();
        [FieldAttr(nst: 40, ctr: 40)] public string? _modelClass = null;
    }
}
