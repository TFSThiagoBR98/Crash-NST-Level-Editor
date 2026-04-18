namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CBoxLightPeachesCallback : igPeachesBaseCallback
    {
        [FieldAttr(ctr: 16, refCount: false)] public CBoxLight? _object;
        [FieldAttr(ctr: 24)] public uint _function;
    }
}
