using HubCrawl.Core;
using HubCrawl.Core.Apps;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Yuhan.Common.Extensions;

namespace HubCrawl.Core.Providers
{
    public abstract class HubCrawlProvider<T>
        where T : HubCrawlCluster
    {
        public abstract ObservableCollection<T> Cluster { get; }

        public abstract String DirectoryPath { get; }
        public abstract string FileName { get; }
        public const String FileExtension = "xml";

        public String FilePath { get { return String.Format("{0}/{1}.{2}", DirectoryPath, FileName, FileExtension); } }
             

        public void Initialize()
        {
            DirectoryInitialize();
            FileInitialize();
            ReLoadModules();
        }

        protected void DirectoryInitialize()
        {
            DirectoryInfo directory = new DirectoryInfo(DirectoryPath);
            if (!directory.Exists) { directory.Create(); }
        }

        protected void FileInitialize()
        {
            FileInfo file = new FileInfo(FilePath);
            if (!file.Exists)
            {
                XmlSerializer writer = new XmlSerializer(typeof(ObservableCollection<T>));
                StreamWriter sw = new StreamWriter(FilePath);
                var apps = new ObservableCollection<T>();
                writer.Serialize(sw, this.Cluster);
                sw.Close();
            }
        }
        
        private void ReLoadModules()
        {
            Cluster.Clear();
            XmlDocument xDocument = new XmlDocument();
            xDocument.Load(FilePath);
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<T>));
            using (StringReader reader = new StringReader(xDocument.OuterXml))
            {
                ObservableCollection<T> moduleCollection = (ObservableCollection<T>)(serializer.Deserialize(reader));
                Cluster.AddRange(moduleCollection);
            }
        }
    }
}
