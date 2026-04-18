namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class igGuiEventAnimationLoop : igGuiEventAnimation
    {
        [FieldAttr(ctr: 32)] public igGuiPlaceable? _placeable;
        [FieldAttr(ctr: 40)] public igGuiPlaceable? _signalObject;
        [FieldAttr(ctr: 48)] public EigGuiAnimationLoopMode _loopMode;
    }
}
