namespace WindowsFormsApp1
{
    partial class Calculator
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_parentheses = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_equals = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_less = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.tBox_front = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(144, 98);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(60, 55);
            this.btn_9.TabIndex = 2;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(12, 159);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(60, 55);
            this.btn_4.TabIndex = 3;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(78, 159);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(60, 55);
            this.btn_5.TabIndex = 4;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(144, 159);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(60, 55);
            this.btn_6.TabIndex = 5;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(78, 220);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(60, 55);
            this.btn_2.TabIndex = 7;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(144, 220);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(60, 55);
            this.btn_3.TabIndex = 8;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_parentheses
            // 
            this.btn_parentheses.Location = new System.Drawing.Point(12, 281);
            this.btn_parentheses.Name = "btn_parentheses";
            this.btn_parentheses.Size = new System.Drawing.Size(60, 55);
            this.btn_parentheses.TabIndex = 9;
            this.btn_parentheses.Text = "(  )";
            this.btn_parentheses.UseVisualStyleBackColor = true;
            this.btn_parentheses.Click += new System.EventHandler(this.btn_parentheses_Click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(78, 281);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(60, 55);
            this.btn_0.TabIndex = 10;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_equals
            // 
            this.btn_equals.Location = new System.Drawing.Point(144, 281);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.Size = new System.Drawing.Size(60, 55);
            this.btn_equals.TabIndex = 11;
            this.btn_equals.Text = "=";
            this.btn_equals.UseVisualStyleBackColor = true;
            this.btn_equals.Click += new System.EventHandler(this.btn_equals_Click);
            // 
            // btn_division
            // 
            this.btn_division.Location = new System.Drawing.Point(210, 98);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(60, 55);
            this.btn_division.TabIndex = 12;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.Location = new System.Drawing.Point(210, 159);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(60, 55);
            this.btn_multi.TabIndex = 13;
            this.btn_multi.Text = "*";
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.btn_multi_Click);
            // 
            // btn_less
            // 
            this.btn_less.Location = new System.Drawing.Point(210, 220);
            this.btn_less.Name = "btn_less";
            this.btn_less.Size = new System.Drawing.Size(60, 55);
            this.btn_less.TabIndex = 14;
            this.btn_less.Text = "-";
            this.btn_less.UseVisualStyleBackColor = true;
            this.btn_less.Click += new System.EventHandler(this.btn_less_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(210, 281);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(60, 55);
            this.btn_plus.TabIndex = 15;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(12, 69);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(126, 23);
            this.btn_clear.TabIndex = 16;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // tBox_front
            // 
            this.tBox_front.Enabled = false;
            this.tBox_front.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_front.HideSelection = false;
            this.tBox_front.Location = new System.Drawing.Point(12, 12);
            this.tBox_front.Multiline = true;
            this.tBox_front.Name = "tBox_front";
            this.tBox_front.ReadOnly = true;
            this.tBox_front.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tBox_front.Size = new System.Drawing.Size(258, 48);
            this.tBox_front.TabIndex = 18;
            this.tBox_front.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBox_front.TextChanged += new System.EventHandler(this.tBox_front_TextChanged);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(145, 69);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(125, 23);
            this.btn_back.TabIndex = 19;
            this.btn_back.Text = "<-";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(78, 98);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(60, 55);
            this.btn_8.TabIndex = 20;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(12, 98);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(60, 55);
            this.btn_7.TabIndex = 21;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(12, 220);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(60, 55);
            this.btn_1.TabIndex = 22;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 351);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.tBox_front);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_less);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_equals);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_parentheses);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(295, 390);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(295, 390);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_parentheses;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_equals;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_less;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox tBox_front;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_1;
    }
}

