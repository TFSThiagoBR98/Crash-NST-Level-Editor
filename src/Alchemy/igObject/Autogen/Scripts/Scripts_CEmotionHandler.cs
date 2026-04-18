namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 8, metaType: typeof(CBehaviorLogic))]
    public class Scripts_CEmotionHandler : CBehaviorLogic
    {
        [FieldAttr(nst: 80)] public float _emotionEmotionWhenActivated = 1.0f;
        [FieldAttr(nst: 84)] public float _emotionEmotionWhileDeactivated = 1.0f;
    }
}
