namespace Chapter2.Objective5
{
    using System.CodeDom;
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations.Utilities;
    using System.IO;
    using Microsoft.CSharp;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_75
    {
        [TestMethod]
        public void Main()
        {
            CodeCompileUnit compileUnit = new CodeCompileUnit();
            CodeNamespace myNameSpace = new CodeNamespace("MyNameSpace");
            myNameSpace.Imports.Add(new CodeNamespaceImport("System"));
            CodeTypeDeclaration myClass = new CodeTypeDeclaration("MyClass");
            CodeEntryPointMethod start = new CodeEntryPointMethod();
            CodeMethodInvokeExpression cs1 = new CodeMethodInvokeExpression(
                new CodeTypeReferenceExpression("Console"),
                "WriteLine",
                new CodeTypeReferenceExpression("Hello World!"));

            compileUnit.Namespaces.Add(myNameSpace);
            myNameSpace.Types.Add(myClass);
            myClass.Members.Add(start);
            start.Statements.Add(cs1);

            CSharpCodeProvider provider = new CSharpCodeProvider();

            using (StreamWriter sw = new StreamWriter("HelloWorld.cs", false)) 
            {
                System.CodeDom.Compiler.IndentedTextWriter tw = new System.CodeDom.Compiler.IndentedTextWriter(sw, " ");
                provider.GenerateCodeFromCompileUnit(compileUnit, tw, new CodeGeneratorOptions());
                tw.Close();
            }
        }
    }
}