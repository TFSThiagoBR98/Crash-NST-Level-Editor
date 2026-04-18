namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class JuiceVisual : igCinematicObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igDataBindingList? _bindingList;
        [FieldAttr(nst: 24, ctr: 24)] public string? _name = null;
        [FieldAttr(nst: 32, ctr: 32)] public JuiceVisualList? _children;
    }
}
