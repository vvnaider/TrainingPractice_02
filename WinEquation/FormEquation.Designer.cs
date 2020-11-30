namespace WinEquation
{
    partial class FormEquation
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxEquation = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.colorDialogEquation = new System.Windows.Forms.ColorDialog();
            this.panelColor = new System.Windows.Forms.Panel();
            this.labelEquation = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonBrackets = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonPi = new System.Windows.Forms.Button();
            this.buttonBrachetClosing = new System.Windows.Forms.Button();
            this.buttonBracketOpening = new System.Windows.Forms.Button();
            this.buttonCos = new System.Windows.Forms.Button();
            this.buttonTan = new System.Windows.Forms.Button();
            this.buttonCtg = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonPow = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonAbs = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEquation
            // 
            this.textBoxEquation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxEquation.Location = new System.Drawing.Point(12, 108);
            this.textBoxEquation.Multiline = true;
            this.textBoxEquation.Name = "textBoxEquation";
            this.textBoxEquation.Size = new System.Drawing.Size(318, 52);
            this.textBoxEquation.TabIndex = 0;
            this.textBoxEquation.TextChanged += new System.EventHandler(this.textBoxEquation_TextChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonOk.Location = new System.Drawing.Point(13, 340);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(90, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonCancel.Location = new System.Drawing.Point(118, 340);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelColor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panelColor.Location = new System.Drawing.Point(15, 311);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(315, 23);
            this.panelColor.TabIndex = 3;
            this.panelColor.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // labelEquation
            // 
            this.labelEquation.AutoSize = true;
            this.labelEquation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEquation.Location = new System.Drawing.Point(12, 92);
            this.labelEquation.Name = "labelEquation";
            this.labelEquation.Size = new System.Drawing.Size(115, 13);
            this.labelEquation.TabIndex = 4;
            this.labelEquation.Text = "Уравнение (функция)";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.ForeColor = System.Drawing.SystemColors.Control;
            this.labelColor.Location = new System.Drawing.Point(12, 292);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(32, 13);
            this.labelColor.TabIndex = 5;
            this.labelColor.Text = "Цвет";
            // 
            // buttonBrackets
            // 
            this.buttonBrackets.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonBrackets.Location = new System.Drawing.Point(13, 166);
            this.buttonBrackets.Name = "buttonBrackets";
            this.buttonBrackets.Size = new System.Drawing.Size(75, 23);
            this.buttonBrackets.TabIndex = 6;
            this.buttonBrackets.Text = "()";
            this.buttonBrackets.UseVisualStyleBackColor = false;
            this.buttonBrackets.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonE
            // 
            this.buttonE.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonE.Location = new System.Drawing.Point(256, 282);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(75, 23);
            this.buttonE.TabIndex = 7;
            this.buttonE.Text = "e";
            this.buttonE.UseVisualStyleBackColor = false;
            this.buttonE.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonPi
            // 
            this.buttonPi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonPi.Location = new System.Drawing.Point(175, 253);
            this.buttonPi.Name = "buttonPi";
            this.buttonPi.Size = new System.Drawing.Size(75, 23);
            this.buttonPi.TabIndex = 8;
            this.buttonPi.Text = "pi";
            this.buttonPi.UseVisualStyleBackColor = false;
            this.buttonPi.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonBrachetClosing
            // 
            this.buttonBrachetClosing.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonBrachetClosing.Location = new System.Drawing.Point(175, 166);
            this.buttonBrachetClosing.Name = "buttonBrachetClosing";
            this.buttonBrachetClosing.Size = new System.Drawing.Size(75, 23);
            this.buttonBrachetClosing.TabIndex = 9;
            this.buttonBrachetClosing.Text = ")";
            this.buttonBrachetClosing.UseVisualStyleBackColor = false;
            this.buttonBrachetClosing.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonBracketOpening
            // 
            this.buttonBracketOpening.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonBracketOpening.Location = new System.Drawing.Point(94, 166);
            this.buttonBracketOpening.Name = "buttonBracketOpening";
            this.buttonBracketOpening.Size = new System.Drawing.Size(75, 23);
            this.buttonBracketOpening.TabIndex = 10;
            this.buttonBracketOpening.Text = "(";
            this.buttonBracketOpening.UseVisualStyleBackColor = false;
            this.buttonBracketOpening.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonCos
            // 
            this.buttonCos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonCos.Location = new System.Drawing.Point(94, 195);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.Size = new System.Drawing.Size(75, 23);
            this.buttonCos.TabIndex = 15;
            this.buttonCos.Text = "cos()";
            this.buttonCos.UseVisualStyleBackColor = false;
            this.buttonCos.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonTan
            // 
            this.buttonTan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonTan.Location = new System.Drawing.Point(175, 195);
            this.buttonTan.Name = "buttonTan";
            this.buttonTan.Size = new System.Drawing.Size(75, 23);
            this.buttonTan.TabIndex = 14;
            this.buttonTan.Text = "tan()";
            this.buttonTan.UseVisualStyleBackColor = false;
            this.buttonTan.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonCtg
            // 
            this.buttonCtg.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonCtg.Location = new System.Drawing.Point(257, 195);
            this.buttonCtg.Name = "buttonCtg";
            this.buttonCtg.Size = new System.Drawing.Size(75, 23);
            this.buttonCtg.TabIndex = 13;
            this.buttonCtg.Text = "ctg()";
            this.buttonCtg.UseVisualStyleBackColor = false;
            this.buttonCtg.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonLog.Location = new System.Drawing.Point(255, 253);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(75, 23);
            this.buttonLog.TabIndex = 12;
            this.buttonLog.Text = "log()";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonSin
            // 
            this.buttonSin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonSin.Location = new System.Drawing.Point(13, 195);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(75, 23);
            this.buttonSin.TabIndex = 11;
            this.buttonSin.Text = "sin()";
            this.buttonSin.UseVisualStyleBackColor = false;
            this.buttonSin.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonSub.Location = new System.Drawing.Point(94, 224);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(75, 23);
            this.buttonSub.TabIndex = 20;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = false;
            this.buttonSub.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonMul.Location = new System.Drawing.Point(175, 224);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(75, 23);
            this.buttonMul.TabIndex = 19;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = false;
            this.buttonMul.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonDiv.Location = new System.Drawing.Point(256, 166);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(75, 23);
            this.buttonDiv.TabIndex = 18;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = false;
            this.buttonDiv.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonPow
            // 
            this.buttonPow.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonPow.Location = new System.Drawing.Point(255, 224);
            this.buttonPow.Name = "buttonPow";
            this.buttonPow.Size = new System.Drawing.Size(75, 23);
            this.buttonPow.TabIndex = 17;
            this.buttonPow.Text = "^";
            this.buttonPow.UseVisualStyleBackColor = false;
            this.buttonPow.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonAdd.Location = new System.Drawing.Point(13, 224);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonAbs
            // 
            this.buttonAbs.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonAbs.Location = new System.Drawing.Point(15, 253);
            this.buttonAbs.Name = "buttonAbs";
            this.buttonAbs.Size = new System.Drawing.Size(75, 23);
            this.buttonAbs.TabIndex = 21;
            this.buttonAbs.Text = "abs()";
            this.buttonAbs.UseVisualStyleBackColor = false;
            this.buttonAbs.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonX
            // 
            this.buttonX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonX.Location = new System.Drawing.Point(94, 253);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(75, 23);
            this.buttonX.TabIndex = 22;
            this.buttonX.Text = "x";
            this.buttonX.UseVisualStyleBackColor = false;
            this.buttonX.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 78);
            this.label1.TabIndex = 23;
            this.label1.Text = "Напишите уравнение, например:\r\ntan(x)+1=ctg(x)+1\r\nsin(x)=cos(x)+1\r\ny=sin(x)\r\nabs(" +
    "x)=tan(x)\r\ntan(x)+1=cos(x)+1\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(200, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 39);
            this.label2.TabIndex = 24;
            this.label2.Text = "log(x)-1=sin(x)\r\npi*cos(x)=cos(x)^3\r\ntan(x)*cos(x)=ctg(x)+2";
            // 
            // FormEquation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(344, 372);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonAbs);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonPow);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCos);
            this.Controls.Add(this.buttonTan);
            this.Controls.Add(this.buttonCtg);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonSin);
            this.Controls.Add(this.buttonBracketOpening);
            this.Controls.Add(this.buttonBrachetClosing);
            this.Controls.Add(this.buttonPi);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonBrackets);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelEquation);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxEquation);
            this.Name = "FormEquation";
            this.Text = "FormEquation";
            this.Load += new System.EventHandler(this.FormEquation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEquation;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ColorDialog colorDialogEquation;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label labelEquation;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonBrackets;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonPi;
        private System.Windows.Forms.Button buttonBrachetClosing;
        private System.Windows.Forms.Button buttonBracketOpening;
        private System.Windows.Forms.Button buttonCos;
        private System.Windows.Forms.Button buttonTan;
        private System.Windows.Forms.Button buttonCtg;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonSin;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonPow;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonAbs;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}