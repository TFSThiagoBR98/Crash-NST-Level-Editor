namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class CHavokConstraintData : igObject
    {
        [FieldAttr(nst: 16)] public CBoltPoint? _parentBolt;
        [FieldAttr(nst: 24)] public CBoltPoint? _childBolt;
    }
}
