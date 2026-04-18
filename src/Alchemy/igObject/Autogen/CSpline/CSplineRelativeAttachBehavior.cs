namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 16)]
    public class CSplineRelativeAttachBehavior : CSplineAttachBehavior
    {
        [FieldAttr(nst: 32)] public igMatrix44fMetaField _startingTransform = new();
    }
}
