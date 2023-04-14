
using MySql.Data.MySqlClient;
namespace projeto_loja
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao = new MySqlConnection("server = localhost; uid = root; pwd = ''; database=loja ");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt16(textBox3.Text);

            MySqlCommand comando = new MySqlCommand("insert into produtos(descricao, valor, quantidade) values(" +
                "'" + textBox1.Text + "','"
                + textBox2.Text + "','"
                + quantidade + "')", conexao);
            conexao.Open();
            comando.ExecuteReader();
            MessageBox.Show("Cadastrado com sucesso!");
        }
    }
}