namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 4)]
    public class SpeedVfxSpec : igObject
    {
        [FieldAttr(nst: 16)] public igRangedFloatMetaField _speedRange = new();
        [FieldAttr(nst: 24)] public int _vfxIntensityLevel = 1;
    }
}
