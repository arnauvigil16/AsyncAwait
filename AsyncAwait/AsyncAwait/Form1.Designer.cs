namespace AsyncAwait
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSequencial = new System.Windows.Forms.Button();
            this.btnTPL = new System.Windows.Forms.Button();
            this.listaSequencial = new System.Windows.Forms.ListBox();
            this.listaTPL = new System.Windows.Forms.ListBox();
            this.boxTimerSec = new System.Windows.Forms.TextBox();
            this.BoxTimerTPL = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSequencial
            // 
            this.btnSequencial.Location = new System.Drawing.Point(175, 381);
            this.btnSequencial.Name = "btnSequencial";
            this.btnSequencial.Size = new System.Drawing.Size(75, 23);
            this.btnSequencial.TabIndex = 0;
            this.btnSequencial.Text = "Sequencial";
            this.btnSequencial.UseVisualStyleBackColor = true;
            this.btnSequencial.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTPL
            // 
            this.btnTPL.Location = new System.Drawing.Point(679, 381);
            this.btnTPL.Name = "btnTPL";
            this.btnTPL.Size = new System.Drawing.Size(75, 23);
            this.btnTPL.TabIndex = 1;
            this.btnTPL.Text = "TPL";
            this.btnTPL.UseVisualStyleBackColor = true;
            this.btnTPL.Click += new System.EventHandler(this.button2_Click);
            // 
            // listaSequencial
            // 
            this.listaSequencial.FormattingEnabled = true;
            this.listaSequencial.Location = new System.Drawing.Point(29, 56);
            this.listaSequencial.Name = "listaSequencial";
            this.listaSequencial.Size = new System.Drawing.Size(360, 264);
            this.listaSequencial.TabIndex = 2;
            this.listaSequencial.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listaTPL
            // 
            this.listaTPL.FormattingEnabled = true;
            this.listaTPL.Location = new System.Drawing.Point(532, 56);
            this.listaTPL.Name = "listaTPL";
            this.listaTPL.Size = new System.Drawing.Size(344, 264);
            this.listaTPL.TabIndex = 3;
            this.listaTPL.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // boxTimerSec
            // 
            this.boxTimerSec.Location = new System.Drawing.Point(29, 338);
            this.boxTimerSec.Name = "boxTimerSec";
            this.boxTimerSec.Size = new System.Drawing.Size(360, 20);
            this.boxTimerSec.TabIndex = 4;
            this.boxTimerSec.Text = "00.000 segundos";
            this.boxTimerSec.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BoxTimerTPL
            // 
            this.BoxTimerTPL.Location = new System.Drawing.Point(532, 338);
            this.BoxTimerTPL.Name = "BoxTimerTPL";
            this.BoxTimerTPL.Size = new System.Drawing.Size(344, 20);
            this.BoxTimerTPL.TabIndex = 5;
            this.BoxTimerTPL.Text = "00.000 segundos";
            this.BoxTimerTPL.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(420, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Hora actual";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(311, 444);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(299, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(911, 476);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BoxTimerTPL);
            this.Controls.Add(this.boxTimerSec);
            this.Controls.Add(this.listaTPL);
            this.Controls.Add(this.listaSequencial);
            this.Controls.Add(this.btnTPL);
            this.Controls.Add(this.btnSequencial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSequencial;
        private System.Windows.Forms.Button btnTPL;
        private System.Windows.Forms.ListBox listaSequencial;
        private System.Windows.Forms.ListBox listaTPL;
        private System.Windows.Forms.TextBox boxTimerSec;
        private System.Windows.Forms.TextBox BoxTimerTPL;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
    }
}

