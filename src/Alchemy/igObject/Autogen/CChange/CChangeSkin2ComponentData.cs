namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CChangeSkin2ComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public CChangeSkin2ComponentItemHashTable? _skins;
        [FieldAttr(nst: 32)] public string? _setSkinOnEnable = null;
    }
}
