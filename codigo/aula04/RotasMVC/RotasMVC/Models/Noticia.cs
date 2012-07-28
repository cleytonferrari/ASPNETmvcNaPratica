using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace RotasMVC.Models
{
    public class Noticia
    {
        public int NoticiaId { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string Categoria { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        public IEnumerable<Noticia> TodasAsNoticias()
        {
            var retorno = new Collection<Noticia>
                {
                    new Noticia
                        {
                            NoticiaId = 1,
                            Categoria = "Esportes",
                            Titulo = "Felipe Massa ganha F1",
                            Conteudo = "Numa tarde de chuva Felipe Massa ganha F1 no Brasil...",
                            Data = new DateTime(2012,7,5)
                        },
                    new Noticia
                        {
                            NoticiaId = 2,
                            Categoria = "Política",
                            Titulo = "Presidente assina convênios",
                            Conteudo = "Durante reunião o presidente Ismael Freitas assinou os convênios...",
                            Data = new DateTime(2012,7,3)
                        },
                    new Noticia
                        {
                            NoticiaId = 3,
                            Categoria = "Política",
                            Titulo = "Vereador é eleito pela 4ª vez",
                            Conteudo = "Vereador Fabio Pratt é eleito pela quarta vez...",
                            Data = new DateTime(2012,7,20)
                        },
                    new Noticia
                        {
                            NoticiaId = 4,
                            Categoria = "Esportes",
                            Titulo = "O tão sonhado titulo chegou",
                            Conteudo = "Em um jogo que levou os torcedores ao delirio...",
                            Data = new DateTime(2012,7,18)
                        },
                    new Noticia
                        {
                            NoticiaId = 5,
                            Categoria = "Humor",
                            Titulo = "O Comediante Anderson Renato fará shou hoje",
                            Conteudo = "O comediante mais engraçados dos comentários do Youtube fará show...",
                            Data = new DateTime(2012,7,14)
                        },
                    new Noticia
                        {
                            NoticiaId = 6,
                            Categoria = "Policial",
                            Titulo = "Tenente coronel Lucas Farias Santos assume o controle",
                            Conteudo = "Durante a retomada do morro o tenente coronel disse...",
                            Data = new DateTime(2012,7,19)
                        },
                    new Noticia
                        {
                            NoticiaId = 7,
                            Categoria = "Esportes",
                            Titulo = "Atacante do Barcelona faz 4 gols",
                            Conteudo = "O atacante Lucas Farias Santos Messi, fez 4 gols e decidiu o titulo...",
                            Data = new DateTime(2012,7,8)
                        }
                };
            return retorno;
        }
    }
}