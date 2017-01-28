using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Drawing;
namespace EditorTest
{
   
    
    class SeveralPossibleAnswers
    {

        public string Format;
        private string question;
        private string answer0;
        private string answer1;
        private string answer2;
        private string answer3;
        private bool num1, num2, num3, num4;

        public Control[] masEl = new Control[12];

        private System.Windows.Forms.CheckBox CheckButton1;
        private System.Windows.Forms.CheckBox CheckButton2;
        private System.Windows.Forms.CheckBox CheckButton3;
        private System.Windows.Forms.CheckBox CheckButton4;
        private System.Windows.Forms.TextBox TBVopros;
        private System.Windows.Forms.TextBox TBOtvet1;
        private System.Windows.Forms.TextBox TBOtvet2;
        private System.Windows.Forms.TextBox TBOtvet3;
        private System.Windows.Forms.TextBox TBOtvet4;
        private System.Windows.Forms.Label labelOtvet;
        private System.Windows.Forms.Label labelVopros;
        public SeveralPossibleAnswers()
        {
            this.TBVopros = new System.Windows.Forms.TextBox();
            this.TBOtvet1 = new System.Windows.Forms.TextBox();
            this.TBOtvet2 = new System.Windows.Forms.TextBox();
            this.TBOtvet3 = new System.Windows.Forms.TextBox();
            this.TBOtvet4 = new System.Windows.Forms.TextBox();
            this.labelOtvet = new System.Windows.Forms.Label();
            this.labelVopros = new System.Windows.Forms.Label();
            this.CheckButton1 = new System.Windows.Forms.CheckBox();
            this.CheckButton2 = new System.Windows.Forms.CheckBox();
            this.CheckButton3 = new System.Windows.Forms.CheckBox();
            this.CheckButton4 = new System.Windows.Forms.CheckBox();
            // 
            // TBOtvet1
            // 
            this.TBOtvet1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBOtvet1.Location = new System.Drawing.Point(89, 143);
            this.TBOtvet1.Multiline = true;
            this.TBOtvet1.Name = "TBOtvet1";
            this.TBOtvet1.Size = new System.Drawing.Size(451, 50);
            this.TBOtvet1.TabIndex = 4;
            // 
            // TBOtvet2
            // 
            this.TBOtvet2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBOtvet2.Location = new System.Drawing.Point(89, 209);
            this.TBOtvet2.Multiline = true;
            this.TBOtvet2.Name = "TBOtvet2";
            this.TBOtvet2.Size = new System.Drawing.Size(451, 50);
            this.TBOtvet2.TabIndex = 4;
            // 
            // TBOtvet3
            // 
            this.TBOtvet3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBOtvet3.Location = new System.Drawing.Point(89, 276);
            this.TBOtvet3.Multiline = true;
            this.TBOtvet3.Name = "TBOtvet3";
            this.TBOtvet3.Size = new System.Drawing.Size(451, 50);
            this.TBOtvet3.TabIndex = 4;
            // 
            // TBOtvet4
            // 
            this.TBOtvet4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBOtvet4.Location = new System.Drawing.Point(89, 336);
            this.TBOtvet4.Multiline = true;
            this.TBOtvet4.Name = "TBOtvet4";
            this.TBOtvet4.Size = new System.Drawing.Size(451, 50);
            this.TBOtvet4.TabIndex = 4;
            // 
            // labelOtvet
            // 
            this.labelOtvet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOtvet.AutoSize = true;
            this.labelOtvet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOtvet.Location = new System.Drawing.Point(268, 114);
            this.labelOtvet.Name = "labelOtvet";
            this.labelOtvet.Size = new System.Drawing.Size(80, 24);
            this.labelOtvet.TabIndex = 6;
            this.labelOtvet.Text = "Ответы";
            // 
            // CheckButton1
            // 
            this.CheckButton1.AutoSize = true;
            this.CheckButton1.Location = new System.Drawing.Point(25, 161);
            this.CheckButton1.Name = "CheckButton1";
            this.CheckButton1.Size = new System.Drawing.Size(42, 17);
            this.CheckButton1.TabIndex = 8;
            this.CheckButton1.TabStop = true;
            this.CheckButton1.Text = "№1";
            this.CheckButton1.UseVisualStyleBackColor = true;
            // 
            // CheckButton2
            // 
            this.CheckButton2.AutoSize = true;
            this.CheckButton2.Location = new System.Drawing.Point(25, 230);
            this.CheckButton2.Name = "CheckButton2";
            this.CheckButton2.Size = new System.Drawing.Size(42, 17);
            this.CheckButton2.TabIndex = 8;
            this.CheckButton2.TabStop = true;
            this.CheckButton2.Text = "№2";
            this.CheckButton2.UseVisualStyleBackColor = true;
            // 
            // CheckButton3
            // 
            this.CheckButton3.AutoSize = true;
            this.CheckButton3.Location = new System.Drawing.Point(25, 295);
            this.CheckButton3.Name = "CheckButton3";
            this.CheckButton3.Size = new System.Drawing.Size(42, 17);
            this.CheckButton3.TabIndex = 8;
            this.CheckButton3.TabStop = true;
            this.CheckButton3.Text = "№3";
            this.CheckButton3.UseVisualStyleBackColor = true;
            // 
            // CheckButton4
            // 
            this.CheckButton4.AutoSize = true;
            this.CheckButton4.Location = new System.Drawing.Point(25, 359);
            this.CheckButton4.Name = "CheckButton4";
            this.CheckButton4.Size = new System.Drawing.Size(42, 17);
            this.CheckButton4.TabIndex = 8;
            this.CheckButton4.TabStop = true;
            this.CheckButton4.Text = "№4";
            this.CheckButton4.UseVisualStyleBackColor = true;
            // 
            // TBVopros
            // 
            this.TBVopros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVopros.AutoSize = true;
            this.TBVopros.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBVopros.Location = new System.Drawing.Point(89, 40);
            this.TBVopros.Multiline = true;
            this.TBVopros.Name = "TBVopros";
            this.TBVopros.Size = new System.Drawing.Size(451, 66);
            this.TBVopros.TabIndex = 4;
            this.TBVopros.Text = " ";
            // 
            // labelVopros
            // 
            this.labelVopros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVopros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVopros.Location = new System.Drawing.Point(265, 13);
            this.labelVopros.Name = "labelVopros";
            this.labelVopros.Size = new System.Drawing.Size(80, 24);
            this.labelVopros.TabIndex = 6;
            this.labelVopros.Text = "Вопрос";

            masEl[0] = (labelVopros);
            masEl[1] = (labelOtvet);
            masEl[2] = (TBOtvet3);
            masEl[3] = (TBOtvet2);
            masEl[4] = (CheckButton2);
            masEl[5] = (CheckButton1);
            masEl[6] = (TBOtvet4);
            masEl[7] = (TBOtvet1);
            masEl[8] = (CheckButton3);
            masEl[9] = (CheckButton4);
            masEl[10] = (TBVopros);
        }

