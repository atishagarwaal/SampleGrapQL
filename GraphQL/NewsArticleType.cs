using HotChocolate;
using HotChocolate.Types;
using SampleGrapQL;

namespace SampleGraphQL
{
    public class NewsArticleType : ObjectType<NewsArticle>
    {
        protected override void Configure(IObjectTypeDescriptor<NewsArticle> descriptor)
        {
            descriptor.Field(f => f.Title).Type<NonNullType<StringType>>();
            descriptor.Field(f => f.PublishedAt).Type<NonNullType<StringType>>();
            descriptor.Field(f => f.Content).Type<NonNullType<DateType>>();
        }
    }
}
