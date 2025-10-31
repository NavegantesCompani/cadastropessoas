 
 //aqui cria um arquivo filho, para herdar do clientes atributos
 namespace Atividade
 {
    //ao colocar Pessoa_Fisisca: Clientes vc fala pra classe q ela tem pai 
 class Pessoa_Fisica : Clientes
    {
    //essas duas são classes so da filha que depois seram chamadas 
 public string Cpf{get; set;}
 public string Rg { get; set; }

  public virtual void Pagar_Imposto(float v)
 {
 this.Valor = v;
 this.Valor_Imposto = this.Valor* 10 / 100;
 this.Total = this.Valor + this.Valor_Imposto;
 }
 
    }
 }