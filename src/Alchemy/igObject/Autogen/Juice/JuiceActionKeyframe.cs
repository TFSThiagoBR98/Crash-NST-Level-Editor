namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 40, align: 8)]
    public class JuiceActionKeyframe : JuiceKeyframe
    {
        [FieldAttr(nst: 24, ctr: 16)] public JuiceAction? _action;
        [FieldAttr(nst: 32, ctr: 24)] public igCinematicObject? _object;
        [FieldAttr(nst: 40, ctr: 32)] public igObject? _actionRuntimeData;
    }
}
