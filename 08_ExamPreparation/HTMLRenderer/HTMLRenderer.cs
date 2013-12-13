using System;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Collections.Generic;

namespace HTMLRenderer
{
	public interface IElement
	{
		string Name { get; }
		string TextContent { get; set; }
		IEnumerable<IElement> ChildElements { get; }
		void AddElement(IElement element);
		void Render(StringBuilder output);
		string ToString();
	}

	public interface ITable : IElement
	{
		int Rows { get; }
		int Cols { get; }
		IElement this[int row, int col] { get; set; }
	}

    public interface IElementFactory
    {
		IElement CreateElement(string name);
		IElement CreateElement(string name, string content);
		ITable CreateTable(int rows, int cols);
    }

    public class HTMLElementFactory : IElementFactory
    {
		public IElement CreateElement(string name)
		{
			return new HTMLElement(name);
		}

		public IElement CreateElement(string name, string content)
		{
            return new HTMLElement(name, content);
		}

		public ITable CreateTable(int rows, int cols)
		{
            return new HTMLTable(rows, cols);
		}
	}

    public class HTMLElement : IElement
    {
        private IList<IElement> childElementsConteiner;

        public virtual string Name { get; private set; }

        public virtual string TextContent { get; set; }

        public IEnumerable<IElement> ChildElements
        {
            get { return this.childElementsConteiner; }
        }

        public HTMLElement(string tag)
        {
            this.Name = tag;
            childElementsConteiner = new List<IElement>();
        }

        public HTMLElement(string tag, string content)
            : this(tag)
        {
            this.TextContent = content;
        }

        public virtual void AddElement(IElement element)
        {
            this.childElementsConteiner.Add(element);
        }

        public virtual void Render(StringBuilder output)
        {
            output.Append("<" + this.Name + ">");
            if (this.TextContent != null)
            {
                output.Append(this.TextContent);
            }
            if (childElementsConteiner.Count > 0)
            {
                foreach (var item in childElementsConteiner)
                {
                    HTMLElement currElement = item as HTMLElement;
                    if (currElement != null)
                    {
                        output.Append(currElement.ToString());
                    }
                }
            }
            output.Append("</" + this.Name + ">");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            this.Render(sb);
            return sb.ToString();
        }
    }

    public class HTMLTable : HTMLElement, ITable
    {
        private IElement[,] tableElements;

        public HTMLTable(int rows, int cols)
            : base("table")
        {
            this.Rows = rows;
            this.Cols = cols;
            tableElements = new IElement[Rows, Cols];
        }

        public int Rows { get; private set; }

        public int Cols { get; private set; }

        public IElement this[int row, int col]
        {
            get
            {
                return this.tableElements[row, col];
            }
            set
            {
                this.tableElements[row, col] = value;
            }
        }

        public override void Render(StringBuilder output)
        {
            output.Append("<table>");
            for (int row = 0; row < this.tableElements.GetLength(0); row++)
            {
                output.Append("<tr>");
                for (int col = 0; col < this.tableElements.GetLength(1); col++)
                {
                    output.Append("<td>" + this.tableElements[row, col] + "</td>");
                }
                output.Append("</tr>");
            }
            output.Append("</table>");
        }

        public override string TextContent
        {
            get
            {
                return null;
            }
            set
            {
                throw new InvalidOperationException("Tables cannot have text content");
            }
        }

        public override void AddElement(IElement element)
        {
            throw new InvalidOperationException("Tables cannot have childs");
        }
    }

    public class HTMLRendererCommandExecutor
    {
        static void Main()
        {
            string csharpCode = ReadInputCSharpCode();
            CompileAndRun(csharpCode);
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                result.AppendLine(line);
            }
            return result.ToString();
        }

        static void CompileAndRun(string csharpCode)
        {
            // Prepare a C# program for compilation
            string[] csharpClass =
            {
                @"using System;
                  using HTMLRenderer;

                  public class RuntimeCompiledClass
                  {
                     public static void Main()
                     {"
                        + csharpCode + @"
                     }
                  }"
            };

            // Compile the C# program
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.TempFiles = new TempFileCollection(".");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            CSharpCodeProvider csharpProvider = new CSharpCodeProvider();
            CompilerResults compile = csharpProvider.CompileAssemblyFromSource(
                compilerParams, csharpClass);

            // Check for compilation errors
            if (compile.Errors.HasErrors)
            {
                string errorMsg = "Compilation error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    errorMsg += "\r\n" + ce.ToString();
                }
                throw new Exception(errorMsg);
            }

            // Invoke the Main() method of the compiled class
            Assembly assembly = compile.CompiledAssembly;
            Module module = assembly.GetModules()[0];
            Type type = module.GetType("RuntimeCompiledClass");
            MethodInfo methInfo = type.GetMethod("Main");
            methInfo.Invoke(null, null);
        }
    }
}
