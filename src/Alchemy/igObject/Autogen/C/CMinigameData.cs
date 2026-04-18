namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 8)]
    public class CMinigameData : igObject
    {
        [FieldAttr(nst: 16)] public string? _behaviorState = "Minigame";
        [FieldAttr(nst: 24)] public string? _endingBehaviorState = "Locomotion";
        [FieldAttr(nst: 32)] public string? _startBehaviorEvent = "Minigame_Start";
        [FieldAttr(nst: 40)] public string? _endBehaviorEvent = "Minigame_End";
        [FieldAttr(nst: 48)] public bool _lockControls = true;
        [FieldAttr(nst: 49)] public bool _hudEnabled = true;
        [FieldAttr(nst: 50)] public bool _playerVisible = true;
        [FieldAttr(nst: 51)] public bool _playerInvulnerable;
        [FieldAttr(nst: 52)] public bool _playerCollidable = true;
        [FieldAttr(nst: 53)] public bool _playerPhysicsEnabled = true;
        [FieldAttr(nst: 54)] public bool _playerAudible = true;
        [FieldAttr(nst: 55)] public bool _freezeCurrentSoundSettings;
    }
}
