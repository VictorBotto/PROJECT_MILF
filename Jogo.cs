class Jogo
{
    // Atributos
    public string nome;
    public string comentario;
    public double nota;
    public string genero;

    // Construtor
    public Jogo(string nome, string genero, double nota, string comentario)
    {
      this.nome = nome;
      this.comentario = comentario;
      this.nota = nota;
      this.genero = genero;
    }
}