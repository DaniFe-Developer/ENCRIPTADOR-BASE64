namespace Encriptador_Base_64
{
    public partial class Form1 : Form
    {
        // Variable para almacenar el mensaje original
        private string mensajeOriginal = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        String encriptar(string cadena)
        {
            // Método de encriptación
            string resultado = string.Empty;
            byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(cadena);

            resultado = Convert.ToBase64String(encriptar);
            return resultado;
        }

        string desencriptar(string cadena)
        {
            string resultado = string.Empty;
            byte[] desencriptar = Convert.FromBase64String(cadena);

            resultado = System.Text.Encoding.Unicode.GetString(desencriptar);
            return resultado;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Al encriptar, guardar el mensaje original
            mensajeOriginal = this.textBox1.Text;
            this.textBox2.Text = encriptar(mensajeOriginal);
            this.textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Al desencriptar, mostrar el mensaje original
            this.textBox2.Text = desencriptar(this.textBox1.Text);
            this.textBox1.Text = mensajeOriginal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            // Limpiar la variable del mensaje original
            mensajeOriginal = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/DaniFe-Developer";

        }
    }
}
