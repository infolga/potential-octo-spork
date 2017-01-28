using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace EditorTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2_Click_1(true, new EventArgs ());
        }
        private void AddControl( )
        {
           

            this.panelQw.Controls.Clear();
            if (Datass.QQ[Datass.polz] is OnePossibleAnswers)
            {
                OnePossibleAnswers buf = (OnePossibleAnswers)Datass.QQ[Datass.polz];
                SpisokBoxTip.SelectedIndex = 0;
                this.panelQw.Controls.AddRange(buf.masEl);
            }
            else if (Datass.QQ[Datass.polz] is SeveralPossibleAnswers)
            {
                SeveralPossibleAnswers buf = (SeveralPossibleAnswers)Datass.QQ[Datass.polz];
                this.panelQw.Controls.AddRange(buf.masEl);
                SpisokBoxTip.SelectedIndex = 1;
            }
            else if (Datass.QQ[Datass.polz] is QuestionForCompliance)
            {
                QuestionForCompliance buf = (QuestionForCompliance)Datass.QQ[Datass.polz];
                this.panelQw.Controls.AddRange(buf.masEl);
                SpisokBoxTip.SelectedIndex = 2;
            }
            else if (Datass.QQ[Datass.polz] is FreeAnswer)
            {
                FreeAnswer buf = (FreeAnswer)Datass.QQ[Datass.polz];
                this.panelQw.Controls.AddRange(buf.masEl);
                SpisokBoxTip.SelectedIndex = 3;
            }
        }
        private void BtFocus(int en)
        {
            panelBt.Controls.Remove((Datass.spisokBt[Datass.polz]));
            Datass.spisokBt[Datass.polz].BackColor = System.Drawing.Color.Gainsboro;
            this.panelBt.Controls.Add(Datass.spisokBt[Datass.polz]);

            panelBt.Controls.Remove(Datass.spisokBt[en]);
            Datass.spisokBt[en].BackColor = System.Drawing.Color.IndianRed;
            this.panelBt.Controls.Add(Datass.spisokBt[en]);
        }


        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //About_program About = new About_program();
            //About.ShowDialog();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Datass.Namefile == null)
            {
                if (Datass.QQ.LongCount()>2)
                {
                    if (DialogResult.Yes == MessageBox.Show("Сохранить тест перед открітием?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        сохранитьToolStripMenuItem_Click(new object(), new EventArgs());
                }
                if (FUNCS.Open(openFileDialog1))
                {
                    this.Text = Path.GetFileNameWithoutExtension(saveFileDialog1.FileName) + " - EditorTtest";
                    WriteForm(new object(), new EventArgs());
                }
                else  MessageBox.Show("Не удалось откріть файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                              
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Файл уже открыт!Сохранить его и открыть новый?", "Предупреждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
                {
                    FUNCS.save_proget();
                    Datass.Namefile.Close();
                    Datass.Namefile.Dispose();
                    открытьToolStripMenuItem_Click(new object(), new EventArgs());
                }
            }

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Datass.Namefile == null)
            {
                if (FUNCS.Сreate(saveFileDialog1))
                {
                    this.Text = Path.GetFileNameWithoutExtension(saveFileDialog1.FileName) + " - EditorTtest";
                    
                    //FUNCS.Save();
                }
                else
                {
                    MessageBox.Show("Не удалось создать файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("файл уже открыт", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
                

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Datass.Namefile == null)
            {
                if (FUNCS.Сreate(saveFileDialog1))
                {
                    this.Text = Path.GetFileNameWithoutExtension(saveFileDialog1.FileName) + " - EditorTtest";
                   
                }
                else
                {
                    MessageBox.Show("Не удалось создать файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return ;
                }
            }
            SaveFormInf(new object(), new EventArgs());
           FUNCS.save_proget();
            
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //About_program About = new About_program();
            //About.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void NextQw_Click(object sender, EventArgs e)
        {
            if (Datass.polz+1== Datass.kol)
            {
                button2_Click_1(true, new EventArgs());
            }
            else
            {
                Button buf = new Button();
                buf.Name = (Datass.polz+1).ToString();

                button1_Click_12(buf, new EventArgs());
            }

        }

        private void BackQw_Click(object sender, EventArgs e)
        {
            if (Datass.polz!=0)
            {
                Button buf = new Button();
                buf.Name = (Datass.polz -1).ToString();

                button1_Click_12(buf, new EventArgs());
            }
            

        }




        private void SpisokBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    if (!(Datass.QQ[Datass.polz] is OnePossibleAnswers))
                    {
                        Datass.QQ[Datass.polz]= (new OnePossibleAnswers());
                    }                   
                    break;
                case 1:
                    if (!(Datass.QQ[Datass.polz] is SeveralPossibleAnswers))
                    {
                        Datass.QQ[Datass.polz] = (new SeveralPossibleAnswers());
                    }
                    break;
                case 2:
                    if (!(Datass.QQ[Datass.polz] is QuestionForCompliance))
                    {
                        Datass.QQ[Datass.polz] = (new QuestionForCompliance());
                    }
                    break;
                case 3:
                    if (!(Datass.QQ[Datass.polz] is FreeAnswer))
                    {
                        Datass.QQ[Datass.polz] = (new FreeAnswer());
                    }
                    break;

            }
            // MessageBox.Show("fdsj", "gsdfgs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            AddControl();

        }
        

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (sender is bool)
            {
                FUNCS.AddQw((bool)sender);
            }
            else
            {
                FUNCS.AddQw(true);
            }
            Datass.spisokBt[Datass.kol].Click+= button1_Click_12;

           
            this.panelBt.Controls.Add(Datass.spisokBt[Datass.kol]);
            BtFocus(Datass.kol);
            Datass.polz = Datass.kol;
            AddControl();

            Datass.kol++;      

            this.delete.Location = new Point(delete.Location.X, delete.Location.Y + 33);             
            this.BtAddVopr.Location = new Point(BtAddVopr.Location.X, BtAddVopr.Location.Y + 33);
        }

        private void button1_Click_12(object sender, EventArgs e)
        {
            Button buf = (Button)sender;
            BtFocus(Convert.ToInt32(buf.Name));
            Datass.polz = Convert.ToInt32(buf.Name);
            AddControl();
             
             
        }

       

        private void delete_Click(object sender, EventArgs e)
        {
            if (Datass.kol > 1)
            {
                Datass.kol--;
                BtFocus(Datass.kol-1);
                panelBt.Controls.Remove(Datass.spisokBt[Datass.kol]);

                Datass.spisokBt.RemoveAt(Datass.kol);
                Datass.QQ.RemoveAt(Datass.kol);

                this.delete.Location = new Point(delete.Location.X, delete.Location.Y - 33);
                this.BtAddVopr.Location = new Point(BtAddVopr.Location.X, BtAddVopr.Location.Y - 33);

               
                Datass.polz = Datass.kol-1;
                AddControl();
            }

        }

       

        private void SaveFormInf(object sender, EventArgs e)
        {
            Datass.NameTest = NameTest.Text;
            Datass.OpisTest= OpisTest.Text;
            Datass. AutorTest= AutorTest.Text;
            Datass.set_RandV = !radioBtRand1.Checked;
            Datass.set_rand = (int)nUpDownSize.Value;
            
            Datass.set_PorV = !radioBtPorV1.Checked;
            
            Datass.set_PorO = !radioBtPorO1.Checked;
             
            Datass.set_TimeS = (int)nUpDownTime.Value;
            Datass.set_Time = radioBtTime1.Checked;
             
            Datass.set_TimeZader = (int)nUpDownZad.Value;
            Datass.set_checkZader = checkZader.Checked;
            
            Datass.set_checkOtchet = checkOtchet.Checked;
        }

        private void radioBtRand2_CheckedChanged(object sender, EventArgs e)
        {               
            nUpDownSize.Enabled = true;
            label2.Enabled = true;                      
        }

        private void radioBtRand1_CheckedChanged(object sender, EventArgs e)
        {
            nUpDownSize.Enabled = false;
            label2.Enabled = false;
        }

        private void radioBtTime1_CheckedChanged(object sender, EventArgs e)
        {
            nUpDownTime.Enabled = false;
            label9.Enabled = false;
        }

        private void radioBtTime2_CheckedChanged(object sender, EventArgs e)
        {
            nUpDownTime.Enabled = true;
            label9.Enabled = true;
        }

        private void checkZader_CheckedChanged(object sender, EventArgs e)
        {
           if(checkZader.Checked)
            {
                nUpDownZad.Enabled = true;
                label10.Enabled = true;
                button2.Enabled = true;

            }
            else
            {
                nUpDownZad.Enabled = false;
                label10.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void WriteForm(object sender, EventArgs e)
        {
             
            for (int i = 0; i < Datass.kol; i++)
            {
                panelBt.Controls.Remove((Datass.spisokBt[i]));
            }
            panelQw.Controls.Clear();
            Datass.spisokBt.Clear();
            Datass.QQ.Clear();
            Datass.kol = 0;
            Datass.polz = 0;
            this.delete.Location = new Point(175, 3);
            this.BtAddVopr.Location = new Point(3, 3);
            if (FUNCS.read_proget())
            {

                NameTest.Text = Datass.NameTest;
                OpisTest.Text = Datass.OpisTest;
                AutorTest.Text = Datass.AutorTest;


                int buf = Datass.kol;
                Datass.kol = 0;
                for (int i = 0; i < buf; i++)
                {
                    button2_Click_1(false, new EventArgs());
                }
                radioBtRand1.Checked = !Datass.set_RandV;
                radioBtRand2.Checked = Datass.set_RandV;
                nUpDownSize.Value = Datass.set_rand;


                radioBtPorV1.Checked = Datass.set_PorV;
                radioBtPorV2.Checked = !Datass.set_PorV;

                radioBtPorO1.Checked = Datass.set_PorO;
                radioBtPorO2.Checked = !Datass.set_PorO;

                nUpDownTime.Value = Datass.set_TimeS;
                radioBtTime1.Checked = !Datass.set_Time;
                radioBtTime2.Checked = Datass.set_Time;

                nUpDownZad.Value = Datass.set_TimeZader;
                checkZader.Checked = !Datass.set_checkZader;

                checkOtchet.Checked = !Datass.set_checkOtchet;
            }
            else
            {
                MessageBox.Show("Неверный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Сохранить файл перед закрытием?", "Предупреждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (DialogResult.Yes == result)
            {
                сохранитьToolStripMenuItem_Click(new object(), new EventArgs());
                 
            }
            else if (DialogResult.No == result)
            {

            }
            else
            {
 e.Cancel = true;
            }
           
        }

        //private void toolStripButton2_Click(object sender, EventArgs e)
        //{
        //    SendKeys.Send("^{X}");
        //}

        //private void toolStripButton3_Click(object sender, EventArgs e)
        //{
        //    SendKeys.Send("{ASC 065}");

        //}

        //private void toolStripButton4_Click(object sender, EventArgs e)
        //{
        //    SendKeys.Send("^{V}");
        //}

     
    }
}


