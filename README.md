# TesteBack
Esse é uma RestAPI ASP.NET5 com dois metodos expostos.

AddItemLista {
  É passado como parametro uma lista de pesquisa, que é armazenado no arquivo bd.json
  
  PesquisaModelView{
    moeda: string,
    data_inicio: string,
    data_fim: string
  }

  !IMPORTANTE! : se data_inicio for maior que data_fim o item não é colocado na lista por questão de padronizaçãoe e validação. 
}
  
GetItemLista {
  É um metodo que retorna e exclui lógicamente o ultimo item adicionado na lista
  
  PesquisaModelView{
    moeda: string,
    data_inicio: string,
    data_fim: string 
  }
}
  
O modelo de banco utilizado é um arquivo bd.json, que se excluido ou apagado, é gerado automaticamente quando usar o metodo AddItemLista.
  
Att: Matheus Sleutjes
