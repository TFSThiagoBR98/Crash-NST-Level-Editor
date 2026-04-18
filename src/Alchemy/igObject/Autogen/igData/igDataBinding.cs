namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class igDataBinding : igObject
    {
        [FieldAttr(ctr: 16)] public igDataBindingEntity? _destination;
        [FieldAttr(ctr: 24)] public igDataBindingEntity? _source;
        [FieldAttr(ctr: 32)] public igDataTransformList? _transformList;
    }
}
