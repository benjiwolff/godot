using Xunit;

namespace Godot.SourceGenerators.Tests;

public class ScriptSerializationGeneratorTests
{
    [Fact]
    public async void ScriptBoilerplate()
    {
        await CSharpSourceGeneratorVerifier<ScriptSerializationGeneratorRunner>.VerifyNoCompilerDiagnostics(
            "ScriptBoilerplate.cs",
            "ScriptBoilerplate_ScriptSerialization.generated.cs", "OuterClass.NestedClass_ScriptSerialization.generated.cs"
        );
    }
}
