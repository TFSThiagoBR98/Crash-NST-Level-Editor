namespace Alchemy
{
    [ObjectAttr(nst: 24, ctr: 16, align: 4)]
    public class EFlagsWrapper : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public EFlags _flag = EFlags.FLAG_INVALID;
    }
}
