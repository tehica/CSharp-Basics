using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ReflectionDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // u TextBox mozemo unositi npr. : 
            // System.Console, System.String, System.Int32, System.Double, System.Text.StringBuilder

            string TypeName = textBox1.Text;
            Type T = Type.GetType(TypeName);

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            MethodInfo[] methods = T.GetMethods();
            foreach(MethodInfo method in methods)
            {
                listBox1.Items.Add(method.ReturnType.Name + " " + method.Name);
            }

            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                listBox2.Items.Add(property.Name);
            }

            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                listBox3.Items.Add(constructor.ToString());
            }
        }
    }
}
