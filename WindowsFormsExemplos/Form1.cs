using Newtonsoft.Json;

namespace WindowsFormsExemplos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            int quantidadeHoras = Convert.ToInt32(textBoxQuantidadeHoras.Text);
            double valorHora = Convert.ToDouble(textBoxValorHora.Text);

            FolhaPagamento folhaPagamento = new FolhaPagamento();
            folhaPagamento.NomeColaborador = nome;
            folhaPagamento.QuantidadeHoras = quantidadeHoras;
            folhaPagamento.ValorHora = valorHora;

            MessageBox.Show($@"Folha de Pagamento: {folhaPagamento.NomeColaborador}
Salário Bruto: {folhaPagamento.CalcularSalarioBruto():C}
Desconto INSS: {folhaPagamento.CalcularInss():C}");


            string jsonFolhaPagamento = JsonConvert.SerializeObject(folhaPagamento);
            File.WriteAllText("C:\\Users\\Moc\\Desktop\\Arquivo.json", jsonFolhaPagamento);
        }
    }
}