using Modelos;

namespace ShowMilhao;

public partial class MainPage : ContentPage
{
  Gerenciador gerenciador;
	public MainPage()
	{
		InitializeComponent();
    gerenciador = new Gerenciador(labelPergunta, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
    gerenciador.ProximaQuestao();
	}

  private void OnBtnResposta01Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaCorreto(1);
  }

  private void OnBtnResposta02Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaCorreto(2);
  }

  private void OnBtnResposta03Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaCorreto(3);
  }

  private void OnBtnResposta04Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaCorreto(4);
  }

  private void OnBtnResposta05Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaCorreto(5);
  }
}

