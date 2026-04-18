namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CDriverCustomBoltsComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public CBoltPoint? _tntOnHead;
    }
}
