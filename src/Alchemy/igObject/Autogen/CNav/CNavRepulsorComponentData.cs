namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 4)]
    public class CNavRepulsorComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public float _repulsionRadius;
        [FieldAttr(nst: 28)] public float _outerCushion = 20.0f;
        [FieldAttr(nst: 32)] public float _innerCushion = 20.0f;
        [FieldAttr(nst: 36)] public float _repulsionMultiplier = 1.0f;
        [FieldAttr(nst: 40)] public uint _identityFlags = 1;
    }
}
