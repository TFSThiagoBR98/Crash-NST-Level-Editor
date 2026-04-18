namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CSurfaceLinearMotion : CSurfaceMotion
    {
        [FieldAttr(ctr: 24)] public igVec3fMetaField _velocity = new();
    }
}
