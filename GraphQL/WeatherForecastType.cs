using HotChocolate;
using HotChocolate.Types;

namespace SampleGraphQL
{
    public class WeatherForecastType : ObjectType<WeatherForecast>
    {
        protected override void Configure(IObjectTypeDescriptor<WeatherForecast> descriptor)
        {
            descriptor.Field(f => f.Date).Type<NonNullType<DateTimeType>>();
            descriptor.Field(f => f.TemperatureC).Type<NonNullType<IntType>>();
            descriptor.Field(f => f.TemperatureF).Type<NonNullType<IntType>>();
            descriptor.Field(f => f.Summary).Type<StringType>();
        }
    }
}
