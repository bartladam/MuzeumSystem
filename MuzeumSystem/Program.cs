using MuzeumSystem;

Console.Title = "Museum system";

Museum museum = new Museum("National muzeum", "Prague 1",new MuseumShop(), new SecurityGuard[] {
    new SecurityGuard("Thomas", "Vyer"),
    new SecurityGuard("Alvin", "Bone"),
    new SecurityGuard("Horvath", "Guns")},
    new Guide("Marek", "Hus"),
    new Guide("Bohuslav", "Rany"),
    new Guide("Ludmila", "Pravá"));

museum.AddExhibition(new Exhibition("World of color", Exhibition.Genre.Paintings, 350, 
    new Artwork("Woman dance", "In this vibrant artwork, a woman dances with an explosion of colors,\neach hue expressing the intensityof her emotions and movements", new DateTime(2015, 6, 5), "Baerto"),
    new Artwork("Statue of kingdom", "Statue of Kingdom elegantly marries royal blues, shimmering golds,\nand earthy tones, crafting a regal and captivating aura", new DateTime(2016, 1,1), "Michallangelo"),
    new Artwork("Fan of colours", "\"Fan of Colors\" radiates a kaleidoscope of vivid shades,\nweaving a mesmerizing tapestry of hues that ignites the senses.", new DateTime(2018, 12,12), "Zuan"),
    new Artwork("A bottle of distraction", "Captivates with a whirlwind of colors, evoking chaos and intrigue\nin a single artful composition.", new DateTime(2018, 2, 16), "Zuan")));


museum.AddExhibition(new Exhibition("Wild nature", Exhibition.Genre.Nature, 500,
    new Artwork("Elephant", "\"Elephant\" showcases the untamed beauty of the wild, an awe-inspiring creature\nportrayed with strikingauthenticity.", new DateTime(1800, 9, 23), "Andares"),
    new Artwork("Monkey", "\"Monkey\" captures the untamed spirit of the wild, a lively and agile creature in\nits natural habitat.", new DateTime(1650, 12, 23), "Bujarades"),
    new Artwork("Shark power", "Shark Power\" embodies the raw intensity of the wild, with a sleek and\nformidable predator in its element.", new DateTime(2023, 6,12), "Benjamin")));

museum.AddExhibition(new Exhibition("Second world war", Exhibition.Genre.History, 400,
    new Artwork("Soldiers", "Soldiers\" pays homage to the bravery and sacrifice of World War II heroes, depicting\ntheir unwavering resolve amidst the chaos of battle.", new DateTime(1943, 8, 18), "Fujikes"),
    new Artwork("Winning battle", "\"Winning Battle\" embodies the indomitable courage and unity that led to victory\nin the midst of World War II's tumultuous battlefield.", new DateTime(1942, 3, 25), "Heming"),
    new Artwork("Salut", "\"Salut\" captures a poignant moment of camaraderie and resilience during the Second World War,\nwhere soldiers salute their unwavering bond and shared sacrifice.", new DateTime(1944, 1, 9), "Satarin")));

Visitor visitor = new Visitor(museum);
visitor.SelectExhibition();
visitor.BuyInMuzeumShop();

Console.WriteLine(museum.GuardMuzeum()); 
Console.ReadKey();