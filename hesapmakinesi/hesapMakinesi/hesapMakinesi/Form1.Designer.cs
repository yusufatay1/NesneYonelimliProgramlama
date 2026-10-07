namespace hesapMakinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(507, 82);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(399, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 85);
            this.button1.TabIndex = 2;
            this.button1.Text = "/";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.IslemTiklandi);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(270, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 85);
            this.button2.TabIndex = 3;
            this.button2.Text = "%";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnYuzde_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(141, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 85);
            this.button3.TabIndex = 4;
            this.button3.Text = "<-";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(12, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 85);
            this.button4.TabIndex = 5;
            this.button4.Text = "C";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnC_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(12, 191);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 85);
            this.button5.TabIndex = 9;
            this.button5.Text = "7";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.SayiTiklandi);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(141, 191);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 85);
            this.button6.TabIndex = 8;
            this.button6.Text = "8";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.SayiTiklandi);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gray;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(270, 191);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 85);
            this.button7.TabIndex = 7;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.SayiTiklandi);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gray;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.SystemColors.Control;
            this.button8.Location = new System.Drawing.Point(399, 191);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 85);
            this.button8.TabIndex = 6;
            this.button8.Text = "*";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.IslemTiklandi);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Gray;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.ForeColor = System.Drawing.SystemColors.Control;
            this.button9.Location = new System.Drawing.Point(12, 282);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 85);
            this.button9.TabIndex = 13;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.SayiTiklandi);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Gray;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.ForeColor = System.Drawing.SystemColors.Control;
            this.button10.Location = new System.Drawing.Point(141, 282);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(120, 85);
            this.button10.TabIndex = 12;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.SayiTiklandi);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Gray;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.ForeColor = System.Drawing.SystemColors.Control;
            this.button11.Location = new System.Drawing.Point(270, 282);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(120, 85);
            this.button11.TabIndex = 11;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.SayiTiklandi);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Gray;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button12.ForeColor = System.Drawing.SystemColors.Control;
            this.button12.Location = new System.Drawing.Point(399, 282);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(120, 85);
            this.button12.TabIndex = 10;
            this.button12.Text = "+";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.IslemTiklandi);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Gray;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button13.ForeColor = System.Drawing.SystemColors.Control;
            this.button13.Location = new System.Drawing.Point(12, 373);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(120, 85);
            this.button13.TabIndex = 17;
            this.button13.Text = "1";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.SayiTiklandi);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Gray;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button14.ForeColor = System.Drawing.SystemColors.Control;
            this.button14.Location = new System.Drawing.Point(141, 373);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(120, 85);
            this.button14.TabIndex = 16;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.SayiTiklandi);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Gray;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button16.ForeColor = System.Drawing.SystemColors.Control;
            this.button16.Location = new System.Drawing.Point(270, 373);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(120, 85);
            this.button16.TabIndex = 14;
            this.button16.Text = "3";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.SayiTiklandi);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Gray;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button15.ForeColor = System.Drawing.SystemColors.Control;
            this.button15.Location = new System.Drawing.Point(399, 373);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(120, 85);
            this.button15.TabIndex = 18;
            this.button15.Text = "-";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.IslemTiklandi);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button17.ForeColor = System.Drawing.SystemColors.Control;
            this.button17.Location = new System.Drawing.Point(270, 464);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(249, 85);
            this.button17.TabIndex = 22;
            this.button17.Text = "=";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.btnEsittir_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Gray;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button18.ForeColor = System.Drawing.SystemColors.Control;
            this.button18.Location = new System.Drawing.Point(12, 464);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(120, 85);
            this.button18.TabIndex = 21;
            this.button18.Text = ",";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.btnVirgul_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Gray;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button19.ForeColor = System.Drawing.SystemColors.Control;
            this.button19.Location = new System.Drawing.Point(141, 464);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(120, 85);
            this.button19.TabIndex = 20;
            this.button19.Text = "0";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.SayiTiklandi);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(534, 561);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
    }
}

