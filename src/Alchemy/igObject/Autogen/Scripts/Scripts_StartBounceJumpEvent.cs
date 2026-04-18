namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8, metaType: typeof(CDotNetCombatNodeEvent))]
    public class Scripts_StartBounceJumpEvent : CDotNetCombatNodeEvent
    {
        [FieldAttr(nst: 32)] public bool AllowAirControl;
        [FieldAttr(nst: 33)] public bool FollowJumpHeightWithCamera;
        [FieldAttr(nst: 36)] public float ZJumpVelocity = 700.0f;
    }
}
