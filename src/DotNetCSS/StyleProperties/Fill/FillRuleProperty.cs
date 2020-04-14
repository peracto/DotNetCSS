
namespace DotNetCSS
{
    internal sealed class FillRuleProperty : Property
    {
        private static readonly IValueConverter StyleConverter = Converters.FillRuleConverter;

        public FillRuleProperty() : base(PropertyNames.FillRule, PropertyFlags.Animatable)
        {
        }

        internal override IValueConverter Converter => StyleConverter;
    }
}