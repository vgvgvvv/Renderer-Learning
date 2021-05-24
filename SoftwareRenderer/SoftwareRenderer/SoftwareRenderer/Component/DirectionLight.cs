using Common;
using SoftwareRenderer.Core;

namespace SoftwareRenderer.Component
{
    public class DirectionLight : Light
    {
        public static DirectionLight Main
        {
            get
            {
                return Application.Get().World.Objects.
                    FindFirst(o => o is DirectionLight) as DirectionLight;
            }
        }
    }
}