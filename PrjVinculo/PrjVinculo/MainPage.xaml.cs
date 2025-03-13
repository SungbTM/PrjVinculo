namespace PrjVinculo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void btnProduto_Clicked(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Descricao = "Coca Cola 2L";
            produto.Preco = 8;
            produto.Categoria = "Bebida";

            Navigation.PushAsync(new ProdutoPage() { BindingContext = produto});
        }

        private void btnAndares_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AndaresPage());
        }

        private void btnProduto2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProdutoPage2());
        }

        private void btnCelular_Clicked(object sender, EventArgs e)
        {
            Produto Celular = new Produto();

            Navigation.PushAsync(new Celular());
        }
    }
}
