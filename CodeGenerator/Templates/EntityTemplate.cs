﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace CodeGenerator.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\EntityTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class EntityTemplate : DataTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System;\r\nusing System.Text;\r\nusing System.Data;\r\n\r\nnamespace Entities\r\n{\r\n");
            
            #line 12 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\EntityTemplate.tt"
 var columnTemplate = templateData.ObjectData; 
            
            #line default
            #line hidden
            
            #line 13 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\EntityTemplate.tt"
 var filteredColumns = columnTemplate.Where(f => f.ColumnName != templateData.ObjectData.PrimaryKeyName); 
            
            #line default
            #line hidden
            this.Write("\tpublic class ");
            
            #line 14 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\EntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(columnTemplate.EntityName));
            
            #line default
            #line hidden
            this.Write(" : BaseEntity\r\n\t{\r\n");
            
            #line 16 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\EntityTemplate.tt"
 foreach (var field in filteredColumns) { 
            
            #line default
            #line hidden
            this.Write("\t\tpublic ");
            
            #line 17 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\EntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Type.Name));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 17 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\EntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.PropertyName));
            
            #line default
            #line hidden
            this.Write(" { get; set; }\r\n");
            
            #line 18 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\EntityTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\tpublic ");
            
            #line 20 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\EntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(columnTemplate.EntityName));
            
            #line default
            #line hidden
            this.Write("() : base(){}\r\n\r\n        public ");
            
            #line 22 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\EntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(columnTemplate.EntityName));
            
            #line default
            #line hidden
            this.Write("(IDataRecord dataRecord) : base (dataRecord)\r\n        {\r\n");
            
            #line 24 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\EntityTemplate.tt"
 foreach (var field in filteredColumns) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 25 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\EntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.PropertyName));
            
            #line default
            #line hidden
            this.Write(" = (");
            
            #line 25 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\EntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Type.Name));
            
            #line default
            #line hidden
            this.Write(")dataRecord[\"");
            
            #line 25 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\EntityTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.ColumnName));
            
            #line default
            #line hidden
            this.Write("\"];\r\n");
            
            #line 26 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\EntityTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n\t}\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
