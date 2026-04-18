namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8)]
    public class CBoltOnMessage : CEntityMessage
    {
        [FieldAttr(nst: 56)] public bool _bolt;
        [FieldAttr(nst: 60)] public EBoltonModels _boltonModels = EBoltonModels.EBOLTON_NONE;
    }
}