        public void WriteingQW(string[] b)
        {
            this.TBVopros.Text = b[1].Replace(  "|| n", "\n"); 
            this.TBOtvet1.Text = b[2].Replace( "|| n", "\n");
            this.TBOtvet2.Text = b[3].Replace( "|| n", "\n");
            this.TBOtvet3.Text = b[4].Replace( "|| n", "\n");
            this.TBOtvet4.Text = b[5].Replace( "|| n", "\n");
            
            CheckButton1.Checked = Convert.ToBoolean(b[6]);
            CheckButton2.Checked=Convert.ToBoolean(b[7]);
            CheckButton3.Checked=Convert.ToBoolean(b[8]);
            CheckButton4.Checked=Convert.ToBoolean(b[9]);



        }
        public void ReadingQW()
        {
             
               num1 = CheckButton1.Checked   ;
            num2=CheckButton2.Checked ;
            num3= CheckButton3.Checked ;
            num4=CheckButton4.Checked;
            question =  TBVopros.Text.Replace("\n", "|| n");
            answer0 = TBOtvet1.Text.Replace("\n", "|| n"); 
            answer1 = TBOtvet2.Text.Replace("\n", "|| n");
            answer2 = TBOtvet3.Text.Replace("\n", "|| n");  
            answer3 = TBOtvet4.Text.Replace("\n", "|| n"); 

             
            Format = String.Format("{0} ;;{1} ;;{2} ;;{3} ;;{4} ;;{5} ;;{6} ;;{7} ;;{8} ;;end", question, answer0, answer1,
               answer2,  answer3, num1, num2, num3, num4);

        }

    }

