namespace Calculator
{
    partial class Calculator
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
            this.digit_line = new System.Windows.Forms.TextBox();
            this.modulo = new System.Windows.Forms.Button();
            this.inverse = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.plus_minus = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.ce = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.muliplicate = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.square_root = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.erase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // digit_line
            // 
            this.digit_line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.digit_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.digit_line.Location = new System.Drawing.Point(20, 24);
            this.digit_line.Name = "digit_line";
            this.digit_line.Size = new System.Drawing.Size(414, 80);
            this.digit_line.TabIndex = 0;
            this.digit_line.Text = "0";
            this.digit_line.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // modulo
            // 
            this.modulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.modulo.Location = new System.Drawing.Point(20, 113);
            this.modulo.Name = "modulo";
            this.modulo.Size = new System.Drawing.Size(99, 85);
            this.modulo.TabIndex = 1;
            this.modulo.Text = "%";
            this.modulo.UseVisualStyleBackColor = true;
            this.modulo.Click += new System.EventHandler(this.modulo_Click);
            // 
            // inverse
            // 
            this.inverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inverse.Location = new System.Drawing.Point(20, 204);
            this.inverse.Name = "inverse";
            this.inverse.Size = new System.Drawing.Size(99, 85);
            this.inverse.TabIndex = 2;
            this.inverse.Text = "1/x";
            this.inverse.UseVisualStyleBackColor = true;
            this.inverse.Click += new System.EventHandler(this.inverse_Click);
            // 
            // n7
            // 
            this.n7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.n7.Location = new System.Drawing.Point(20, 295);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(99, 85);
            this.n7.TabIndex = 3;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            this.n7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.n7_KeyPress);
            // 
            // n4
            // 
            this.n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.n4.Location = new System.Drawing.Point(20, 386);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(99, 85);
            this.n4.TabIndex = 4;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            this.n4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.n4_KeyPress);
            // 
            // n1
            // 
            this.n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.n1.Location = new System.Drawing.Point(20, 477);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(99, 85);
            this.n1.TabIndex = 5;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            this.n1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.n1_KeyPress);
            // 
            // plus_minus
            // 
            this.plus_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plus_minus.Location = new System.Drawing.Point(20, 568);
            this.plus_minus.Name = "plus_minus";
            this.plus_minus.Size = new System.Drawing.Size(99, 85);
            this.plus_minus.TabIndex = 6;
            this.plus_minus.Text = "+/-";
            this.plus_minus.UseVisualStyleBackColor = true;
            this.plus_minus.Click += new System.EventHandler(this.plus_minus_Click);
            // 
            // C
            // 
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.C.Location = new System.Drawing.Point(230, 113);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(99, 85);
            this.C.TabIndex = 7;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            // 
            // ce
            // 
            this.ce.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ce.Location = new System.Drawing.Point(125, 113);
            this.ce.Name = "ce";
            this.ce.Size = new System.Drawing.Size(99, 85);
            this.ce.TabIndex = 8;
            this.ce.Text = "CE";
            this.ce.UseVisualStyleBackColor = true;
            // 
            // square
            // 
            this.square.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.square.Location = new System.Drawing.Point(125, 204);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(99, 85);
            this.square.TabIndex = 9;
            this.square.Text = "x²";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // subtract
            // 
            this.subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subtract.Location = new System.Drawing.Point(335, 386);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(99, 85);
            this.subtract.TabIndex = 11;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // muliplicate
            // 
            this.muliplicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.muliplicate.Location = new System.Drawing.Point(335, 295);
            this.muliplicate.Name = "muliplicate";
            this.muliplicate.Size = new System.Drawing.Size(99, 85);
            this.muliplicate.TabIndex = 12;
            this.muliplicate.Text = "×";
            this.muliplicate.UseVisualStyleBackColor = true;
            this.muliplicate.Click += new System.EventHandler(this.muliplicate_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.divide.Location = new System.Drawing.Point(335, 204);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(99, 85);
            this.divide.TabIndex = 13;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // square_root
            // 
            this.square_root.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.square_root.Location = new System.Drawing.Point(230, 204);
            this.square_root.Name = "square_root";
            this.square_root.Size = new System.Drawing.Size(99, 85);
            this.square_root.TabIndex = 14;
            this.square_root.Text = "√x";
            this.square_root.UseVisualStyleBackColor = true;
            this.square_root.Click += new System.EventHandler(this.square_root_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add.Location = new System.Drawing.Point(335, 477);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(99, 85);
            this.add.TabIndex = 15;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equal.Location = new System.Drawing.Point(335, 568);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(99, 85);
            this.equal.TabIndex = 16;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // point
            // 
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.point.Location = new System.Drawing.Point(230, 568);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(99, 85);
            this.point.TabIndex = 17;
            this.point.Text = ",";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.point_Click);
            this.point.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.point_KeyPress);
            // 
            // n0
            // 
            this.n0.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.n0.Location = new System.Drawing.Point(125, 568);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(99, 85);
            this.n0.TabIndex = 18;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = true;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            this.n0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.n0_KeyPress);
            // 
            // n6
            // 
            this.n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.n6.Location = new System.Drawing.Point(230, 386);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(99, 85);
            this.n6.TabIndex = 19;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            this.n6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.n6_KeyPress);
            // 
            // n5
            // 
            this.n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.n5.Location = new System.Drawing.Point(125, 386);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(99, 85);
            this.n5.TabIndex = 20;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            this.n5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.n5_KeyPress);
            // 
            // n2
            // 
            this.n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.n2.Location = new System.Drawing.Point(125, 477);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(99, 85);
            this.n2.TabIndex = 21;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            this.n2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.n2_KeyPress);
            // 
            // n3
            // 
            this.n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.n3.Location = new System.Drawing.Point(230, 477);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(99, 85);
            this.n3.TabIndex = 22;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            this.n3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.n3_KeyPress);
            // 
            // n9
            // 
            this.n9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.n9.Location = new System.Drawing.Point(230, 295);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(99, 85);
            this.n9.TabIndex = 23;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            this.n9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.n9_KeyPress);
            // 
            // n8
            // 
            this.n8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.n8.Location = new System.Drawing.Point(125, 295);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(99, 85);
            this.n8.TabIndex = 24;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            this.n8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.n8_KeyPress);
            // 
            // erase
            // 
            this.erase.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.erase.Location = new System.Drawing.Point(335, 113);
            this.erase.Name = "erase";
            this.erase.Size = new System.Drawing.Size(99, 85);
            this.erase.TabIndex = 25;
            this.erase.Text = "⌫";
            this.erase.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.ClientSize = new System.Drawing.Size(454, 673);
            this.Controls.Add(this.erase);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.point);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.add);
            this.Controls.Add(this.square_root);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.muliplicate);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.square);
            this.Controls.Add(this.ce);
            this.Controls.Add(this.C);
            this.Controls.Add(this.plus_minus);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.inverse);
            this.Controls.Add(this.modulo);
            this.Controls.Add(this.digit_line);
            this.Name = "Calculator";
            this.Resize += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox digit_line;
        private System.Windows.Forms.Button modulo;
        private System.Windows.Forms.Button inverse;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button plus_minus;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button ce;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button muliplicate;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button square_root;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button erase;
    }
}

