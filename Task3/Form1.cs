using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        Assembly assembly = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                try
                {
                    assembly = Assembly.LoadFile(path);

                    textBox.Text += "File  " + path + "  -  loaded" + Environment.NewLine + Environment.NewLine;
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }


                textBox.Text += "Info of assembly:     " + assembly.FullName + Environment.NewLine + Environment.NewLine;

                Type[] types = assembly.GetTypes();

                foreach (Type type in types)
                {
                    textBox.Text += "Type:  " + type.FullName + Environment.NewLine;
                    var attributes = type.GetCustomAttributes();
                    if (attributes != null)
                    {
                        foreach (var attribute in attributes)
                        {
                            string methStr = "Type attribute: " + attribute.GetType().FullName + "\n";
                            textBox.Text += methStr + Environment.NewLine;
                        }
                    }

                    if (checkBoxMethods.Checked)
                    {
                        var methods = type.GetMethods();
                        if (methods != null)
                        {
                            foreach (var method in methods)
                            {
                                string methStr = "Method: " + method.Name + ", return type = " + method.ReturnType + "\n";
                                var subAttributes = method.GetCustomAttributes();
                                if (subAttributes != null)
                                {
                                    foreach (var attribute in subAttributes)
                                    {
                                        methStr = "Type attribute: " + attribute.GetType().FullName + "\n";
                                        textBox.Text += methStr + Environment.NewLine;
                                    }
                                }
                                textBox.Text += methStr + Environment.NewLine;
                            }
                        }
                    }

                    if (checkBoxFields.Checked)
                    {
                        var fields = type.GetFields();
                        if (fields != null)
                        {
                            foreach (var field in fields)
                            {
                                string methStr = "Field: " + field.Name + ", type = " + field.FieldType + "\n";
                                var subAttributes = field.GetCustomAttributes();
                                if (subAttributes != null)
                                {
                                    foreach (var attribute in subAttributes)
                                    {
                                        methStr = "Type attribute: " + attribute.GetType().FullName + "\n";
                                        textBox.Text += methStr + Environment.NewLine;
                                    }
                                }
                                textBox.Text += methStr + Environment.NewLine;
                            }
                        }
                    }

                    if (checkBoxProperties.Checked)
                    {
                        var properties = type.GetProperties();
                        if (properties != null)
                        {
                            foreach (var property in properties)
                            {
                                string methStr = "Property: " + property.Name + ", type = " + property.PropertyType + "\n";
                                var subAttributes = property.GetCustomAttributes();
                                if (subAttributes != null)
                                {
                                    foreach (var attribute in subAttributes)
                                    {
                                        methStr = "Type attribute: " + attribute.GetType().FullName + "\n";
                                        textBox.Text += methStr + Environment.NewLine;
                                    }
                                }
                                textBox.Text += methStr + Environment.NewLine;
                            }
                        }
                    }

                    textBox.Text += Environment.NewLine;
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
