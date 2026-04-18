namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CKartDriverData : igObject
    {
        [FieldAttr(ctr: 16)] public CBoltPoint? _boltPoint;
        [FieldAttr(ctr: 24)] public bool _hideRider;
    }
}
