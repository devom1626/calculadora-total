namespace intento_nuevo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.IGUAL = new System.Windows.Forms.Button();
            this.res = new System.Windows.Forms.Button();
            this.divi = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.pote = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.cubic = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.borrapar = new System.Windows.Forms.Button();
            this.dltone = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.RESU = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IGUAL
            // 
            this.IGUAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IGUAL.Location = new System.Drawing.Point(12, 352);
            this.IGUAL.Name = "IGUAL";
            this.IGUAL.Size = new System.Drawing.Size(108, 41);
            this.IGUAL.TabIndex = 53;
            this.IGUAL.Tag = "=";
            this.IGUAL.Text = "=";
            this.IGUAL.UseVisualStyleBackColor = true;
            this.IGUAL.Click += new System.EventHandler(this.IGUAL_Click);
            // 
            // res
            // 
            this.res.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res.Location = new System.Drawing.Point(194, 352);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(51, 41);
            this.res.TabIndex = 52;
            this.res.Text = "-";
            this.res.UseVisualStyleBackColor = true;
            this.res.Click += new System.EventHandler(this.clickOperador);
            // 
            // divi
            // 
            this.divi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divi.Location = new System.Drawing.Point(194, 301);
            this.divi.Name = "divi";
            this.divi.Size = new System.Drawing.Size(51, 45);
            this.divi.TabIndex = 51;
            this.divi.Tag = "/";
            this.divi.Text = "/";
            this.divi.UseVisualStyleBackColor = true;
            this.divi.Click += new System.EventHandler(this.clickOperador);
            // 
            // raiz
            // 
            this.raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raiz.Location = new System.Drawing.Point(194, 199);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(51, 45);
            this.raiz.TabIndex = 50;
            this.raiz.Tag = "√";
            this.raiz.Text = "√";
            this.raiz.UseVisualStyleBackColor = true;
            this.raiz.Click += new System.EventHandler(this.clickOperador);
            // 
            // pote
            // 
            this.pote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pote.Location = new System.Drawing.Point(194, 250);
            this.pote.Name = "pote";
            this.pote.Size = new System.Drawing.Size(51, 45);
            this.pote.TabIndex = 49;
            this.pote.Tag = "²";
            this.pote.Text = "X²";
            this.pote.UseVisualStyleBackColor = true;
            this.pote.Click += new System.EventHandler(this.clickOperador);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(194, 96);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(51, 45);
            this.save.TabIndex = 48;
            this.save.Tag = "*";
            this.save.Text = "*";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.clickOperador);
            // 
            // cubic
            // 
            this.cubic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cubic.Location = new System.Drawing.Point(194, 147);
            this.cubic.Name = "cubic";
            this.cubic.Size = new System.Drawing.Size(51, 45);
            this.cubic.TabIndex = 47;
            this.cubic.Tag = "³";
            this.cubic.Text = "³√";
            this.cubic.UseVisualStyleBackColor = true;
            this.cubic.Click += new System.EventHandler(this.clickOperador);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(126, 352);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(51, 41);
            this.add.TabIndex = 46;
            this.add.Tag = "+";
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.clickOperador);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(12, 301);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(51, 45);
            this.clear.TabIndex = 45;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // borrapar
            // 
            this.borrapar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrapar.Location = new System.Drawing.Point(69, 301);
            this.borrapar.Name = "borrapar";
            this.borrapar.Size = new System.Drawing.Size(51, 45);
            this.borrapar.TabIndex = 44;
            this.borrapar.Text = "CE";
            this.borrapar.UseVisualStyleBackColor = true;
            this.borrapar.Click += new System.EventHandler(this.borrapar_Click);
            // 
            // dltone
            // 
            this.dltone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dltone.Location = new System.Drawing.Point(126, 301);
            this.dltone.Name = "dltone";
            this.dltone.Size = new System.Drawing.Size(51, 45);
            this.dltone.TabIndex = 43;
            this.dltone.Text = "<<";
            this.dltone.UseVisualStyleBackColor = true;
            this.dltone.Click += new System.EventHandler(this.dltone_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(69, 199);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(51, 45);
            this.two.TabIndex = 42;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.agregar_num);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(126, 199);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(51, 45);
            this.three.TabIndex = 41;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.agregar_num);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(12, 250);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(51, 45);
            this.zero.TabIndex = 40;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.agregar_num);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(69, 250);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(51, 45);
            this.button14.TabIndex = 39;
            this.button14.Text = ".";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(126, 250);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(51, 45);
            this.button15.TabIndex = 38;
            this.button15.Tag = "a";
            this.button15.Text = "(-)";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(12, 199);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(51, 45);
            this.one.TabIndex = 37;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.agregar_num);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(69, 96);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(51, 45);
            this.eight.TabIndex = 36;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.agregar_num);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(126, 96);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(51, 45);
            this.nine.TabIndex = 35;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.agregar_num);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(12, 147);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(51, 45);
            this.four.TabIndex = 34;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.agregar_num);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(69, 147);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(51, 45);
            this.five.TabIndex = 33;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.agregar_num);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(126, 147);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(51, 45);
            this.six.TabIndex = 32;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.agregar_num);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(12, 96);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(51, 45);
            this.seven.TabIndex = 31;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.agregar_num);
            // 
            // RESU
            // 
            this.RESU.Location = new System.Drawing.Point(12, 12);
            this.RESU.MaxLength = 19;
            this.RESU.Multiline = true;
            this.RESU.Name = "RESU";
            this.RESU.ReadOnly = true;
            this.RESU.Size = new System.Drawing.Size(233, 71);
            this.RESU.TabIndex = 30;
            this.RESU.Text = "0";
            this.RESU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 400);
            this.Controls.Add(this.IGUAL);
            this.Controls.Add(this.res);
            this.Controls.Add(this.divi);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.pote);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cubic);
            this.Controls.Add(this.add);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.borrapar);
            this.Controls.Add(this.dltone);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.one);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.four);
            this.Controls.Add(this.five);
            this.Controls.Add(this.six);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.RESU);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IGUAL;
        private System.Windows.Forms.Button res;
        private System.Windows.Forms.Button divi;
        private System.Windows.Forms.Button raiz;
        private System.Windows.Forms.Button pote;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cubic;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button borrapar;
        private System.Windows.Forms.Button dltone;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.TextBox RESU;
    }
}

