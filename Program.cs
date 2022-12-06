// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;

Test.MethodOne<Program>();

public static class Test
{
    
    public static void MethodOne<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]T>()
    {
        var variableRequiringClosure = "value";
        async Task LocalFunction()
        {
            Console.WriteLine(variableRequiringClosure);
            await Task.CompletedTask;
        }
        
        // Suppress async warning
#pragma warning disable CS4014
        LocalFunction();
#pragma warning restore CS4014
    }
}