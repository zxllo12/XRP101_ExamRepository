public abstract class PlayerState
{
    public PlayerController Controller { get; private set; }
    public StateMachine Machine { get; set; }
    public StateType ThisType { get; protected set; }

    public PlayerState(PlayerController controller)
    {
        Controller = controller;
        Init();
    }

    public abstract void Init();
    public virtual void Enter() { }
    public virtual void OnUpdate() { }
    public virtual void Exit() { }
}