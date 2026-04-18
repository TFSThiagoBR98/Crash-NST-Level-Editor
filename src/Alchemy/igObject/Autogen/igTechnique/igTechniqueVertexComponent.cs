namespace Alchemy
{
    [ObjectAttr(nst: 24, align: 4)]
    public class igTechniqueVertexComponent : igObject
    {
        [FieldAttr(nst: 16)] public EIG_VERTEX_USAGE _type;
        [FieldAttr(nst: 20)] public int _index;
    }
}
