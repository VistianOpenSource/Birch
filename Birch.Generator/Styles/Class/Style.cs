using Birch.Generator.Specification;

namespace Birch.Generator.Styles.Class
{
    public class Style : IGenerationStyle
    {
        public const string Type = "Class";

        public string GenerationType => Type;
    }
}