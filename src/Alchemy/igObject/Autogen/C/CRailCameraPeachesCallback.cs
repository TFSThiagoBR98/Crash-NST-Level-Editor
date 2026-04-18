namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CRailCameraPeachesCallback : igPeachesBaseCallback
    {
        [FieldAttr(ctr: 16, refCount: false)] public CRailCamera? _object;
        [FieldAttr(ctr: 24)] public uint _function;
    }
}
