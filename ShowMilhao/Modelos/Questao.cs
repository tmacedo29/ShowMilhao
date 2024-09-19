
namespace Modelos;

public class Questao
{
  public string? Pergunta {get; set;}
  public string? Resposta01  {get; set;}
  public string? Resposta02 {get; set;}
  public string? Resposta03 {get; set;}
  public string? Resposta04 {get; set;}
  public string? Resposta05 {get; set;}
  public int RespostaCorreta  {get; set;} = 0;
  public int Nivel { get; set; } = 0;

  Label? labelPergunta;
  Button? btnResposta01;
  Button? btnResposta02;
  Button? btnResposta03;
  Button? btnResposta04;
  Button? btnResposta05;

  //-------------------------------------------------------------------------------------------------------------------------------------

  public Questao()
  {

  }

  //-------------------------------------------------------------------------------------------------------------------------------------

  public Questao(string pergunta)
  {
    this.Pergunta = pergunta;
  }

  //-------------------------------------------------------------------------------------------------------------------------------------

  public Questao(string pergunta, string resposta01, string resposta02, string resposta03, string resposta04, string resposta05, int respostaCorreta)
  {
    this.Pergunta        = pergunta;
    this.Resposta01      = resposta01;
    this.Resposta02      = resposta02;
    this.Resposta03      = resposta03;
    this.Resposta04      = resposta04;
    this.Resposta05      = resposta05;
    this.RespostaCorreta = respostaCorreta;
  }

  //-------------------------------------------------------------------------------------------------------------------------------------

  public void ConfigurarDesenho(Label labelPergunta, Button btnResposta01, Button btnResposta02, Button btnResposta03, Button btnResposta04, Button btnResposta05)
  {
    this.labelPergunta = labelPergunta;
    this.btnResposta01 = btnResposta01;
    this.btnResposta02 = btnResposta02;
    this.btnResposta03 = btnResposta03;
    this.btnResposta04 = btnResposta04;
    this.btnResposta05 = btnResposta05;
  }

  //-------------------------------------------------------------------------------------------------------------------------------------

  public void Desenha()
  {
    this.labelPergunta!.Text = this.Pergunta;
    this.btnResposta01!.Text = this.Resposta01;
    this.btnResposta02!.Text = this.Resposta02;
    this.btnResposta03!.Text = this.Resposta03;
    this.btnResposta04!.Text = this.Resposta04;
    this.btnResposta05!.Text = this.Resposta05;
    
    this.btnResposta01!.BackgroundColor = Colors.DarkBlue;
    this.btnResposta01!.TextColor       = Colors.White;
    this.btnResposta02!.BackgroundColor = Colors.DarkBlue;
    this.btnResposta02!.TextColor       = Colors.White;
    this.btnResposta03!.BackgroundColor = Colors.DarkBlue;
    this.btnResposta03!.TextColor       = Colors.White;
    this.btnResposta04!.BackgroundColor = Colors.DarkBlue;
    this.btnResposta04!.TextColor       = Colors.White;
    this.btnResposta05!.BackgroundColor = Colors.DarkBlue;
    this.btnResposta05!.TextColor       = Colors.White;
  }
  
  //-------------------------------------------------------------------------------------------------------------------------------------

  public bool EstaCorreto(int resposta)
  {
    if (RespostaCorreta == resposta)
    {
      DesenhaCorreto(resposta);
      return true;
    }
    else
    {
      DesenhaIncorreto(resposta);
      return false;
    }
  }

  //-------------------------------------------------------------------------------------------------------------------------------------

  private void DesenhaCorreto(int resposta)
  {
    var button = QualButton(resposta);
    DesenhaButtonCorreto(button!);
  }
  
  //-------------------------------------------------------------------------------------------------------------------------------------

  private void DesenhaIncorreto(int resposta)
  {
    var buttonCorreta  = QualButton(RespostaCorreta);
    var buttonResposta = QualButton(resposta);
    DesenhaButtonIncorreto(buttonCorreta!, buttonResposta!);
  }

  //-------------------------------------------------------------------------------------------------------------------------------------

  private Button? QualButton(int resposta)
  {
    switch (resposta)
    {
      case 1:
        return btnResposta01;
      case 2:
        return btnResposta02;
      case 3:
        return btnResposta03;
      case 4:
        return btnResposta04;
      case 5:
        return btnResposta05;
      default:
        return null;
    }
  }

  //-------------------------------------------------------------------------------------------------------------------------------------

  private void DesenhaButtonCorreto(Button button)
  {
    button.BackgroundColor = Colors.Green;
    button.TextColor = Colors.White;
  }

  //-------------------------------------------------------------------------------------------------------------------------------------
  private void DesenhaButtonIncorreto(Button buttonCorreto, Button buttonResposta)
  {
    buttonCorreto.BackgroundColor = Colors.Yellow;
    buttonCorreto.TextColor       = Colors.White;

    buttonResposta.BackgroundColor = Colors.Red;
    buttonResposta.TextColor       = Colors.White;
  }

  //-------------------------------------------------------------------------------------------------------------------------------------
}