namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 4)]
    public class igVertexData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public EIG_VERTEX_USAGE _usage;
        [FieldAttr(nst: 20, ctr: 16)] public uint _usageIndex;
        [FieldAttr(nst: 24, ctr: 20)] public int _userID;
    }
}
