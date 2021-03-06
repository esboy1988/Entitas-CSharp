using Entitas;
using Entitas.Api;

public partial class GameEntity : Entity {

    public MoveComponent move { get { return (MoveComponent)GetComponent(ComponentIds.Move); } }
    public bool hasMove { get { return HasComponent(ComponentIds.Move); } }

    public void AddMove(int newSpeed) {
        var component = CreateComponent<MoveComponent>(ComponentIds.Move);
        component.speed = newSpeed;
        AddComponent(ComponentIds.Move, component);
    }

    public void ReplaceMove(int newSpeed) {
        var component = CreateComponent<MoveComponent>(ComponentIds.Move);
        component.speed = newSpeed;
        ReplaceComponent(ComponentIds.Move, component);
    }

    public void RemoveMove() {
        RemoveComponent(ComponentIds.Move);
    }
}

public partial class GameMatcher {

    static IMatcher<GameEntity> _matcherMove;

    public static IMatcher<GameEntity> Move {
        get {
            if(_matcherMove == null) {
                var matcher = (Matcher<GameEntity>)Matcher<GameEntity>.AllOf(ComponentIds.Move);
                matcher.componentNames = ComponentIds.componentNames;
                _matcherMove = matcher;
            }

            return _matcherMove;
        }
    }
}
