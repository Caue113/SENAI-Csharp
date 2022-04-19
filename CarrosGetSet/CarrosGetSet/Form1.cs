namespace CarrosGetSet
{
    public partial class Form1 : Form
    {

        int i;      //Posicao do carro instanciado mais atual
        int pos;    //Posicao do carro selecionado no listBox

        Equipa E = new Equipa(3);   //3 instâncias de Carro a serem criadas.



        public Form1()
        {
            InitializeComponent();
        }

        //Ao carregar o programa (pagina inicial)
        private void Form1_Load(object sender, EventArgs e)
        {
            i = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            E[i] = new Carro(txtMarca.Text, Convert.ToDouble(txtVelocidade.Text));
            i++;

            UpdateListBox();

            if (i > 2) { btnAdd.Enabled = false;}     //Versão original

            lblVelocidadeMedia.Text = "Velocidade Média: " + Convert.ToString(CalcularMedia()); 


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Pega objeto na lista e atualiza com valores no formulario atual
            E[pos].MarcaCarro = txtMarca.Text;
            E[pos].VelocidadeCarro = Convert.ToInt16(txtVelocidade.Text);

            //Atualiza as velocidades e marcas da listBox
            UpdateListBox();

            //Atualiza velocidade media
            lblVelocidadeMedia.Text = "Velocidade Média: " + Convert.ToString(CalcularMedia());
            
        }

        private void lbxListaCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Armazena a posicao do objeto selecionado
            pos = Convert.ToInt16(lbxListaCarros.SelectedIndex.ToString());

            //Limpar textos de velocidade e marca ao selecionar
            txtMarca.Text = "";
            txtVelocidade.Text = "";

            //Preenche com valores do carro selecionado no formulario onde o usuario add/atualiza carros
            txtMarca.Text = E[pos].MarcaCarro;
            txtVelocidade.Text = Convert.ToString(E[pos].VelocidadeCarro);

        }


        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVelocidade_TextChanged(object sender, EventArgs e)
        {

        }

        

        


        private void UpdateListBox() 
        {
            int j;
            lbxListaCarros.Items.Clear();   //Limpa toda caixa
            for (j = 0; j < i; j++)         //Repopula e adiciona qtd carros inseridos ate entao
            {
                lbxListaCarros.Items.Add(E[j].MarcaCarro + " - " + E[j].VelocidadeCarro) ;
            }
        } 


        private double CalcularMedia() 
        {
            int j = 0;                          
            double media = 0.0, soma = 0.0; 

            for (j = 0; j < i; j++) 
            {
                soma += E[j].VelocidadeCarro;

            }

            return (media = soma / j);

        }



    }
}