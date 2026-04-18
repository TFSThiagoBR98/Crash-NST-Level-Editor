namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class CControllerButtonCharacterMap : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public EControllerType _controllerType;
        [FieldAttr(nst: 24, ctr: 16)] public igStringStringHashTable? _characterMap;
    }
}
