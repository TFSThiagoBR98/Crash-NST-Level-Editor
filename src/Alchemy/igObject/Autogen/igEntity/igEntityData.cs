namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class igEntityData : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igComponentDataTable? _componentData;
        [FieldAttr(nst: 24, ctr: 24)] public float _scale = 1.0f;
        [FieldAttr(nst: 28, ctr: 28)] public uint _networkFlags;
    }
}
