namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class CBehaviorLayer : igNamedObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public int _layerIndex = -1;
        [FieldAttr(nst: 28, ctr: 28)] public bool _registeredWithLayerGenerator;
    }
}
