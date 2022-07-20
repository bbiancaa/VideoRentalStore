using VideoRentalStore.Core.Entities;
using System.Collections.Generic;

namespace VideoRentalStore.Infrastructure.Persistence.Repositories
{
    public class VideoRentalStoreDbContext
    {
        public VideoRentalStoreDbContext()
        {
            Movies = new List<Movie>
            {
                new Movie("Interestelar", "As reservas naturais da Terra estão chegando ao fim e um grupo de astronautas recebe a missão de verificar possíveis planetas para receberem a população mundial, possibilitando a continuação da espécie. Cooper é chamado para liderar o grupo e aceita a missão sabendo que pode nunca mais ver os filhos. Ao lado de Brand, Jenkins e Doyle, ele seguirá em busca de um novo lar.", "Science Fiction"),
                new Movie("Star Wars: Episódio IV – Uma Nova Esperança", "A princesa Leia é mantida refém pelas forças imperiais comandadas por Darth Vader. Luke Skywalker e o capitão Han Solo precisam libertá-la e restaurar a liberdade e a justiça na galáxia.", "Science Fiction")
            };

            Costumers = new List<Costumer>
            {
                new Costumer("Bianca Gabriela Fritsch", "000000000000", "Rua 00, Bairro 00, 00"),
            };

        }
        public List <Movie> Movies { get; set; }
        public List <Costumer> Costumers { get; set; }
    }
}