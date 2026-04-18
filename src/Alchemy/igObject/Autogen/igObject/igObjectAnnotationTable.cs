namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class igObjectAnnotationTable : igObject
    {
        [FieldAttr(nst: 16)] public igObjectList? _objects;
        [FieldAttr(nst: 24)] public igEffectAnnotationListList? _annotations;
    }
}
