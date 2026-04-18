namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class igGuiEventPlaceableLoseFocus : igGuiEvent
    {
        [FieldAttr(nst: 24, ctr: 24)] public igGuiInput.EController _control = igGuiInput.EController.kController1 | igGuiInput.EController.kController2 | igGuiInput.EController.kController3 | igGuiInput.EController.kController4 | igGuiInput.EController.kController5 | igGuiInput.EController.kController6 | igGuiInput.EController.kController7 | igGuiInput.EController.kController8;
    }
}
