using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Design;
using System.Text;

namespace Entity_Framework_Test
{
    // Don't forget to add an instance of this class to your DbConfiguration descendant's constructor
    // this.CodeGenerator = new CustomCSharpMigrationCodeGenerator1();

    // Override the methods to add custom generation steps to a specific model element
    // see https://github.com/aspnet/EntityFramework6/blob/master/src/EntityFramework/Migrations/Design/CSharpMigrationCodeGenerator.cs
    internal class CustomCSharpMigrationCodeGenerator1 : CSharpMigrationCodeGenerator
    {
    }
}
