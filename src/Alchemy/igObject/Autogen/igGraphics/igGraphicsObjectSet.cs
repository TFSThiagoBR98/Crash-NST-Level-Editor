namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class igGraphicsObjectSet : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVectorMetaField<igGraphicsObject> _objects = new();
    }
}
