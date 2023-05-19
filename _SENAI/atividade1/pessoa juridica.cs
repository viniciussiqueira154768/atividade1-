namespace atividade1 
{
    class Pessoa_Juridica : Clientes 
    {
        public string CNPJ {get; set;}
        public string IE {get; set;}
        
        public override void pagar_imposto (float v)
         {  
         
            this.valor = v;
            this.valor_imposto = this.valor * 20/100;
            this.total = this.total + this.valor_imposto;
         }
    }
}