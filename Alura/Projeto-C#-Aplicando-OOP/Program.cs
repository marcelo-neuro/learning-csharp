using ProjetoMusica.classes;




Banda boa = new Banda("Bôa");


Album albumBoa = new Album("The Race of a Thousand Camels", new List<Musica>() {
    new Musica("Fool", boa, 5, true),
    new Musica("Rain", boa, 4, true),
    new Musica("Deeply", boa, 4, true),
    new Musica("Twilight", boa, 4, true),
    new Musica("Elephant", boa, 4, true),
    new Musica("One Day", boa, 3, true),
    new Musica("Duvet", boa, 3, true),
    new Musica("Scoring", boa, 4, true),
    new Musica("Welcome", boa, 5, true)
});

boa.AdicionarAlbum(albumBoa);
//boa.ExibirDiscografia();

var ep6 = new Episodio("Comidas", 6, 180);
ep6.AdicionarConvidado("Gemaplys");
ep6.AdicionarConvidado("Jean");
ep6.AdicionarConvidado("Saiko");

var ep4 = new Episodio("Jogos", 4, 180);
ep4.AdicionarConvidado("Gemaplys");
ep4.AdicionarConvidado("Jean");
ep4.AdicionarConvidado("Saiko");

var podcast = new Podcast("Fish Ball Cast", "Gemaplys");
podcast.AdicionarEpisodio(ep6);
podcast.AdicionarEpisodio(ep4);

podcast.ExibirDetalhes();