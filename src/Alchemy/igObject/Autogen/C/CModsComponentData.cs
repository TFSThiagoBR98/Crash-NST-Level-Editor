namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CModsComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public CMod.EModLocation _modLocation;
        [FieldAttr(nst: 32)] public CModList? _mods;
    }
}
