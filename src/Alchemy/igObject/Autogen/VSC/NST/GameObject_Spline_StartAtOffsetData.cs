namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 4, metaType: typeof(CVscComponentData))]
    public class GameObject_Spline_StartAtOffsetData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _PlayForward;
        [FieldAttr(nst: 44)] public float _StartingRatio;
    }
}
