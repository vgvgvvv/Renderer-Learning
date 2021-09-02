using Common;

namespace Assimp
{
    public class AssimpLib : Singleton<AssimpLib>
    {
        public AssimpContext AssimpContext;

        public override void Init()
        {
            base.Init();
            AssimpContext = new AssimpContext();
        }
    }
}