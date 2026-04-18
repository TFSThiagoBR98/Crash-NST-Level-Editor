namespace Alchemy
{
    [ObjectAttr(nst: 104, ctr: 104, align: 8)]
    public class CFlightControlLinearCameraSpline : CAttachmentSpline
    {
        [FieldAttr(nst: 88, ctr: 84)] public igVec2fMetaField _vehicleTranslationScreenMin = new();
        [FieldAttr(nst: 96, ctr: 92)] public igVec2fMetaField _vehicleTranslationScreenMax = new();
    }
}
