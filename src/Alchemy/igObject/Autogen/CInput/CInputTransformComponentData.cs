namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class CInputTransformComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public CBaseInputTransformControllerList? _controllerList;
    }
}
