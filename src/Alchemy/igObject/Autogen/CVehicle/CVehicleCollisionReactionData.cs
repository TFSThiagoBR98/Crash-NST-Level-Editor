namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 4)]
    public class CVehicleCollisionReactionData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public int _weightDifferenceMax = 100;
        [FieldAttr(nst: 20, ctr: 16)] public CVehicleSystemData.EVehicleCollisionReaction _reaction;
        [FieldAttr(nst: 24, ctr: 20)] public int _damageAmount;
    }
}
