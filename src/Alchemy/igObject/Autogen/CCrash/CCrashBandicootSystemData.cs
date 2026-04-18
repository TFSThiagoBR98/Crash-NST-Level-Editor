namespace Alchemy
{
    [ObjectAttr(nst: 112, align: 8)]
    public class CCrashBandicootSystemData : igSingleton
    {
        [FieldAttr(nst: 16)] public igHandleMetaField _crash1Hub = new();
        [FieldAttr(nst: 24)] public igHandleMetaField _crash2Hub = new();
        [FieldAttr(nst: 32)] public igHandleMetaField _crash3Hub = new();
        [FieldAttr(nst: 40)] public int _deathRatingOne = 7;
        [FieldAttr(nst: 44)] public int _deathRatingTwo = 12;
        [FieldAttr(nst: 48)] public int _deathRatingThree = 15;
        [FieldAttr(nst: 56)] public CGameBoolVariable? _superChargedBodySlamGameVariable;
        [FieldAttr(nst: 64)] public CGameBoolVariable? _doubleJumpGameVariable;
        [FieldAttr(nst: 72)] public CGameBoolVariable? _deathTornadoSpinGameVariable;
        [FieldAttr(nst: 80)] public CGameBoolVariable? _fruitBazookaGameVariable;
        [FieldAttr(nst: 88)] public CGameBoolVariable? _speedShoesGameVariable;
        [FieldAttr(nst: 96)] public CGameBoolVariable? _speedShoesCrash2GameVariable;
        [FieldAttr(nst: 104)] public CGameBoolVariable? _playableCocoGameVariable;
    }
}
