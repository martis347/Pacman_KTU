using Assets.Scripts.Factory;
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
        }
    }
}