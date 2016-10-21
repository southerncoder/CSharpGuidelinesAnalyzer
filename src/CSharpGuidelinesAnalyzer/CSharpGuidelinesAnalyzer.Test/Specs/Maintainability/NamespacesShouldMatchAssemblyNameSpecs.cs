using CSharpGuidelinesAnalyzer.Maintainability;
using CSharpGuidelinesAnalyzer.Test.TestDataBuilders;
using Microsoft.CodeAnalysis.Diagnostics;
using Xunit;

namespace CSharpGuidelinesAnalyzer.Test.Specs.Maintainability
{
    public class NamespacesShouldMatchAssemblyNameSpecs : CSharpGuidelinesAnalysisTestFixture
    {
        protected override string DiagnosticId => NamespacesShouldMatchAssemblyNameAnalyzer.DiagnosticId;

        protected override DiagnosticAnalyzer CreateAnalyzer()
        {
            return new NamespacesShouldMatchAssemblyNameAnalyzer();
        }
    }
}