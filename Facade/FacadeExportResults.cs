using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;
using System.Xml.Linq;
using System.IO;
using Builder;

namespace Facade
{
    public class FacadeExportResults
    {
        public List<CliqueDocument> m_Commands;
        public FacadeExportResults()
        {
            m_Commands = new List<CliqueDocument>();
        }

        public List<CliqueDocument> ConstructDocument(Clique i_GivenClique, List<eFileFormat> i_WantedFormats, string i_FilePath)
        {
            m_Commands.Clear();
            foreach (var format in i_WantedFormats)
            {
                switch (format)
                {
                    case eFileFormat.TXT:
                        m_Commands.Add(new CliqueDocument() { Command = new TxtDocCommand() { Client = this, CurrentCliqueToExport = i_GivenClique, ESaveOptions = eSaveOptions.Sole ,CurrentPath=i_FilePath} });
                        break;
                    case eFileFormat.XML:
                        m_Commands.Add(new CliqueDocument() { Command = new XmlDocCommand() { Client = this, CurrentCliqueToExport = i_GivenClique, ESaveOptions = eSaveOptions.Sole, CurrentPath = i_FilePath } });
                        break;
                    default:
                        break;
                }
            }

            return m_Commands;
        }
        public List<CliqueDocument> ConstructDocument(ICollection<Clique> i_GivenCliques, List<eFileFormat> i_WantedFormats, string i_FilePath)
        {
            m_Commands.Clear();
            foreach (var format in i_WantedFormats)
            {
                switch (format)
                {
                    case eFileFormat.TXT:
                        m_Commands.Add(new CliqueDocument() { Command = new TxtDocCommand() { Client = this, CurrentCliquesToExport = i_GivenCliques, ESaveOptions = eSaveOptions.Multiple, CurrentPath = i_FilePath } });
                        break;
                    case eFileFormat.XML:
                        m_Commands.Add(new CliqueDocument() { Command = new XmlDocCommand() { Client = this, CurrentCliquesToExport = i_GivenCliques, ESaveOptions = eSaveOptions.Multiple, CurrentPath = i_FilePath } });
                        break;
                    default:
                        break;
                }
            }

            return m_Commands;
        }
        private void createTxtDoc(Clique i_GivenClique, string i_FilePath)
        {
            new TxtBuilder().CreateDoc(i_GivenClique, i_FilePath);
        }
        private void createTxtDoc(ICollection<Clique> i_GivenCliques, string i_FilePath)
        {
            new TxtBuilder().CreateDoc(i_GivenCliques, i_FilePath);
        }
        private void createXmlDoc(ICollection<Clique> i_GivenCliques, string i_FilePath)
        {
            new XmlBuilder().CreateDoc(i_GivenCliques, i_FilePath);
        }
        private void createXmlDoc(Clique i_GivenClique, string i_FilePath)
        {
            new XmlBuilder().CreateDoc(i_GivenClique, i_FilePath);
        }

        private class TxtDocCommand : ICliqueDocCommand, ICliqueDocProperties
        {
            public FacadeExportResults Client { get; set; }
            public Clique CurrentCliqueToExport { get; set; }
            public ICollection<Clique> CurrentCliquesToExport { get; set; }
            public string CurrentPath { get; set; }
            public eSaveOptions ESaveOptions { get; set; }
            public TxtDocCommand() { }
            public void Execute()
            {
                switch (ESaveOptions)
                {
                    case eSaveOptions.Sole:
                        Client.createTxtDoc(CurrentCliqueToExport, CurrentPath);
                        break;
                    case eSaveOptions.Multiple:
                        Client.createTxtDoc(CurrentCliquesToExport, CurrentPath);
                        break;
                }
            }
        }
        private class XmlDocCommand : ICliqueDocCommand, ICliqueDocProperties
        {
            public FacadeExportResults Client { get; set; }
            public Clique CurrentCliqueToExport { get; set; }
            public ICollection<Clique> CurrentCliquesToExport { get; set; }
            public string CurrentPath { get; set; }
            public eSaveOptions ESaveOptions { get; set; }
            public XmlDocCommand() { }
            public void Execute()
            {
                switch (ESaveOptions)
                {
                    case eSaveOptions.Sole:
                        Client.createXmlDoc(CurrentCliqueToExport, CurrentPath);
                        break;
                    case eSaveOptions.Multiple:
                        Client.createXmlDoc(CurrentCliquesToExport, CurrentPath);
                        break;
                }
            }
        }

    }

}
