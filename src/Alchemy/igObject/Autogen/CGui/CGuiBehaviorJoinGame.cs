namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8)]
    public class CGuiBehaviorJoinGame : igGuiBehavior
    {
        public enum EJoinGameBehaviorState
        {
            eJGBS_Normal = 0,
            eJGBS_Closing = 1,
        }

        [FieldAttr(nst: 16, refCount: false)] public igGuiAnimationTag? _openAnimation;
        [FieldAttr(nst: 24, refCount: false)] public igGuiAnimationTag? _idleAnimation;
        [FieldAttr(nst: 32, refCount: false)] public igGuiAnimationTag? _closeAnimation;
        [FieldAttr(nst: 40, refCount: false)] public igGuiPlaceable? _buttonText;
        [FieldAttr(nst: 48)] public EPlayerId _player;
        [FieldAttr(nst: 52)] public EJoinGameBehaviorState _state;
        [FieldAttr(nst: 56)] public bool _activeOnLoad;
    }
}
