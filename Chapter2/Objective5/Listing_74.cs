namespace Chapter2.Objective5
{
    using System.CodeDom;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_74
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
        }
    }
}
