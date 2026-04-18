namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class igBaseMutex : igNamedObject
    {
        [FieldAttr(ctr: 24)] public bool _isActive;
    }
}
