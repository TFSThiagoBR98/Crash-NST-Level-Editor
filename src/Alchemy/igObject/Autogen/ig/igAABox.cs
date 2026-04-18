namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class igAABox : igVolume
    {
        [FieldAttr(nst: 16, ctr: 12)] public igVec3fMetaField _min = new();
        [FieldAttr(nst: 28, ctr: 24)] public igVec3fMetaField _max = new();
    }
}
