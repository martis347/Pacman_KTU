using Assets.Scripts.Patterns.Adapter;
using Assets.Scripts.Patterns.Bridge;
using Assets.Scripts.Patterns.Decorator;
using Assets.Scripts.Patterns.Factory;
using Assets.Scripts.Patterns.Singleton;
using Zenject;

namespace Assets.Scripts.Setup
{
    public class PacmanInstaller : MonoInstaller<PacmanInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<GameTheme>()
                .To<GameColors>()
                .AsSingle();

            Container.Bind<BridgePainter>()
                .WithId("Light")
                .To<LightBridgePainter>()
                .AsSingle();

            Container.Bind<BridgePainter>()
                .WithId("Dark")
                .To<DarkBridgePainter>()
                .AsSingle();

            Container.Bind<CharacterBuilderFactory>()
                .ToSelf()
                .AsSingle();

            Container.Bind<EdibleElementCreator>()
                .To<EdibleDotCreator>()
                .AsSingle();

            Container.Bind<ScoreboardAdapter>()
                .ToSelf()
                .AsSingle()
                .WithArguments(ScoreboardSingleton.Scoreboard);
        }
    }
}