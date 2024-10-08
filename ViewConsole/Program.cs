﻿using Domain.Models;

Geladeira objGeladeira = new();

//Conceito de pilha- Stack

// andar 2 - Hortifrutis
var objItemMaca = new Item() { Descricao = "Maçã", Quantidade = 1, UnidadeQtd = "Unidade", Classificacao = "Fruta", IdItem = 1 };
var objItemBanana = new Item() { Descricao = "Banana", Quantidade = 1, UnidadeQtd = "Cacho", Classificacao = "Fruta", IdItem = 2 };
var objItemLaranja = new Item() { Descricao = "Laranja", Quantidade = 1, UnidadeQtd = "Duzia", Classificacao = "Fruta", IdItem = 3 };

objGeladeira.Item.AdicionarItem(2, 0, 0, objItemMaca);
objGeladeira.Item.AdicionarItem(2, 0, 1, objItemBanana);
objGeladeira.Item.AdicionarItem(2, 1, 2, objItemLaranja);


// andar 1 - Laticínios e Enlatados
var objItemLeite = new Item() { Descricao = "Leite", Quantidade = 1, UnidadeQtd = "Litro", Classificacao = "Laticínio", IdItem = 4 };
var objItemQueijo = new Item() { Descricao = "Queijo", Quantidade = 1, UnidadeQtd = "Unidade", Classificacao = "Laticínio", IdItem = 5 };
var objItemMilho = new Item() { Descricao = "Milho Enlatado", Quantidade = 1, UnidadeQtd = "Lata", Classificacao = "Enlatado", IdItem = 6 };

objGeladeira.Item.AdicionarItem(1, 0, 0, objItemLeite);
objGeladeira.Item.AdicionarItem(1, 1, 1, objItemQueijo);
objGeladeira.Item.AdicionarItem(1, 1, 2, objItemMilho);

// andar 0 - Charcutaria, Carnes e Ovos
var objItemPresunto = new Item() { Descricao = "Presunto", Quantidade = 100, UnidadeQtd = "Gramas", Classificacao = "Charcutaria", IdItem = 7 };
var objItemOvos = new Item() { Descricao = "Ovos", Quantidade = 1, UnidadeQtd = "Duzia", Classificacao = "Ovo", IdItem = 8 };
var objItemCarne = new Item() { Descricao = "Carne", Quantidade = 1, UnidadeQtd = "Kilo", Classificacao = "Carne", IdItem = 9 };

objGeladeira.Item.AdicionarItem(0, 0, 0, objItemPresunto);
objGeladeira.Item.AdicionarItem(0, 0, 1, objItemOvos);
objGeladeira.Item.AdicionarItem(0, 1, 3, objItemCarne);

// mostrar itens no console
Console.WriteLine(objGeladeira.ImprimeGeladeira());

objGeladeira.Item.RemoverItem(2, 0, 3); 

// Remove um item
objGeladeira.Item.RemoverItem(2, 0, 1); 

// adicona um item numa posicao ocupada 
var objItemPera = new Item() { Descricao = "Pera", Quantidade = 1, UnidadeQtd = "Unidade", Classificacao = "Fruta", IdItem = 10 };

objGeladeira.Item.AdicionarItem(2, 0, 1, objItemPera);

// limpa o container
objGeladeira.Container.LimparContainer(1, 1);

// adiciona varios itens no container
var objItemIogurte = new Item() { Descricao = "Iogurte", Quantidade = 300, UnidadeQtd = "ML", Classificacao = "Laticínio", IdItem = 11 };
var objItemManteiga = new Item() { Descricao = "Manteiga", Quantidade = 300, UnidadeQtd = "Gramas", Classificacao = "Laticínio", IdItem = 12 };
var objItemCafe = new Item() { Descricao = "Café", Quantidade = 100, UnidadeQtd = "Gramas", Classificacao = "Enlatado", IdItem = 13 };

objGeladeira.Item.AddItens(1, 0, new List<Item> { objItemIogurte, objItemManteiga, objItemCafe });

// adiciona itens a mais que a o container pode suportar
var objItemCha = new Item() { Descricao = "Ervilha", Quantidade = 100, UnidadeQtd = "Gramas", Classificacao = "Enlatado", IdItem = 14 };
var objItemMel = new Item() { Descricao = "Mel", Quantidade = 100, UnidadeQtd = "Gramas", Classificacao = "Enlatados", IdItem = 15 };
var objItemPao = new Item() { Descricao = "Pão", Quantidade = 3, UnidadeQtd = "Unidades", Classificacao = "Padaria", IdItem = 16 };
var objItemCeral = new Item() { Descricao = "Cereal", Quantidade = 300, UnidadeQtd = "Gramas", Classificacao = "Elatado", IdItem = 17 };
var objItemGranola = new Item() { Descricao = "Granola", Quantidade = 100, UnidadeQtd = "Gramas", Classificacao = "Enlatado", IdItem = 18 };

objGeladeira.Item.AddItens(1, 0, new List<Item> { objItemCha, objItemMel, objItemPao, objItemCeral, objItemGranola });

// mostra itens no console
Console.WriteLine(objGeladeira.ImprimeGeladeira());