namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 4)]
    public class CMultiIntensityVfxManagerComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public int _maximumIntensityLevel;
    }
}
