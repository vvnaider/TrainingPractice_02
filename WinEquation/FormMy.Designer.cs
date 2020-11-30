namespace WinEquation
{
    partial class FormMy
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

        #region 

        private void InitializeComponent()
        {
            this.panelEquation = new System.Windows.Forms.Panel();
            this.labelMinX = new System.Windows.Forms.Label();
            this.labelMaxX = new System.Windows.Forms.Label();
            this.labelMinY = new System.Windows.Forms.Label();
            this.labelMaxY = new System.Windows.Forms.Label();
            this.textBoxMinX = new System.Windows.Forms.TextBox();
            this.textBoxMaxX = new System.Windows.Forms.TextBox();
            this.textBoxMaxY = new System.Windows.Forms.TextBox();
            this.textBoxMinY = new System.Windows.Forms.TextBox();
            this.groupBoxDiapason = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.groupBoxEquation = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxEquation = new System.Windows.Forms.ListBox();
            this.groupBoxDiapason.SuspendLayout();
            this.groupBoxEquation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEquation
            // 
            this.panelEquation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelEquation.Location = new System.Drawing.Point(11, 12);
            this.panelEquation.Name = "panelEquation";
            this.panelEquation.Size = new System.Drawing.Size(400, 400);
            this.panelEquation.TabIndex = 1;
            this.panelEquation.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEquation_Paint);
            // 
            // labelMinX
            // 
            this.labelMinX.AutoSize = true;
            this.labelMinX.Location = new System.Drawing.Point(42, 22);
            this.labelMinX.Name = "labelMinX";
            this.labelMinX.Size = new System.Drawing.Size(34, 13);
            this.labelMinX.TabIndex = 3;
            this.labelMinX.Text = "Min X";
            // 
            // labelMaxX
            // 
            this.labelMaxX.AutoSize = true;
            this.labelMaxX.Location = new System.Drawing.Point(42, 74);
            this.labelMaxX.Name = "labelMaxX";
            this.labelMaxX.Size = new System.Drawing.Size(37, 13);
            this.labelMaxX.TabIndex = 4;
            this.labelMaxX.Text = "Max X";
            // 
            // labelMinY
            // 
            this.labelMinY.AutoSize = true;
            this.labelMinY.Location = new System.Drawing.Point(42, 48);
            this.labelMinY.Name = "labelMinY";
            this.labelMinY.Size = new System.Drawing.Size(34, 13);
            this.labelMinY.TabIndex = 5;
            this.labelMinY.Text = "Min Y";
            // 
            // labelMaxY
            // 
            this.labelMaxY.AutoSize = true;
            this.labelMaxY.Location = new System.Drawing.Point(42, 100);
            this.labelMaxY.Name = "labelMaxY";
            this.labelMaxY.Size = new System.Drawing.Size(37, 13);
            this.labelMaxY.TabIndex = 6;
            this.labelMaxY.Text = "Max Y";
            // 
            // textBoxMinX
            // 
            this.textBoxMinX.Location = new System.Drawing.Point(89, 19);
            this.textBoxMinX.Name = "textBoxMinX";
            this.textBoxMinX.Size = new System.Drawing.Size(84, 20);
            this.textBoxMinX.TabIndex = 7;
            this.textBoxMinX.Text = "-5";
            this.textBoxMinX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxMaxX
            // 
            this.textBoxMaxX.Location = new System.Drawing.Point(89, 71);
            this.textBoxMaxX.Name = "textBoxMaxX";
            this.textBoxMaxX.Size = new System.Drawing.Size(84, 20);
            this.textBoxMaxX.TabIndex = 8;
            this.textBoxMaxX.Text = "5";
            this.textBoxMaxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxMaxY
            // 
            this.textBoxMaxY.Location = new System.Drawing.Point(89, 97);
            this.textBoxMaxY.Name = "textBoxMaxY";
            this.textBoxMaxY.Size = new System.Drawing.Size(84, 20);
            this.textBoxMaxY.TabIndex = 9;
            this.textBoxMaxY.Text = "5";
            this.textBoxMaxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxMinY
            // 
            this.textBoxMinY.Location = new System.Drawing.Point(89, 45);
            this.textBoxMinY.Name = "textBoxMinY";
            this.textBoxMinY.Size = new System.Drawing.Size(84, 20);
            this.textBoxMinY.TabIndex = 10;
            this.textBoxMinY.Text = "-5";
            this.textBoxMinY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxDiapason
            // 
            this.groupBoxDiapason.Controls.Add(this.buttonRefresh);
            this.groupBoxDiapason.Controls.Add(this.textBoxMinX);
            this.groupBoxDiapason.Controls.Add(this.labelMinX);
            this.groupBoxDiapason.Controls.Add(this.labelMaxY);
            this.groupBoxDiapason.Controls.Add(this.textBoxMinY);
            this.groupBoxDiapason.Controls.Add(this.textBoxMaxX);
            this.groupBoxDiapason.Controls.Add(this.labelMaxX);
            this.groupBoxDiapason.Controls.Add(this.labelMinY);
            this.groupBoxDiapason.Controls.Add(this.textBoxMaxY);
            this.groupBoxDiapason.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBoxDiapason.Location = new System.Drawing.Point(419, 42);
            this.groupBoxDiapason.Name = "groupBoxDiapason";
            this.groupBoxDiapason.Size = new System.Drawing.Size(207, 158);
            this.groupBoxDiapason.TabIndex = 13;
            this.groupBoxDiapason.TabStop = false;
            this.groupBoxDiapason.Text = "Диапазон";
            this.groupBoxDiapason.Enter += new System.EventHandler(this.groupBoxDiapason_Enter);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonRefresh.Location = new System.Drawing.Point(98, 123);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // groupBoxEquation
            // 
            this.groupBoxEquation.Controls.Add(this.buttonDelete);
            this.groupBoxEquation.Controls.Add(this.listBoxEquation);
            this.groupBoxEquation.Controls.Add(this.buttonAdd);
            this.groupBoxEquation.Controls.Add(this.buttonEdit);
            this.groupBoxEquation.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBoxEquation.Location = new System.Drawing.Point(419, 215);
            this.groupBoxEquation.Name = "groupBoxEquation";
            this.groupBoxEquation.Size = new System.Drawing.Size(206, 197);
            this.groupBoxEquation.TabIndex = 14;
            this.groupBoxEquation.TabStop = false;
            this.groupBoxEquation.Text = "Уравнения (функции)";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonDelete.Location = new System.Drawing.Point(119, 168);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonEdit.Location = new System.Drawing.Point(119, 132);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonAdd.Location = new System.Drawing.Point(7, 132);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxEquation
            // 
            this.listBoxEquation.FormattingEnabled = true;
            this.listBoxEquation.Location = new System.Drawing.Point(7, 20);
            this.listBoxEquation.MultiColumn = true;
            this.listBoxEquation.Name = "listBoxEquation";
            this.listBoxEquation.Size = new System.Drawing.Size(187, 108);
            this.listBoxEquation.TabIndex = 0;
            // 
            // FormMy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(637, 425);
            this.Controls.Add(this.groupBoxEquation);
            this.Controls.Add(this.groupBoxDiapason);
            this.Controls.Add(this.panelEquation);
            this.Name = "FormMy";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormMy_Load);
            this.groupBoxDiapason.ResumeLayout(false);
            this.groupBoxDiapason.PerformLayout();
            this.groupBoxEquation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEquation;
        private System.Windows.Forms.Label labelMinX;
        private System.Windows.Forms.Label labelMaxX;
        private System.Windows.Forms.Label labelMinY;
        private System.Windows.Forms.Label labelMaxY;
        private System.Windows.Forms.TextBox textBoxMinX;
        private System.Windows.Forms.TextBox textBoxMaxX;
        private System.Windows.Forms.TextBox textBoxMaxY;
        private System.Windows.Forms.TextBox textBoxMinY;
        private System.Windows.Forms.GroupBox groupBoxDiapason;
        private System.Windows.Forms.GroupBox groupBoxEquation;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxEquation;
        private System.Windows.Forms.Button buttonRefresh;

    }
}

