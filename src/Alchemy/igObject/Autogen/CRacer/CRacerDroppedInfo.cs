namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CRacerDroppedInfo : igObject
    {
        [FieldAttr(ctr: 16)] public CRacer? racer;
        [FieldAttr(ctr: 24)] public bool racerFinishedBeforeDropping;
    }
}
