namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class HavokConstraint : igObject
    {
        [FieldAttr(nst: 16)] public CHavokConstraintMetaField _storage = new();
    }
}
