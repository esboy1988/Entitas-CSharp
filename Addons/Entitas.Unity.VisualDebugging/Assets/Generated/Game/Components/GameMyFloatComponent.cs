//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public MyFloatComponent myFloat { get { return (MyFloatComponent)GetComponent(GameComponentsLookup.MyFloat); } }
    public bool hasMyFloat { get { return HasComponent(GameComponentsLookup.MyFloat); } }

    public void AddMyFloat(float newMyFloat) {
        var component = CreateComponent<MyFloatComponent>(GameComponentsLookup.MyFloat);
        component.myFloat = newMyFloat;
        AddComponent(GameComponentsLookup.MyFloat, component);
    }

    public void ReplaceMyFloat(float newMyFloat) {
        var component = CreateComponent<MyFloatComponent>(GameComponentsLookup.MyFloat);
        component.myFloat = newMyFloat;
        ReplaceComponent(GameComponentsLookup.MyFloat, component);
    }

    public void RemoveMyFloat() {
        RemoveComponent(GameComponentsLookup.MyFloat);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherMyFloat;

    public static Entitas.IMatcher<GameEntity> MyFloat {
        get {
            if(_matcherMyFloat == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MyFloat);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMyFloat = matcher;
            }

            return _matcherMyFloat;
        }
    }
}
