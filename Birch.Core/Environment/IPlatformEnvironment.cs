using Birch.Hosts;

namespace Birch.Environment
{
    public interface IPlatformEnvironment
    {
        public  EnvironmentBuilder CreateEnvironmentBuilder();
    }
}