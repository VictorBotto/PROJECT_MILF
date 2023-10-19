using System;
using System.Collections.Generic;

class Program {

  //Listas "estaticas" e publicas para todo a classe Programa.
    //Forma encontrada para que a lista seja acessivel de forma universal através do programa, assim não seno necessario retornar o valor da lista a partir de cada novo metodo.
  
  public static List<Filme> listaFilmes = new List<Filme>();
  public static List<Serie> listaSeries = new List<Serie>();
  public static List<Jogo> listaJogos = new List<Jogo>();

  //Funcao Main
  
  public static void Main (string[] args) {
    int iniciar = 1;
    bool continuarLoop = true;

    
    //While para poder voltar
    while(iniciar == 1 && continuarLoop){
      
      //tela0 reprodução
      int escolha = tela0();
      
      //Limpar tela
      Console.Clear();
  
      //Escolha tela apos tela0
      if (escolha == 1){
        escolha = tela1();
        Console.Clear();
        //Escolha tela apos tela1
        if (escolha == 1){
          tela1_1();
          Console.Clear();
        }
        //Escolha tela apos tela1
        else if (escolha == 2){
          tela1_2();
          Console.Clear();;
        }
        //Escolha tela apos tela1
        else if (escolha == 3){
          //voltar
          continuarLoop = false;
        }
      }
      //Escolha tela apos tela0
      else if(escolha == 2){
        escolha = tela2();
        Console.Clear();
        //Escolha tela apos tela2
        if (escolha == 1){
          tela2_1();
          Console.Clear();
        }
        //Escolha tela apos tela2
        else if (escolha == 2){
          tela2_2();
          Console.Clear();
        }
        //Escolha tela apos tela2
        else if (escolha == 3){
          //voltar
          continuarLoop = false;
        }
      }
      //Escolha tela apos tela0
      else if(escolha == 3){
        escolha = tela3();
        Console.Clear();
        //Escolha tela apos tela3
        if (escolha == 1){
          tela3_1();
          Console.Clear();
        }
        //Escolha tela apos tela3
        else if (escolha == 2){
          tela3_2();
          Console.Clear();
        }
        //Escolha tela apos tela3
        else if (escolha == 3){
          //voltar
          continuarLoop = false;
        }
      }
      //Mensagem de erro
      else{
        Console.WriteLine("Algo deu errado.");
      }
    }
  } 
  
  static void cabecario(){
    //Cabeçario para as telas
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("                    MIFLS");
    Console.WriteLine("     Minha Lista de Filmes, Series e jogos");
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine();
  }
  
  static int pergunta(){
    //Pergunta frequente para informar as decisões
    Console.WriteLine("Informe a opção desejada:");
    int escolha = int.Parse(Console.ReadLine());
    return escolha; 
  }
  
  //Tela 0
  static int tela0(){
    cabecario();
    //Perguntas  tela0
    Console.WriteLine("1 - Filmes");
    Console.WriteLine("2 - Séries");
    Console.WriteLine("3 - Jogos");
    Console.WriteLine();
    
    int escolha = pergunta();
    return escolha;
  }
  
  //Tela 1
  static int tela1(){
    cabecario();
    //Perguntas  tela1
    Console.WriteLine("                  FILMES");
    Console.WriteLine();
    Console.WriteLine("1 - Ver Lista");
    Console.WriteLine("2 - Adicionar Filme");
    Console.WriteLine("3 - Voltar");
    Console.WriteLine();

    int escolha = pergunta();
    return escolha;
  }
  
  //Tela 1.1
  static void tela1_1(){

    cabecario();

      //For para vasculhar e imprimir todas as instancias e seus atributos na lista
      for(int i=0; i<listaFilmes.Count; i++){
      Filme f = listaFilmes[i];
        Console.WriteLine($"Nome: {f.nome}\nNota: {f.nota}\nCritica:{f.comentario}\nGenero: {f.genero}\n\n");
    }
    Console.WriteLine("Pressione Enter para voltar...");
    Console.ReadLine();
  }
  
