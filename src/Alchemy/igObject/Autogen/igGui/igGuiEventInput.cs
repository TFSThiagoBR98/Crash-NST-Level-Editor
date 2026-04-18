namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class igGuiEventInput : igGuiEvent
    {
        [FieldAttr(nst: 24, ctr: 24)] public igGuiInput.ESignal _signal;
        [FieldAttr(nst: 28, ctr: 28)] public igGuiInput.EController _control;
    }
}
