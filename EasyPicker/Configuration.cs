using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Runtime;
using System.IO;

namespace EasyPicker {
    public class Configuration {
        public string filename;
        XmlDocument doc;
        public int s;
        public int e;
        public string[] name;
        
        public Configuration(string filename) {
            this.filename = filename;
            doc = new XmlDocument();
            if (File.Exists(filename)) this.LoadConfig();
            else {
                s = 1;
                e = 30;
                name = new String[31];
                this.createXml();
                this.saveConfig();
            }
        }

        // Loading
        public void LoadConfig() {
            doc.Load(filename);
            parseXml();
        }

        // Parsing
        private void parseXml() {
            s = Convert.ToInt32(doc.DocumentElement.ChildNodes[0].Attributes["from"].LastChild.InnerText);
            e = Convert.ToInt32(doc.DocumentElement.ChildNodes[0].Attributes["to"].LastChild.InnerText);
            name = new string[e - s + 2];
            foreach (XmlNode n in doc.DocumentElement.ChildNodes[1].ChildNodes) {
                int id = Convert.ToInt32(n.Attributes[0].ChildNodes[0].InnerText);
                name[id] = n.ChildNodes[0].InnerText;
            }
        }

        // Creating
        private void createXml() {
            // Root
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.CreateElement("EasyPicker");
            doc.AppendChild(dec);
            doc.AppendChild(root);

            // Range
            XmlElement range = doc.CreateElement("range");
            XmlAttribute from = doc.CreateAttribute("from");
            XmlText fromt = doc.CreateTextNode(s.ToString());
            XmlAttribute to = doc.CreateAttribute("to");
            XmlText tot = doc.CreateTextNode(e.ToString());
            root.AppendChild(range);
            {
                range.SetAttributeNode(from);
                {
                    from.AppendChild(fromt);
                }
                range.SetAttributeNode(to);
                {
                    to.AppendChild(tot);
                }

            }

            // Students
            XmlElement students = doc.CreateElement("students");
            root.AppendChild(students);

            XmlElement student;
            XmlAttribute id;
            XmlText idvalve;
            XmlText studentname;
            for (int i = s; i <= e; i++) {
                student = doc.CreateElement("student");
                id = doc.CreateAttribute("id");
                idvalve = doc.CreateTextNode(i.ToString());
                studentname = doc.CreateTextNode(name[i]);

                students.AppendChild(student);
                {
                    student.SetAttributeNode(id);
                    {
                        id.AppendChild(idvalve);
                    }
                    //student.AppendChild(studentname);
                }
            }
        }

        // Saving
        public void saveConfig() {
            doc.Save(filename);
        }
    }
}
