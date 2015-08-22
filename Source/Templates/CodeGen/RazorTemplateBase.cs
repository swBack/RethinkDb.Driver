using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace RazorGenerator.Templating
{
    public class RazorTemplateBase
    {
        public RazorTemplateBase Layout { get; set; }
        protected string content;
        internal StringBuilder generatingEnvironment = new StringBuilder();

        public virtual void Execute()
        {
        }

        public void WriteLiteral(string textToAppend)
        {
            if( string.IsNullOrEmpty(textToAppend) )
            {
                return;
            }
            generatingEnvironment.Append(textToAppend); ;
        }

        public void Write(object value)
        {
            if( ( value == null ) )
            {
                return;
            }

            WriteLiteral(Convert.ToString(value, CultureInfo.InvariantCulture));
        }

        public string RenderBody()
        {
            return content;
        }

        public string TransformText()
        {
            Execute();
            if( Layout != null )
            {
                Layout.content = generatingEnvironment.ToString();
                return Layout.TransformText();
            }
            else
            {
                return generatingEnvironment.ToString();
            }
        }

        public void Clear()
        {
            generatingEnvironment.Clear();

            if( Layout != null )
            {
                Layout.content = "";
            }
        }

        public void WriteTo(TextWriter writer, object value)
        {
            writer.Write(Convert.ToString(value, CultureInfo.InvariantCulture));
        }

        internal Dictionary<string, Action> sections = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);

        public virtual void DefineSection(string name, Action content)
        {
            if( this.sections.ContainsKey(name) )
            {
                //define it oncetarget[name] = content;
                return;
            }
            this.sections.Add(name, content);
        }

        public virtual string RenderSection(string name)
        {
            if( this.sections.ContainsKey(name) )
            {
                this.sections[name]();
            }
            return string.Empty;
        }
    }
}