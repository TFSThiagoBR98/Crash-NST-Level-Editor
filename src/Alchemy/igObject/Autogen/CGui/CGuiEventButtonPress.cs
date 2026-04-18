namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CGuiEventButtonPress : igGuiEvent
    {
        [FieldAttr(ctr: 24)] public CGuiButtonDef? _buttonDef;
    }
}
