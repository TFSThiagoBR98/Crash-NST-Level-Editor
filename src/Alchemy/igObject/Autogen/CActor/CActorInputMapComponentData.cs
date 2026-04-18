namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class CActorInputMapComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public CActorInputMap? _defaultActorInputMap;
    }
}
