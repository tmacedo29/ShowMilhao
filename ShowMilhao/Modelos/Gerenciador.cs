namespace Modelos;

public class Gerenciador
{
  public List<Questao> listaQuestoes = new List<Questao>();
  public List<int> listaQuestoesRespondidas = new List<int>();
  private Questao? QuestaoCorrente;

  public bool TemAjudaCartas { get; private set; } = false;
  public bool TemAjudaUniversitarios { get; private set; } = false;
  public bool TemAjudaPular { get; private set; } = false;
  public int NumDePulosRestantes { get; private set; } = 3;


  //-------------------------------------------------------------------------------------
  public Gerenciador(Label labelPergunta, Button btnResposta01, Button btnResposta02, Button btnResposta03, Button btnResposta04, Button btnResposta05)
  {
    CriarPerguntas(labelPergunta, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
  }

  //-------------------------------------------------------------------------------------

  public void ProximaQuestao()
  {
    var numRandomico = Random.Shared.Next(0, listaQuestoes.Count);
    while (listaQuestoesRespondidas.Contains(numRandomico))
      numRandomico = Random.Shared.Next(0, listaQuestoes.Count);

    listaQuestoesRespondidas.Add(numRandomico);
    QuestaoCorrente = listaQuestoes[numRandomico];
    
    QuestaoCorrente.Desenha();
  }

  //-------------------------------------------------------------------------------------

  public void AdicionaPergunta(Questao questao)
  {
    listaQuestoes.Add(questao);
  }

  //-------------------------------------------------------------------------------------

  public async void VerificaCorreto(int resposta)
  {
    if (QuestaoCorrente!.EstaCorreto(resposta))
    {
      await Task.Delay(1500);
      ProximaQuestao();
    }
  }

  //-------------------------------------------------------------------------------------

  private void CriarPerguntas(Label labelPergunta, Button btnResposta01, Button btnResposta02, Button btnResposta03, Button btnResposta04, Button btnResposta05)
  {
    var questao01 = new Questao();
    questao01.Pergunta = "Qual a linguagem de programação utilizada nas aulas de Desenvolvimento de Sistemas?";
    questao01.Resposta01 = "A- C#";
    questao01.Resposta02 = "B- C++";
    questao01.Resposta03 = "C- JavaScript";
    questao01.Resposta04 = "D- Python";
    questao01.Resposta05 = "E- PHP";
    questao01.RespostaCorreta = 1;
    questao01.Nivel = 0;
    questao01.ConfigurarDesenho(labelPergunta, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
    AdicionaPergunta(questao01);

    var questao02 = new Questao();
    questao02.Pergunta   = "Qual é a framework utilizada nas aulas de Desenvolvimento de Sistemas?";
    questao02.Resposta01 = "A- Microsoft Visual Studio";
    questao02.Resposta02 = "B- Visual Studio Code";
    questao02.Resposta03 = "C- .NET Maui";
    questao02.Resposta04 = "D- Laravel";
    questao02.Resposta05 = "E- Man at Work";
    questao02.RespostaCorreta = 3;
    questao02.Nivel = 0;
    questao02.ConfigurarDesenho(labelPergunta, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
    AdicionaPergunta(questao02);

    var questao03 = new Questao();
    questao03.Pergunta = "Cê têm broxovi?";
    questao03.Resposta01 = "A- Tenho";
    questao03.Resposta02 = "B- Oi?";
    questao03.Resposta03 = "C- Não";
    questao03.Resposta04 = "D- Sim";
    questao03.Resposta05 = "E- Não tenho";
    questao03.RespostaCorreta = 4;
    questao03.Nivel = 0;
    questao03.ConfigurarDesenho(labelPergunta, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
    AdicionaPergunta(questao03);
  }
}