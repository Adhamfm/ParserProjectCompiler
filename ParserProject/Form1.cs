using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static ParserProject.Parser;

namespace ParserProject
{
    public partial class Form1 : Form
    {
        Form2 frm;

        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TextBoxWriter writer = new TextBoxWriter(txtConsole);
            Console.SetOut(writer);
            txtConsole.Clear();
            txtConsole.Refresh();
            frm = new Form2(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    Console.WriteLine("START");
            //    var tokens = new List<(string, TokenType)>
            //{
            //    ("x", TokenType.IDENTIFIER),
            //    (":=", TokenType.ASSIGN),
            //    ("5", TokenType.NUMBER),
            //    (";", TokenType.SEMICOLON),
            //    ("IF", TokenType.IF),
            //    ("x", TokenType.IDENTIFIER),
            //    ("<", TokenType.LESSTHAN),
            //    ("10", TokenType.NUMBER),
            //    ("THEN", TokenType.THEN),
            //    ("WRITE", TokenType.WRITE),
            //    ("x", TokenType.IDENTIFIER),
            //    (";", TokenType.SEMICOLON),
            //    ("END", TokenType.END),
            //    (";", TokenType.SEMICOLON)
            //    // Add more tokens as needed
            //};

            //    Parser parser = new Parser(tokens);
            //    parser.Parse();
            //    Console.WriteLine("FINISH");

            // Create the root node
            TreeNode rootNode = new TreeNode("Root");

            // Create three children nodes
            TreeNode child1 = new TreeNode("Child 1");
            TreeNode child2 = new TreeNode("Child 2");
            TreeNode child3 = new TreeNode("Child 3");

            // Add children to the root node
            rootNode.Nodes.Add(child1);
            rootNode.Nodes.Add(child2);
            rootNode.Nodes.Add(child3);
            treeView1.Nodes.Add(rootNode);

            Bitmap bmp = new Bitmap(500, 500);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.FillRectangle(Brushes.Green, 0, 0, 10, 10);
                g.DrawEllipse(Pens.Black, 10, 10, 100, 100);
            }

            pictureBox1.Image = bmp;
        }

        private void btn_showForm2_Click(object sender, EventArgs e)
        {
            //if (frm.IsDisposed) frm = new Form2(this);
            //frm.Show();
            //Node childLeft = new Node("13");
            //Node childRight = new Node("234");
            //Node childMiddle = new Node("+");
            //Node root = new Node("assign", childLeft, childMiddle, childRight,null);
            //Console.WriteLine("from form 2");
            //Node childLeft2 = new Node("stmt");
            //Node childRight2 = new Node("()");
            //Node childMiddle2 = new Node("else");
            //Node root2 = new Node("if", childLeft2, childRight2,null);
            //Node root3 = new Node("Test", root, root2,null);
            //drawTest(root);
            //drawTest(root2);
            //drawTest(root3);
            List<string[]> tokens = new List<string[]>();

            // Add tokens to the list with switched positions
            tokens.Add(new string[] { "read", "READ" });
            tokens.Add(new string[] { "x", "IDENTIFIER" });
            tokens.Add(new string[] { ";", "SEMICOLON" });
            tokens.Add(new string[] { "if", "IF" });
            tokens.Add(new string[] { "0", "NUMBER" });
            tokens.Add(new string[] { "<", "LESSTHAN" });
            tokens.Add(new string[] { "x", "IDENTIFIER" });
            tokens.Add(new string[] { "then", "THEN" });
            tokens.Add(new string[] { "fact", "IDENTIFIER" });
            tokens.Add(new string[] { ":=", "ASSIGN" });
            tokens.Add(new string[] { "1", "NUMBER" });
            tokens.Add(new string[] { ";", "SEMICOLON" });
            tokens.Add(new string[] { "repeat", "REPEAT" });
            tokens.Add(new string[] { "fact", "IDENTIFIER" });
            tokens.Add(new string[] { ":=", "ASSIGN" });
            tokens.Add(new string[] { "fact", "IDENTIFIER" });
            tokens.Add(new string[] { "*", "MULT" });
            tokens.Add(new string[] { "x", "IDENTIFIER" });
            tokens.Add(new string[] { ";", "SEMICOLON" });
            tokens.Add(new string[] { "x", "IDENTIFIER" });
            tokens.Add(new string[] { ":=", "ASSIGN" });
            tokens.Add(new string[] { "x", "IDENTIFIER" });
            tokens.Add(new string[] { "-", "MINUS" });
            tokens.Add(new string[] { "1", "NUMBER" });
            tokens.Add(new string[] { "until", "UNTIL" });
            tokens.Add(new string[] { "x", "IDENTIFIER" });
            tokens.Add(new string[] { "=", "EQUAL" });
            tokens.Add(new string[] { "0", "NUMBER" });
            tokens.Add(new string[] { ";", "SEMICOLON" });
            tokens.Add(new string[] { "write", "WRITE" });
            tokens.Add(new string[] { "fact", "IDENTIFIER" });
            tokens.Add(new string[] { "end", "END" });



            Parser parser = new Parser(tokens);
            List<Node> nodes = null;

            try
            {
                nodes = parser.PrintTree();
                foreach (Node node in nodes)
                {
                    Console.WriteLine("Printing; " + node.value);
                    if (node.right != null)
                    {
                        foreach (Node right in node.right)
                        {
                            Console.WriteLine("Children right; " + right.value);
                            foreach (Node x in right.right)
                            {
                                Console.WriteLine("Children right; " + x.value);
                            }
                        }
                    }
                    if (node.middle != null)
                    {
                        foreach (Node middle in node.middle)
                        {
                            Console.WriteLine("Children Middle; " + middle.value);
                            foreach (Node x in middle.middle)
                            {
                                Console.WriteLine("Children Middle; " + x.value);
                            }
                        }
                    }
                    if (node.left != null)
                        Console.WriteLine("Children Left; " + node.left.value);
                    //drawTest(node);
                }
                Console.WriteLine("Parsing and printing successful!");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Parsing failed: " + ex.Message);
            }
            //MeDraw(nodes);
            drawTest(nodes);
        }
        
