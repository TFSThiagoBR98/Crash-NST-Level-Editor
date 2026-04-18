namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 4, metaType: typeof(CVscComponentData))]
    public class Enemy_Camera_Robot_Lookat_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _UsePitch;
        [FieldAttr(nst: 41)] public bool _UseYaw;
        [FieldAttr(nst: 42)] public bool _Bool;
        [FieldAttr(nst: 44)] public float _Float;
    }
}
