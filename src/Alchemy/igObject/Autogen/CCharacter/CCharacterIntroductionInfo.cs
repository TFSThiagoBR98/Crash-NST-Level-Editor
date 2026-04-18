namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class CCharacterIntroductionInfo : igObject
    {
        [FieldAttr(nst: 16)] public igHandleMetaField _skewMaterial = new();
        [FieldAttr(nst: 24)] public igHandleMetaField _introductionVO = new();
    }
}
