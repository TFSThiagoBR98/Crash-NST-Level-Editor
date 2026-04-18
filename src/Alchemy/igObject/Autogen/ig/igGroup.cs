namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class igGroup : igNode
    {
        [FieldAttr(nst: 56, ctr: 56)] public igNodeList? _childList;
    }
}
