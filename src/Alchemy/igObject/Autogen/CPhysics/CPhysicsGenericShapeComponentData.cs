namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 72, align: 8)]
    public class CPhysicsGenericShapeComponentData : CPhysicsShapeComponentData
    {
        [FieldAttr(nst: 72, ctr: 64)] public CShape? _shape;
    }
}
