namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CStaticCompoundShape : CShape
    {
        [FieldAttr(ctr: 16)] public CShapeList? _shapeList;
    }
}
