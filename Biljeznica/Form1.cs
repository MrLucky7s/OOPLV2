using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;



//Isprike što vježbu s LV-a šaljem sa zakašnjenjem, očekivao sam da ćemo imati standardni rok od tjedan dana umjesto samo 4.

namespace Biljeznica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //otvaranje rtf file-ova
            openFile.DefaultExt = ".rtf";
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK )   
            {
                richTextBox.LoadFile(openFile.FileName);
            }
            else
            {
                MessageBox.Show("The file you've chosen is not a text file");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //spremanje teksta u RTF file
            saveFile.DefaultExt = ".rtf";
            saveFile.Filter = "RTF FILES | .rtf";
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)   
            {
                richTextBox.SaveFile(saveFile.FileName);
 
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //dijalog box za izbor font-a i boje
            fontDialog.ShowColor = true;   
            if (fontDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox.Font = fontDialog.Font;
                richTextBox.ForeColor = fontDialog.Color;

                
            }
        }
    }  
}
