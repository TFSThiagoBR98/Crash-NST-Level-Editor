namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class CBehaviorDockingGenerator : igNamedObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public igRawRefMetaField _havokDockingGeneratorTemplate = new();
    }
}
