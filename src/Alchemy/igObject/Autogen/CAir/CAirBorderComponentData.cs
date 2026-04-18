namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CAirBorderComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public bool _turnAround;
        [FieldAttr(nst: 32)] public igHandleMetaField _vfxToSpawn = new();
    }
}
