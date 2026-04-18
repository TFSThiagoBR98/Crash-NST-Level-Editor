namespace Alchemy
{
    [ObjectAttr(nst: 160, ctr: 144, align: 8)]
    public class CCEEffectFile : CCombatNodeEvent
    {
        [FieldAttr(nst: 80, ctr: 64)] public CUpgradeableVfx? _effect;
        [FieldAttr(nst: 88, ctr: 72)] public CBoltPoint? mBoltPoint;
        [FieldAttr(nst: 96, ctr: 80)] public CBoltPoint? mBoltPoint2;
        [FieldAttr(nst: 104, ctr: 88)] public CBoltPoint? _passengerBoltPoint;
        [FieldAttr(nst: 112, ctr: 96)] public CBoltPoint? _passengerBoltPoint2;
        [FieldAttr(nst: 120, ctr: 104)] public string? _tagName = null;
        [FieldAttr(nst: 128, ctr: 112)] public bool _preventDuplicates;
        [FieldAttr(nst: 129, ctr: 113)] public bool _activateTerrainSpawnLayers;
        [FieldAttr(nst: 130, ctr: 114)] public bool _attachToBolt = true;
        [FieldAttr(nst: 131, ctr: 115)] public bool _useBoltOrientation = true;
        [FieldAttr(nst: 132, ctr: 116)] public bool _checkForGround;
        [FieldAttr(nst: 136, ctr: 120)] public float _checkUpOffset = 60.0f;
        [FieldAttr(nst: 140, ctr: 124)] public float _checkLength = 100.0f;
        [FieldAttr(ctr: 128)] public bool _firstPodiumStepOnly;
        [FieldAttr(nst: 144, ctr: 129)] public bool _killEffectOnEnd;
        [FieldAttr(nst: 148, ctr: 132)] public igVfxManager.EffectKillType _killTypeOnEnd = igVfxManager.EffectKillType.kHardKill;
        [FieldAttr(nst: 152, ctr: 136)] public bool _spawnWhenEntityInvisible = true;
    }
}
