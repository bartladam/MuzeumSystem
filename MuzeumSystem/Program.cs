using MuzeumSystem;

Console.Title = "Muzeum system";

Muzeum muzeum = new Muzeum("National muzeum", "Prague 1",new MuzeumShop(), new SecurityGuard[] {
    new SecurityGuard("Thomas", "Vyer"),
    new SecurityGuard("Alvin", "Bone"),
    new SecurityGuard("Horvath", "Guns")},
    new Guide("Marek", "Hus"),
    new Guide("Bohuslav", "Rany"),
    new Guide("Ludmila", "Pravá"));

muzeum.AddExhibition(new Exhibition("Word of color", Exhibition.Genre.Paintings, 350, 
    new Artwork("Woman dance", "Woman dance and throw colors around her position.\nThis is painting is catching the first woman of africa subculture Mohandu", new DateTime(1400, 6, 5), "none"),
    new Artwork("Statue of kingdom", "Artist Michallangelo create this painting for support all positive communities in the world", new DateTime(1990, 1,1), "Michallangelo")));


muzeum.AddExhibition(new Exhibition("Wild nature", Exhibition.Genre.Nature, 500,
    new Artwork("Elephant", "Prehistoric elephant who is defend by a front attack", new DateTime(1800, 9, 23), "Andares"),
    new Artwork("Monkey", "Monkeys grouping by skills.\nLower monkeys are on the edge and believe, that not be kill by others", new DateTime(1650, 12, 23), "Bujarades"),
    new Artwork("Shark power", "Sharks are very offensive when they feels blood. This artwork shows how fast shark can kill human", new DateTime(2023, 6,12), "Benjamin")));

muzeum.AddExhibition(new Exhibition("Second world war", Exhibition.Genre.History, 400,
    new Artwork("Soldiers", "Soldiers are shaking hand with enemies when they\nlost fight in Maribore", new DateTime(1943, 8, 18), "Fujikes"),
    new Artwork("Winning battle", "Our aliance in 1942 won battle in Alishka", new DateTime(1942, 3, 25), "Heming"),
    new Artwork("Salut", "Wifes soldiers are saluting and praying come back her husband", new DateTime(1944, 1, 9), "Satarin")));

Visitor visitor = new Visitor(muzeum);
visitor.SelectExhibition();
visitor.BuyInMuzeumShop();

Console.WriteLine(muzeum.GuardMuzeum()); 
Console.ReadKey();