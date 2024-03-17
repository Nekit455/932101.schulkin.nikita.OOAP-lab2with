using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyWeightApp
{
    public partial class Form1 : Form
    {
        private ElementFactory factory = new ElementFactory();
        private Client client = new Client();

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBoxBtn_Click(object sender, EventArgs e)
        {
            IElement elem = factory.GetElement("TextBox");
            lblTb.Text = "________________\n|________________|";
            client.AddElement(elem);
        }

        private void ButtonBtn_Click(object sender, EventArgs e)
        {
            IElement elem = factory.GetElement("button");
            lblBtn.Text = "_____\n| Click |";
            client.AddElement(elem);
        }

        private void ImageBtn_Click(object sender, EventArgs e)
        {
            IElement elem = factory.GetElement("image");
            lblImg.Text = "_______\n|            |\n|  o_O   |\n|______|";
            client.AddElement(elem);
        }

        public class Client
        {
            private string str;
            private List<IElement> elements = new List<IElement>(); 

            public void AddElement(IElement element)
            {
                elements.Add(element); // заполняем список элементов для хранения
                element.Display(); // отображаем элемент
            }

            public void CheckAll()
            {
                
                foreach (var element in elements) // выводим список элементов
                {
                    str += element.Info();
                    str += '\n';   
                }
                MessageBox.Show($"Полученные элементы:\n\n{str}");
                str = "";
            }

            public void ClearAll() // удаляем все элементы
            {
                elements.Clear();
            }
        }

        public interface IElement
        {
            void Display();
            string Info();
        }

        public class TextBox : IElement
        {
            public void Display()
            {
                MessageBox.Show("Получен элемент TextBox");
            }
            public string Info()
            {
                return "TextBox";
            }
        }

        public class Button : IElement
        {
          
            public void Display()
            {
                MessageBox.Show("Получен элемент Button");
            }
            public string Info()
            {
                return "Button";
            }
        }

        public class Image : IElement
        {
            public void Display()
            {
                MessageBox.Show("Получен элемент Image");
            }
            public string Info()
            {
                return "Image";
            }
        }

        public class ElementFactory
        {
            // создаем пространство для хранения кэшей элементов
            private Dictionary<string, IElement> elemCache = new Dictionary<string, IElement>(); 
            
            public IElement GetElement(string elem) // выдача элементов по запросу
            {
                if (!elemCache.ContainsKey(elem))
                {
                    MessageBox.Show($"На фабрике будет создан элемент {elem}");
                    if (elem == "TextBox")
                        elemCache[elem] = new TextBox();
                    else if (elem == "button")
                        elemCache[elem] = new Button();
                    else if (elem == "image")
                        elemCache[elem] = new Image();
                }

                return elemCache[elem];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CLearBtn_Click(object sender, EventArgs e)
        {
            lblTb.Text = "";
            lblBtn.Text = "";
            lblImg.Text = "";
            client.ClearAll();
        }

        private void AddAllBtn_Click(object sender, EventArgs e)
        {
            client.CheckAll();
        }
    }
}
