namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 88, align: 8)]
    public class CAttachmentSpline : igSpline
    {
        [FieldAttr(nst: 64, ctr: 64)] public CAttachmentSplineAttachmentList? _spawnedAttachments;
        [FieldAttr(nst: 72, ctr: 72)] public CAttachmentSplineAttachmentList? _attachmentsQueue;
        [FieldAttr(nst: 80, ctr: 80)] public bool _allCoinsCollected = true;
    }
}
