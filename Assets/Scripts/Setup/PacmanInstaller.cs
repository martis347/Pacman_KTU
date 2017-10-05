using Assets.Scripts.Patterns.Decorator;
using Assets.Scripts.Patterns.Factory;
using Zenject;

namespace Assets.Scripts.Setup
{
    public class PacmanInstaller : MonoInstaller<PacmanInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<CharacterBuilderFactory>()
                .ToSelf()
                .AsSingle();

            Container.Bind<EdibleElementCreator>()
                .To<EdibleDotCreator>()
                .AsSingle();
        }
    }
}