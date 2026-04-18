namespace Alchemy
{
    [ObjectAttr(nst: 224, ctr: 232, align: 8)]
    public class CGuiBehaviorGameVariableToggleOption : CGuiBehaviorBaseToggleOption
    {
        [FieldAttr(nst: 216, ctr: 224)] public igHandleMetaField _toggledVariable = new();
    }
}