        public void drawTest(List<Node> x)
        {
            int temp;
            Form newForm = new Form();

            // Set properties for the new form
            newForm.Text = "Dynamic Form";
            newForm.Size = new System.Drawing.Size(500, 500);
            //newForm.StartPosition = FormStartPosition.CenterScreen;
            PictureBox pictureBox = new PictureBox();

            pictureBox.Image = MeDraw(x);
            //pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;
            panel.Controls.Add(pictureBox);
            panel.AutoScroll = true;
            panel.Padding = new Padding(10, 10, 10, 10);
            newForm.Controls.Add(panel);
            // Show the new form
            newForm.Show();

            //pictureBox1.Image = x.Draw(out temp);
        }

        private static Font font = new Font("Arial", 15f, FontStyle.Regular);
        int sizeWidth = 4000;
        int sizeHeight = 1000;
        int globalX = 10;
        int levelY0 = 20;
        int levelY1 = 120;
        int levelY2 = 240;
        int levelY3 = 360;
        int levelY4 = 480;
        int recWidth = 100;
        int recHeight = 50;
        // grid 100x100
        string str = "";
        public Image MeDraw(List<Node> nodes)
        { 
            var result = new Bitmap(sizeWidth,sizeHeight);
            Graphics g = Graphics.FromImage(result);
            //g.DrawString(str, font, Brushes.Black, lSize.Width - _nodeBg.Width / 2 + _freeSpace.Width / 2 + (2 + (str.Length == 1 ? 10 : str.Length == 2 ? 5 : 0)) * Coef, _nodeBg.Height / 2f - 12 * Coef);

            // Level 0
            foreach (Node node in nodes)
            {
                int _child = 0;
                _child = node.CountChildren() - 1;
                var rcl = new Rectangle(globalX, levelY0, recWidth,recHeight);
                g.DrawRectangle(new Pen(Color.Black, 1.2f), rcl);
                str = node.value;
                g.DrawString(str, font, Brushes.Black, globalX + 5, levelY0+5);

                // Level 1 Left
                if (node.left != null)
                {
                    int localX = 0;
                    if (globalX > 50)
                        localX = globalX - 100;
                    else
                        localX = 10;

                    var rcl2 = new Rectangle(localX, levelY1, recWidth, recHeight);
                    g.DrawRectangle(new Pen(Color.Black, 1.2f), rcl2);
                    str = node.left.value;
                    g.DrawString(str, font, Brushes.Black, localX + 5, levelY1 + 5);
                    // Level 2 left
                    if (node.left.left != null)
                        recDraw(g, node.left.left);
                    if(node.left.middle != null)
                        recDraw(g, node.left.middle);
                    if (node.left.right != null)
                        recDraw(g, node.left.right);
                    
                    globalX += 100;
                }
                // Level 1 Middle
                if (node.middle != null)
                {
                    foreach (Node midNode1 in node.middle)
                    {
                        int localX = 0;
                        if (globalX > 50)
                            localX = globalX;
                        else
                            localX = 10;
                        var rcl3 = new Rectangle(localX, levelY1, recWidth, recHeight);
                        g.DrawRectangle(new Pen(Color.Black, 1.2f), rcl3);
                        str = midNode1.value;
                        g.DrawString(str, font, Brushes.Black, localX + 5, levelY1 + 5);
                        // Level 2 Middle
                        recDraw(g, midNode1.left);
                        recDraw(g, midNode1.middle);
                        recDraw(g, midNode1.right);
                        globalX += 150;
                    }
                }

                // Level 1 Right
                if (node.right != null)
                {
                    foreach (Node rightNode1 in node.right)
                    {
                        int localX = 0;
                        if (globalX > 50)
                            localX = globalX+50;
                        else
                            localX = 10;
                        var rcl4 = new Rectangle(localX, levelY1, recWidth, recHeight);
                        g.DrawRectangle(new Pen(Color.Black, 1.2f), rcl4);
                        str = rightNode1.value;
                        g.DrawString(str, font, Brushes.Black, localX + 5, levelY1 + 5);
                        // Level 2 Right
                        recDraw(g, rightNode1.left);
                        recDraw(g, rightNode1.middle);
                        recDraw(g, rightNode1.right);
                        globalX += 150;
                    }
                }
                

                globalX += 200;
            }

            return result;
        }

