using Zenject;

namespace Assets.Scripts.Builder
{
    public class PacmanInstaller : MonoInstaller<PacmanInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<ICharacterBuilder>()
                .WithId("GhostBuilder")
                .To<GhostBuilder>()
                .AsSingle();

            Container.Bind<ICharacterBuilder>()
                .WithId("PacmanBuilder")
                .To<PacmanBuilder>()
                .AsSingle();
        }
    }
}