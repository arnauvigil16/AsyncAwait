using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;

namespace AsyncAwait
{
    public partial class Form1 : Form
    {

        ArrayList listaCarpetas = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await listSequencial();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await listTPL();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var fecha = DateTime.Now.ToString("HH:mm:ss");
            textBox3.Text =  fecha;
        }

        public async Task listTPL()
        {
            Stopwatch relojTPL = new Stopwatch();
            relojTPL.Start();

            //Introducir ruta de las carpetas
            Parallel.ForEach(System.IO.Directory.GetDirectories(@"C:\Users\arniv\Documents\provaAsyncAwait"), directoriTPL =>
            {
                foreach (string file in System.IO.Directory.GetFiles(directoriTPL))
                {
                    listaCarpetas.Add(file);
                    System.Threading.Thread.Sleep(1);
                }
            });
            listaTPL.DataSource = listaCarpetas;

            relojTPL.Stop();
            BoxTimerTPL.Text = relojTPL.Elapsed.TotalSeconds.ToString() + " segundos";
        }

        public async Task listSequencial()
        {
            Stopwatch relojSecuencial = new Stopwatch();
            relojSecuencial.Start();

            //Introducir ruta de las carpetas
            foreach (string directorio in System.IO.Directory.GetDirectories(@"C:\Users\arniv\Documents\provaAsyncAwait"))
            {
                foreach (string file in System.IO.Directory.GetFiles(directorio))
                {
                    listaCarpetas.Add(file);
                    System.Threading.Thread.Sleep(1);
                }
            }

            listaSequencial.DataSource = listaCarpetas;

            relojSecuencial.Stop();
            boxTimerSec.Text = relojSecuencial.Elapsed.TotalSeconds.ToString() + " segundos";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