        public void recDraw(Graphics g, Node node)
        {
            if (node == null) return;
            int localX2 = 0;
            if (globalX > 50)
                localX2 = globalX - 150;
            else
                localX2 = 10;

            var rcl2l = new Rectangle(localX2, levelY2, recWidth, recHeight);
            g.DrawRectangle(new Pen(Color.Black, 1.2f), rcl2l);
            
            str = node.value;
            g.DrawString(str, font, Brushes.Black, localX2 + 5, levelY2 + 5);
            if (node.left != null)
                recDraw2(g, node.left);
            if (node.middle != null)
                recDraw2(g, node.middle);
            if (node.right != null)
                recDraw2(g, node.right);
        }
        public void recDraw(Graphics g, List<Node> nodes)
        {
            if (nodes == null) return;  
            foreach (Node node in nodes)
            {
                int localX2 = globalX;
                if (globalX > 50)
                    localX2 = globalX;
                else
                    localX2 = 10;
                var rcl3l = new Rectangle(localX2, levelY2, recWidth, recHeight);
                g.DrawRectangle(new Pen(Color.Black, 1.2f), rcl3l);
                str = node.value;
                g.DrawString(str, font, Brushes.Black, localX2 + 5, levelY2 + 5);
                recDraw2(g, node.left);
                recDraw2(g, node.middle);
                recDraw2(g, node.right);
                globalX += 200;
            }
        }
        public void recDraw2(Graphics g, Node node)
        {
            if (node == null) return;
            int localX2 = 0;
            if (globalX > 50)
                localX2 = globalX - 150;
            else
                localX2 = 10;

            var rcl2l = new Rectangle(localX2, levelY3, recWidth, recHeight);
            g.DrawRectangle(new Pen(Color.Black, 1.2f), rcl2l);

            str = node.value;
            g.DrawString(str, font, Brushes.Black, localX2 + 5, levelY3 + 5);
            if (node.left != null)
                recDraw3(g, node.left);
            if (node.middle != null)
                recDraw3(g, node.middle);
            if (node.right != null)
                recDraw3(g, node.right);
        }
        public void recDraw2(Graphics g, List<Node> nodes)
        {
            if (nodes == null) return;
            foreach (Node node in nodes)
            {
                int localX2 = globalX;
                if (globalX > 50)
                    localX2 = globalX;
                else
                    localX2 = 10;
                var rcl3l = new Rectangle(localX2, levelY3, recWidth, recHeight);
                g.DrawRectangle(new Pen(Color.Black, 1.2f), rcl3l);
                str = node.value;
                g.DrawString(str, font, Brushes.Black, localX2 + 5, levelY3 + 5);
                recDraw3(g, node.left);
                recDraw3(g, node.middle);
                recDraw3(g, node.right);
                globalX += 200;
            }
        }
        public void recDraw3(Graphics g, Node node)
        {
            if (node == null) return;
            int localX2 = 0;
            if (globalX > 50)
                localX2 = globalX - 150;
            else
                localX2 = 10;

            var rcl2l = new Rectangle(localX2, levelY4, recWidth, recHeight);
            g.DrawRectangle(new Pen(Color.Black, 1.2f), rcl2l);

            str = node.value;
            g.DrawString(str, font, Brushes.Black, localX2 + 5, levelY4 + 5);
            
        }
        public void recDraw3(Graphics g, List<Node> nodes)
        {
            if (nodes == null) return;
            foreach (Node node in nodes)
            {
                int localX2 = globalX;
                if (globalX > 50)
                    localX2 = globalX;
                else
                    localX2 = 10;
                var rcl3l = new Rectangle(localX2, levelY4, recWidth, recHeight);
                g.DrawRectangle(new Pen(Color.Black, 1.2f), rcl3l);
                str = node.value;
                g.DrawString(str, font, Brushes.Black, localX2 + 5, levelY4 + 5);
               
                globalX += 200;
            }
        }
    }
}

