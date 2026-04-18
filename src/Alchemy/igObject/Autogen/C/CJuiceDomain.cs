namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 40, align: 8)]
    public class CJuiceDomain : igObject
    {
        public enum EJuiceDomain
        {
            eJD_Permanent = 0,
            eJD_FrontEnd = 1,
            eJD_Story = 2,
            eJD_Town = 3,
            eJD_HeroicChallenges = 4,
            eJD_Multiplayer = 5,
            eJD_PVP = 6,
            eJD_RingOut = 7,
            eJD_Survival = 8,
            eJD_DRC = 9,
            eJD_ActionPacks = 10,
            eJD_MultiplayerPrototype = 11,
            eJD_Mobile = 12,
            eJD_AP_Matchmaking = 13,
            eJD_CTRNF_Race = 14,
            eJD_CTRNF_HUB = 15,
            eJD_CTRNF_Credits = 16,
        }

        [FieldAttr(nst: 16, ctr: 12)] public EJuiceDomain _id;
        [FieldAttr(nst: 24, ctr: 16)] public igStringRefList? _juiceProjectList;
        [FieldAttr(nst: 32, ctr: 24)] public igStringRefList? _soundBankList;
        [FieldAttr(nst: 40, ctr: 32)] public igStringRefList? _materialList;
    }
}
