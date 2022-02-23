using System;
using System.Reflection;

namespace N01490200_Assignment2_Winter2022_Mahshad.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}