    class QuestionForCompliance
    {
        private string question;
        private string answer1;
        private string answer2;
        private string answer3;
        private string answer4;
        private string answer10;
        private string answer20;
        private string answer30;
        private string answer40;

        public string Format;

        private System.Windows.Forms.TextBox TBVopros;
        private System.Windows.Forms.Label labelOtvet;
        private System.Windows.Forms.Label labelVopros;
        private System.Windows.Forms.TextBox TBOtvet3;
        private System.Windows.Forms.TextBox TBOtvet2;
        private System.Windows.Forms.TextBox TBOtvet4;       
        private System.Windows.Forms.TextBox TBOtvet1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        public Control[] masEl = new Control[20];
        public QuestionForCompliance()
        {
            this.labelVopros = new System.Windows.Forms.Label();
            this.labelOtvet = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TBOtvet3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TBOtvet2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.TBOtvet4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TBOtvet1 = new System.Windows.Forms.TextBox();
            this.TBVopros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(298, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 2);
            this.label1.TabIndex = 7;
            this.label1.Text = "            ";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(298, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 2);
            this.label2.TabIndex = 7;
            this.label2.Text = "            ";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(298, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 2);
            this.label3.TabIndex = 7;
            this.label3.Text = "            ";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(298, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 2);
            this.label4.TabIndex = 7;
            this.label4.Text = "            ";
            // 
            // labelVopros
            // 
            this.labelVopros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVopros.AutoSize = true;
            this.labelVopros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVopros.Location = new System.Drawing.Point(265, 13);
            this.labelVopros.Name = "labelVopros";
            this.labelVopros.Size = new System.Drawing.Size(80, 24);
            this.labelVopros.TabIndex = 6;
            this.labelVopros.Text = "Вопрос";
            // 
            // labelOtvet
            // 
            this.labelOtvet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOtvet.AutoSize = true;
            this.labelOtvet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOtvet.Location = new System.Drawing.Point(268, 114);
            this.labelOtvet.Name = "labelOtvet";
            this.labelOtvet.Size = new System.Drawing.Size(80, 24);
            this.labelOtvet.TabIndex = 6;
            this.labelOtvet.Text = "Ответы";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(330, 276);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 50);
            this.textBox3.TabIndex = 4;
            // 
            // TBOtvet3
            // 
            this.TBOtvet3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBOtvet3.Location = new System.Drawing.Point(89, 276);
            this.TBOtvet3.Multiline = true;
            this.TBOtvet3.Name = "TBOtvet3";
            this.TBOtvet3.Size = new System.Drawing.Size(210, 50);
            this.TBOtvet3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(330, 209);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 50);
            this.textBox2.TabIndex = 4;
            // 
            // TBOtvet2
            // 
            this.TBOtvet2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBOtvet2.Location = new System.Drawing.Point(89, 209);
            this.TBOtvet2.Multiline = true;
            this.TBOtvet2.Name = "TBOtvet2";
            this.TBOtvet2.Size = new System.Drawing.Size(210, 50);
            this.TBOtvet2.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(330, 336);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(210, 50);
            this.textBox4.TabIndex = 4;
            // 
            // TBOtvet4
            // 
            this.TBOtvet4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBOtvet4.Location = new System.Drawing.Point(89, 336);
            this.TBOtvet4.Multiline = true;
            this.TBOtvet4.Name = "TBOtvet4";
            this.TBOtvet4.Size = new System.Drawing.Size(210, 50);
            this.TBOtvet4.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(330, 143);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 50);
            this.textBox1.TabIndex = 4;
            // 
            // TBOtvet1
            // 
            this.TBOtvet1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBOtvet1.Location = new System.Drawing.Point(89, 143);
            this.TBOtvet1.Multiline = true;
            this.TBOtvet1.Name = "TBOtvet1";
            this.TBOtvet1.Size = new System.Drawing.Size(210, 50);
            this.TBOtvet1.TabIndex = 4;
            // 
            // TBVopros
            // 
            this.TBVopros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBVopros.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBVopros.Location = new System.Drawing.Point(89, 40);
            this.TBVopros.Multiline = true;
            this.TBVopros.Name = "TBVopros";
            this.TBVopros.Size = new System.Drawing.Size(451, 66);
            this.TBVopros.TabIndex = 4;
            this.TBVopros.Text = " ";


            masEl[0] = (labelVopros);
            masEl[1] = (labelOtvet);
            masEl[2] = (TBOtvet3);
            masEl[3] = (TBOtvet2);
            masEl[4] = (label4);
            masEl[5] = (label3);
            masEl[6] = (TBOtvet4);
            masEl[7] = (TBOtvet1);
            masEl[8] = (label1);
            masEl[9] = (label2);
            masEl[10] = (TBVopros);
            masEl[11] = (textBox1);
            masEl[12] = (textBox2);
            masEl[13] = (textBox3);
            masEl[14] = (textBox4);

        }
        public void WriteingQW(string[] b)
        {
            this.TBVopros.Text = b[1].Replace(  "|| n", "\n");
            this.TBOtvet1.Text = b[2].Replace( "|| n", "\n");
            this.TBOtvet2.Text = b[3].Replace( "|| n", "\n");
            this.TBOtvet3.Text = b[4].Replace( "|| n", "\n");
            this.TBOtvet4.Text = b[5].Replace( "|| n", "\n");

            this.textBox1.Text = b[6].Replace( "|| n", "\n");
             this.textBox2.Text = b[7].Replace( "|| n", "\n");
             this.textBox3.Text = b[8].Replace( "|| n", "\n");
             this.textBox4.Text = b[9].Replace( "|| n", "\n");
        }

        public void ReadingQW()
        {
             
            question = this.TBVopros.Text.Replace("\n", "|| n");
            answer1 = this.TBOtvet1.Text.Replace("\n", "|| n");
            answer2 = this.TBOtvet2.Text.Replace("\n", "|| n");
            answer3 = this.TBOtvet3.Text.Replace("\n", "|| n");
            answer4 = this.TBOtvet4.Text.Replace("\n", "|| n");

            answer10 = this.textBox1.Text.Replace("\n", "|| n");
            answer20 = this.textBox2.Text.Replace("\n", "|| n");
            answer30 = this.textBox3.Text.Replace("\n", "|| n");
            answer40 = this.textBox4.Text.Replace("\n", "|| n");
            
            Format = String.Format("{0} ;;{1} ;;{2} ;;{3} ;;{4} ;;{5} ;;{6} ;;{7} ;;{8} ;;end", question,  answer1,
                answer2,  answer3, answer4,  answer10,  answer20,  answer30,  answer40);
                }
        // TODO: функция создает строку нужного формата и шифа и т д   ВЕЗДЕ
        // TODO: также создать форму интерфейс для проги тестирования для каждого вопроса
    }

    class FreeAnswer
    {
        public string Format;
        public Control[] masEl = new Control[4];
        private string question;
        private string answer1;
        private System.Windows.Forms.TextBox TBVopros;
        private System.Windows.Forms.TextBox TBOtvet1;       
        private System.Windows.Forms.Label labelOtvet;
        private System.Windows.Forms.Label labelVopros;

        public FreeAnswer()
        {
            this.TBVopros = new System.Windows.Forms.TextBox();
            this.TBOtvet1 = new System.Windows.Forms.TextBox();            
            this.labelOtvet = new System.Windows.Forms.Label();
            this.labelVopros = new System.Windows.Forms.Label();
            // 
            // TBOtvet1
            // 
            this.TBOtvet1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBOtvet1.Location = new System.Drawing.Point(89, 143);
            this.TBOtvet1.Multiline = true;
            this.TBOtvet1.Name = "TBOtvet1";
            this.TBOtvet1.Size = new System.Drawing.Size(451, 50);
            this.TBOtvet1.TabIndex = 4;
            // 
            // labelOtvet
            // 
            this.labelOtvet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOtvet.AutoSize = true;
            this.labelOtvet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOtvet.Location = new System.Drawing.Point(268, 114);
            this.labelOtvet.Name = "labelOtvet";
            this.labelOtvet.Size = new System.Drawing.Size(80, 24);
            this.labelOtvet.TabIndex = 6;
            this.labelOtvet.Text = "Ответы";
            // 
            // TBVopros
            // 
            this.TBVopros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBVopros.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBVopros.Location = new System.Drawing.Point(89, 40);
            this.TBVopros.Multiline = true;
            this.TBVopros.Name = "TBVopros";
            this.TBVopros.Size = new System.Drawing.Size(451, 66);
            this.TBVopros.TabIndex = 4;
            this.TBVopros.Text = " ";
            // 
            // labelVopros
            // 
            this.labelVopros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVopros.AutoSize = true;
            this.labelVopros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVopros.Location = new System.Drawing.Point(265, 13);
            this.labelVopros.Name = "labelVopros";
            this.labelVopros.Size = new System.Drawing.Size(80, 24);
            this.labelVopros.TabIndex = 6;
            this.labelVopros.Text = "Вопрос";

            masEl[0] = (labelVopros);
            masEl[1] = (labelOtvet);           
            masEl[2] = (TBOtvet1);           
            masEl[3] = (TBVopros);


        }
        public void WriteingQW(string[] b)
        {
            this.TBVopros.Text = b[1].Replace( "|| n", "\n");
            this.TBOtvet1.Text = b[2].Replace( "|| n", "\n");
        }
        public void ReadingQW()
        { 
            question = this.TBVopros.Text.Replace("\n", "|| n");
            answer1 = this.TBOtvet1.Text.Replace("\n", "|| n");
            
            Format = String.Format("{0} ;;{1} ;; end  ",  question,  answer1 );
        }

    }
    class OnePossibleAnswers
    {

        public string Format;
        private string question;
        private string answer3;
        private string answer1;
        private string answer2;
        private string answer4;
        private int num;

        public  Control[] masEl=new Control[12];  

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox TBVopros;
        private System.Windows.Forms.TextBox TBOtvet1;
        private System.Windows.Forms.TextBox TBOtvet2;
        private System.Windows.Forms.TextBox TBOtvet3;
        private System.Windows.Forms.TextBox TBOtvet4;
        private System.Windows.Forms.Label labelOtvet;
        private System.Windows.Forms.Label labelVopros;
        public OnePossibleAnswers()
        {
            this.TBVopros = new System.Windows.Forms.TextBox();
            this.TBOtvet1 = new System.Windows.Forms.TextBox();
            this.TBOtvet2 = new System.Windows.Forms.TextBox();
            this.TBOtvet3 = new System.Windows.Forms.TextBox();
            this.TBOtvet4 = new System.Windows.Forms.TextBox();
            this.labelOtvet = new System.Windows.Forms.Label();
            this.labelVopros = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            // 
            // TBOtvet1
            // 
            this.TBOtvet1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBOtvet1.Location = new System.Drawing.Point(89, 143);
            this.TBOtvet1.Multiline = true;
            this.TBOtvet1.Name = "TBOtvet1";
            this.TBOtvet1.Size = new System.Drawing.Size(451, 50);
            this.TBOtvet1.TabIndex = 4;
            // 
            // TBOtvet2
            // 
            this.TBOtvet2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBOtvet2.Location = new System.Drawing.Point(89, 209);
            this.TBOtvet2.Multiline = true;
            this.TBOtvet2.Name = "TBOtvet2";
            this.TBOtvet2.Size = new System.Drawing.Size(451, 50);
            this.TBOtvet2.TabIndex = 4;
            // 
            // TBOtvet3
            // 
            this.TBOtvet3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBOtvet3.Location = new System.Drawing.Point(89, 276);
            this.TBOtvet3.Multiline = true;
            this.TBOtvet3.Name = "TBOtvet3";
            this.TBOtvet3.Size = new System.Drawing.Size(451, 50);
            this.TBOtvet3.TabIndex = 4;
            // 
            // TBOtvet4
            // 
            this.TBOtvet4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBOtvet4.Location = new System.Drawing.Point(89, 336);
            this.TBOtvet4.Multiline = true;
            this.TBOtvet4.Name = "TBOtvet4";
            this.TBOtvet4.Size = new System.Drawing.Size(451, 50);
            this.TBOtvet4.TabIndex = 4;            
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(25, 161);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(42, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "№1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Checked = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(25, 230);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(42, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "№2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(25, 295);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(42, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "№3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(25, 359);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(42, 17);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "№4";
            this.radioButton4.UseVisualStyleBackColor = true;           
            // 
            // TBVopros
            // 
            this.TBVopros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBVopros.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBVopros.Location = new System.Drawing.Point(89, 40);
            this.TBVopros.Multiline = true;
            this.TBVopros.Name = "TBVopros";
            this.TBVopros.Size = new System.Drawing.Size(451, 66);
            this.TBVopros.TabIndex = 4;
            this.TBVopros.Text = " ";
            // 
            // labelOtvet
            // 
            this.labelOtvet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOtvet.AutoSize = true;
            this.labelOtvet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOtvet.Location = new System.Drawing.Point(268, 114);
            this.labelOtvet.Name = "labelOtvet";
            this.labelOtvet.Size = new System.Drawing.Size(80, 24);
            this.labelOtvet.TabIndex = 6;
            this.labelOtvet.Text = "Ответы";
            // 
            // labelVopros
            // 
            this.labelVopros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVopros.AutoSize = true;
            this.labelVopros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVopros.Location = new System.Drawing.Point(265, 13);
            this.labelVopros.Name = "labelVopros";
            this.labelVopros.Size = new System.Drawing.Size(80, 24);
            this.labelVopros.TabIndex = 6;
            this.labelVopros.Text = "Вопрос";

            masEl[0]=(labelVopros);
           masEl[1]=(labelOtvet);
           masEl[2]=(TBOtvet3);
           masEl[3]=(TBOtvet2);
           masEl[4]=(radioButton2);
           masEl[5]=(radioButton1);
           masEl[6]=(TBOtvet4);
           masEl[7]=(TBOtvet1);
           masEl[8]=(radioButton3);
           masEl[9]=(radioButton4);
           masEl[10]=(TBVopros);
        }

        public void WriteingQW(string[]b)
        {
             this.TBVopros.Text=b[1].Replace("|| n", "\n");
             this.TBOtvet1.Text=b[2].Replace("|| n", "\n");
            this.TBOtvet2.Text=b[3].Replace("|| n", "\n");
             this.TBOtvet3.Text=b[4].Replace("|| n", "\n");
             this.TBOtvet4.Text=b[5].Replace("|| n", "\n");
            num = Convert.ToInt32(b[6]);

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            if (num ==1) radioButton1.Checked = true;
            else if (num == 2) radioButton2.Checked = true;
            else if (num == 3) radioButton3.Checked=true;
            else radioButton4.Checked=true;



        }
        public void ReadingQW()
        {            
            if (radioButton1.Checked) num = 1;
            else if (radioButton2.Checked) num = 2;
            else if (radioButton3.Checked) num = 3;
            else num = 4;
            question = this.TBVopros.Text.Replace( "\n", "|| n");
            answer1 = this.TBOtvet1.Text.Replace("\n", "|| n");
            answer2 = this.TBOtvet2.Text.Replace("\n", "|| n");
            answer3 = this.TBOtvet3.Text.Replace("\n", "|| n");
            answer4 = this.TBOtvet4.Text.Replace("\n", "|| n");
            
            Format = String.Format("{0} ;;{1} ;;{2} ;;{3} ;;{4} ;;{5} ;;end", question, answer1,
               answer2,answer3, answer4, num);
        }

    }
    class Datass
    {

        static public string NameTest;
        static public string OpisTest;
        static public string AutorTest;
        static public bool set_RandV = false;
        static public int set_rand = 0;
        static public bool set_PorV = true;
        static public bool set_PorO = true;
        static public bool set_Time = false;
        static public int set_TimeS = 0;
        static public bool set_checkOtchet = true;
        static public bool set_checkZader = false;
        static public int set_TimeZader = 0;

        static public StreamWriter Writerfile;
        static public StreamReader Readerfile;
        static public System.IO.FileStream Namefile;
        static public List<object> QQ = new List<object>();
        static public int kol = 0;
        static public int polz = 0;

        static public List<Button> spisokBt = new List<Button>();
    }
    class FUNCS
    {
        static public bool Open(OpenFileDialog FileDialog1)
        {
            if (FileDialog1.ShowDialog() == DialogResult.OK)
            {
                Datass.Namefile = new System.IO.FileStream(FileDialog1.FileName, FileMode.Open, FileAccess.ReadWrite);
                
                if (Datass.Namefile == null)
                {
                    return false;
                }
                else
                {
                    Datass.Readerfile = new StreamReader(Datass.Namefile);
                    return true;
                }
            }
            return false;
        }
        static public bool Сreate(SaveFileDialog FileDialog1)
        {
            if (FileDialog1.ShowDialog() == DialogResult.OK)
            {
               Datass.Namefile = new System.IO.FileStream(FileDialog1.FileName, FileMode.Create, FileAccess.ReadWrite);
                if (Datass.Namefile == null)
                {
                    return false;
                }
                else
                {                   
                    return true;
                }
               
            }

            return false;

        }

        static public void AddQw( bool t)
        {
            if ((Datass.QQ.LongCount() == Datass.kol)&&t)
            {
                Datass.QQ.Add(new OnePossibleAnswers());
            }
            else if(t)
            {
                Datass.QQ[Datass.kol] = new OnePossibleAnswers();
            }


           Button newbut = new Button();
            newbut.Location =new Point(3,4+ (Datass.kol)*33);
            newbut.Name =   Datass.kol.ToString();
            newbut.Size = new System.Drawing.Size(207, 30);
            newbut.TabIndex = 15 + Datass.kol;
            newbut.Text = "Вопрос №" + (Datass.kol + 1);
            newbut.UseVisualStyleBackColor = true;
            newbut.BackColor = System.Drawing.Color.Gainsboro;


            if (Datass.spisokBt.LongCount()== Datass.kol)
            {
                Datass.spisokBt.Add(newbut);
            }
            else 
            {
                Datass.spisokBt[Datass.kol] = newbut; 
            }
                      
        }

        static public void SET(string[] b)
        {
            Datass.set_RandV = (b[1]== "True");
            Datass.set_rand = Convert.ToInt32(b[2]);

            Datass.set_PorV = (b[3] == "True");

            Datass.set_PorO = (b[4] == "True");
           
            Datass.set_Time = (b[5] == "True");
            Datass.set_TimeS = Convert.ToInt32(b[6]);
            
            Datass.set_checkZader = (b[7] == "True");

            Datass.set_checkOtchet = (b[8] == "True");
            Datass.set_TimeZader = Convert.ToInt32(b[9]);


        }
        static public bool read_proget()
        {
            Datass.Readerfile = new StreamReader(Datass.Namefile);
            string buf;
            Datass.kol = 0;
            Datass.polz = 0;

            string[] b1;
            string[] b;
            string[] d=new string[1];
            string[] d1= new string[1];
            d[0] = " ;;";
            d1[0] = "end\r\n";
            if ((buf = Datass.Readerfile.ReadLine()) != null)
            {
                b = buf.Split(d, StringSplitOptions.RemoveEmptyEntries);
            }
            else return false;
            if (String.Compare(b[0], "SET") == 0) {
                SET(b);
                buf = Datass.Readerfile.ReadToEnd();
                b1 = buf.Split(d1, StringSplitOptions.RemoveEmptyEntries);
                foreach (string ss in b1)
                
                {
                    b = ss.Split( d, StringSplitOptions.RemoveEmptyEntries);
                
                 
                  if (String.Compare(b[0], "AOT") == 0)
                    {
                        Datass.NameTest = b[1];
                        Datass.OpisTest = b[2];
                        Datass.AutorTest = b[3];
                    }
                    else if (String.Compare(b[0], "OPA") == 0)
                    {
                        OnePossibleAnswers bufq = new OnePossibleAnswers();
                        bufq.WriteingQW(b);
                        Datass.QQ.Add(bufq);
                        Datass.kol++;

                    }
                    else if (String.Compare(b[0], "SPA") == 0)
                    {
                        SeveralPossibleAnswers bufq = new SeveralPossibleAnswers();
                        bufq.WriteingQW(b);
                        Datass.QQ.Add(bufq);
                        Datass.kol++;
                    }
                    else if (String.Compare(b[0], "FA") == 0)
                    {
                        FreeAnswer bufq = new FreeAnswer();
                        bufq.WriteingQW(b);
                        Datass.QQ.Add(bufq);
                        Datass.kol++;
                    }
                    else if (String.Compare(b[0], "QFS") == 0)
                    {
                        QuestionForCompliance bufq = new QuestionForCompliance();
                        bufq.WriteingQW(b);
                        Datass.QQ.Add(bufq);
                        Datass.kol++;
                    }
                }
            }
            else return false;
            return true;
        }
        static public void save_proget(    )
        {

            string buf = Datass.Namefile.Name;
            Datass.Namefile.Close();
            Datass.Namefile = new FileStream(buf, FileMode.Create, FileAccess.Write);
            string n = " ";

            Datass.Writerfile = new StreamWriter(Datass.Namefile );
            string set =  String.Format("{0} ;;{1} ;;{2} ;;{3} ;;{4} ;;{5} ;;{6} ;;{7} ;;{8} ;;end", Datass.set_RandV, Datass.set_rand,
             Datass.set_PorV, Datass.set_PorO, Datass.set_Time, Datass.set_TimeS, Datass.set_checkOtchet, Datass.set_checkZader, Datass.set_TimeZader);
            Datass.Writerfile.WriteLine("SET ;;{0}", set);
              set = String.Format("AOT ;;{0} ;;{1} ;;{2} ;;end",n+ Datass.NameTest,n+ Datass.OpisTest,n+ Datass.AutorTest);
            Datass.Writerfile.WriteLine(  set);

            for (int i = 0; i < Datass.kol; i++)
            {                
                    if (Datass.QQ[i] is OnePossibleAnswers)
                {
                    ((OnePossibleAnswers)(Datass.QQ[i])).ReadingQW();
                    Datass.Writerfile.WriteLine("OPA ;;{0}",   ((OnePossibleAnswers)(Datass.QQ[i])).Format);
                }
                else if (Datass.QQ[i] is SeveralPossibleAnswers)
                {
                    ((SeveralPossibleAnswers)(Datass.QQ[i])).ReadingQW();
                    Datass.Writerfile.WriteLine("SPA ;;{0}",  ((SeveralPossibleAnswers)(Datass.QQ[i])).Format);
                }
                else if (Datass.QQ[i] is QuestionForCompliance)
                {
                    ((QuestionForCompliance)(Datass.QQ[i])).ReadingQW();
                    Datass.Writerfile.WriteLine("QFS ;;{0}",  ((QuestionForCompliance)(Datass.QQ[i])).Format);
                }
                else if (Datass.QQ[i] is FreeAnswer)
                {
                    ((FreeAnswer)(Datass.QQ[i])).ReadingQW();
                    Datass.Writerfile.WriteLine("FA ;;{0}",  ((FreeAnswer)(Datass.QQ[i])).Format);
                }

            }
        }
    }





    static class Program
    {
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           
            //Vibor v = new Vibor();

           // v.ShowDialog();
           // if (v.DialogResult == DialogResult.Yes)
            
               // v.Dispose();
                Application.Run(new Form1());
                
            //} 
            //else if(v.DialogResult == DialogResult.No)
            //{
            //    v.Dispose();
            //}
            //else
            //{
            //    v.Dispose();
            //    return;
            //}



            if (Datass.Writerfile!=null)
            {
            Datass.Writerfile.Close();
            //Datass.Readerfile.Close();
            Datass.Namefile.Close();
            }
            
        }
    }
}