  //Tela 1.2
  static void tela1_2(){
    //criar lista
    int loopFilme = 1;
    
    while(loopFilme == 1){
      //tela principal
      cabecario();  

      //Adicionando instancia criada na Lista
      Console.WriteLine("Digite o nome do Filme: ");
      string nomeFilme = Console.ReadLine();
  
      Console.WriteLine("Digite o gênero do Filme: ");
      string generoFilme = Console.ReadLine();
  
      Console.WriteLine("Digite sua nota ao Filme 1-10: ");
      double notaFilme = double.Parse(Console.ReadLine());
  
      Console.WriteLine("Digite sua critica ao Filme: ");
      string criticaFilme = Console.ReadLine();
  
      Console.WriteLine("Deseja adicionar mais um filme? (1- Sim/ 2- Não): ");
      loopFilme = int.Parse(Console.ReadLine());
      
      Filme novoFilme = new Filme (nomeFilme, generoFilme, notaFilme, criticaFilme);

      //Adicionando instancia criada na Lista
      listaFilmes.Add(novoFilme);
      Console.Clear();
    }
  }
  
  //Tela 2
  static int tela2(){
    
    cabecario();
    //Perguntas  tela2
    Console.WriteLine("                  SÉRIES");
    Console.WriteLine();
    Console.WriteLine("1 - Ver Lista");
    Console.WriteLine("2 - Adicionar Série");
    Console.WriteLine("3 - Voltar");
    Console.WriteLine();

    int escolha = pergunta();
    return escolha;
  }
  
  //Tela 2.1
  static void tela2_1(){
    
      cabecario();

        //For para vasculhar e imprimir todas as instancias e seus atributos na lista
        for(int i=0; i<listaSeries.Count; i++){
        Serie s = listaSeries[i];
          Console.WriteLine($"Nome: {s.nome}\nNota: {s.nota}\nCritica:{s.comentario}\nGenero: {s.genero}\n\n");
      }
      Console.WriteLine("Pressione Enter para voltar...");
      Console.ReadLine();
    }

  //Tela 2.2
  static void tela2_2()
  {
    int loopSerie = 1;
    
    while(loopSerie == 1){
      
    //tela principal
    cabecario();  

      //Adicionando instancia criada na Lista
      Console.WriteLine("Digite o nome da Série: ");
      string nomeSerie = Console.ReadLine();
  
      Console.WriteLine("Digite o gênero da Série: ");
      string generoSerie = Console.ReadLine();
  
      Console.WriteLine("Digite sua nota a Série: 1-10: ");
      double notaSerie = double.Parse(Console.ReadLine());
  
      Console.WriteLine("Digite sua critica a Série: ");
      string criticaSerie = Console.ReadLine();
  
      Console.WriteLine("Deseja adicionar mais uma Série:? (1- Sim/ 2- Não): ");
      loopSerie = int.Parse(Console.ReadLine());
  
      Serie novaSerie = new Serie (nomeSerie, generoSerie, notaSerie, criticaSerie);

      //Adicionando instancia criada na Lista
      listaSeries.Add(novaSerie);
      Console.Clear();
    }
  }
  
  //Tela 3
  static int tela3(){
    
    cabecario();
    //Perguntas  tela3
    Console.WriteLine("                   JOGOS");
    Console.WriteLine();
    Console.WriteLine("1 - Ver Lista");
    Console.WriteLine("2 - Adicionar Jogo");
    Console.WriteLine("3 - Voltar");
    Console.WriteLine();

    int escolha = pergunta();
    return escolha;
  }

  //Tela 3.1
  static void tela3_1(){

    cabecario();

    //For para vasculhar e imprimir todas as instancias e seus atributos na lista
    for(int i=0; i<listaJogos.Count; i++){
    Jogo j = listaJogos[i];
      Console.WriteLine($"Nome: {j.nome}\nNota: {j.nota}\nCritica:{j.comentario}\nGenero: {j.genero}\n\n");
    }
    Console.WriteLine("Pressione Enter para voltar...");
    Console.ReadLine();
    }

  //Tela 3.2
  static void tela3_2(){
    //criar lista
    int loopJogo = 1;

    while(loopJogo== 1){
    cabecario();
    
      //Entrada de Dados
      Console.WriteLine("Digite o nome da Jogo: ");
      string nomeJogo = Console.ReadLine();
  
      Console.WriteLine("Digite o gênero da Jogo: ");
      string generoJogo = Console.ReadLine();
  
      Console.WriteLine("Digite sua nota a Jogo: 1-10: ");
      double notaJogo = double.Parse(Console.ReadLine());
  
      Console.WriteLine("Digite sua critica a Jogo: ");
      string criticaJogo = Console.ReadLine();
  
      Console.WriteLine("Deseja adicionar mais uma Jogo:? (1- Sim/ 2- Não): ");
      loopJogo = int.Parse(Console.ReadLine());
  
      Jogo novoJogo = new Jogo (nomeJogo, generoJogo, notaJogo, criticaJogo);
  
      //Adicionando instancia criada na Lista
      listaJogos.Add(novoJogo);
    }
  }
}