namespace Birch.Hosts
{
    /// <summary>
    /// Specification of what each environment builder should implement.
    /// </summary>
    /// <typeparam name="TSettings"></typeparam>
    public interface IEnvironmentBuilderComponent<in TSettings>
    {
        void Apply(TSettings settings);
    }
}