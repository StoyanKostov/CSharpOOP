using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    class Program
    {
        private static List<IDocument> docContainer = new List<IDocument>();

        static void Main()
        {
            IList<string> allCommands = ReadAllCommands();
            ExecuteCommands(allCommands);
        }

        private static IList<string> ReadAllCommands()
        {
            List<string> commands = new List<string>();
            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == "")
                {
                    // End of commands
                    break;
                }
                commands.Add(commandLine);
            }
            return commands;
        }

        private static void ExecuteCommands(IList<string> commands)
        {
            foreach (var commandLine in commands)
            {
                int paramsStartIndex = commandLine.IndexOf("[");
                string cmd = commandLine.Substring(0, paramsStartIndex);
                int paramsEndIndex = commandLine.IndexOf("]");
                string parameters = commandLine.Substring(
                    paramsStartIndex + 1, paramsEndIndex - paramsStartIndex - 1);
                ExecuteCommand(cmd, parameters);
            }
        }

        private static void ExecuteCommand(string cmd, string parameters)
        {
            string[] cmdAttributes = parameters.Split(
                new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            if (cmd == "AddTextDocument")
            {
                AddTextDocument(cmdAttributes);
            }
            else if (cmd == "AddPDFDocument")
            {
                AddPdfDocument(cmdAttributes);
            }
            else if (cmd == "AddWordDocument")
            {
                AddWordDocument(cmdAttributes);
            }
            else if (cmd == "AddExcelDocument")
            {
                AddExcelDocument(cmdAttributes);
            }
            else if (cmd == "AddAudioDocument")
            {
                AddAudioDocument(cmdAttributes);
            }
            else if (cmd == "AddVideoDocument")
            {
                AddVideoDocument(cmdAttributes);
            }
            else if (cmd == "ListDocuments")
            {
                ListDocuments();
            }
            else if (cmd == "EncryptDocument")
            {
                EncryptDocument(parameters);
            }
            else if (cmd == "DecryptDocument")
            {
                DecryptDocument(parameters);
            }
            else if (cmd == "EncryptAllDocuments")
            {
                EncryptAllDocuments();
            }
            else if (cmd == "ChangeContent")
            {
                ChangeContent(cmdAttributes[0], cmdAttributes[1]);
            }
            else
            {
                throw new InvalidOperationException("Invalid command: " + cmd);
            }
        }

        private static void AddTextDocument(string[] attributes)
        {
            AddDoc(new TextDoc(), attributes);
        }

        private static void AddPdfDocument(string[] attributes)
        {
            AddDoc(new PDF(), attributes);
        }

        private static void AddWordDocument(string[] attributes)
        {
            AddDoc(new Word(), attributes);
        }

        private static void AddExcelDocument(string[] attributes)
        {
            AddDoc(new Excel(), attributes);
        }

        private static void AddAudioDocument(string[] attributes)
        {
            AddDoc(new Audio(), attributes);
        }

        private static void AddVideoDocument(string[] attributes)
        {
            AddDoc(new Video(), attributes);
        }

        private static void ListDocuments()
        {
            if (docContainer.Count() == 0)
            {
                Console.WriteLine("No documents found");
            }
            else
            {
                foreach (var doc in docContainer)
                {
                    if ((doc is IEncryptable) && (((IEncryptable)doc).IsEncrypted))
                    {
                        Console.WriteLine("{0}[encrypted]", doc.GetType().Name);
                    }
                    else
                    {
                        Console.WriteLine(doc.ToString());
                    }
                }   
            }
        }

        private static void EncryptDocument(string name)
        {
            if (!docContainer.Any(entry => entry.Name == name))
            {
                Console.WriteLine("Document not found: {0}", name);
            }
            else
            {
                foreach (IDocument doc in docContainer)
                {
                    if (doc.Name == name)
                    {
                        if (doc is IEncryptable)
                        {
                            ((IEncryptable)doc).Encrypt();
                            Console.WriteLine("Document encrypted: {0}", doc.Name);
                        }
                        else
                        {
                            Console.WriteLine("Document does not support encryption: {0}", doc.Name);
                        }
                    }
                }
            }
        }

        private static void DecryptDocument(string name)
        {
            if (!docContainer.Any(entry => entry.Name == name))
            {
                Console.WriteLine("Document not found: {0}", name);
            }
            else
            {
                foreach (IDocument doc in docContainer)
                {
                    if (doc.Name == name)
                    {
                        if (doc is IEncryptable)
                        {
                            ((IEncryptable)doc).Decrypt();
                            Console.WriteLine("Document decrypted: {0}", doc.Name);
                        }
                        else
                        {
                            Console.WriteLine("Document does not support decryption: {0}", doc.Name);
                        }
                    }
                }
            }
        }

        private static void EncryptAllDocuments()
        {
            if (!docContainer.Any(doc => doc is IEncryptable))
            {
                Console.WriteLine("No encryptable documents found");
            }
            else
            {
                foreach (IDocument doc in docContainer)
                {
                    if (doc is IEncryptable)
                    {
                        ((IEncryptable)doc).Encrypt();
                    }
                }
                Console.WriteLine("All documents encrypted");
            }
        }

        private static void ChangeContent(string name, string content)
        {
            if (!docContainer.Any(entry => entry.Name == name))
            {
                Console.WriteLine("Document not found: {0}", name);
            }
            else
            {
                foreach (IDocument doc in docContainer)
                {
                    if (doc.Name == name)
                    {
                        if (doc is IEditable)
                        {
                            ((IEditable)doc).ChangeContent(content);
                            Console.WriteLine("Document content changed: {0}", doc.Name);
                        }
                        else
                        {
                            Console.WriteLine("Document is not editable: {0}", doc.Name);
                        }
                    }
                }
            }
        }

        private static void AddDoc(IDocument doc, string[] attributes)
        {
            foreach (string attribute in attributes) //attribut = "key1=value1";
            {
                int separator = attribute.IndexOf("=");
                string key = attribute.Substring(0, separator);
                string value = attribute.Substring(separator + 1);
                doc.LoadProperty(key, value);
            }
            if (doc.Name != null)
            {
                docContainer.Add(doc);
                Console.WriteLine("Document added: {0}", doc.Name);
            }
            else
            {
                Console.WriteLine("Document has no namе");
            }
           
        }
    }
}
