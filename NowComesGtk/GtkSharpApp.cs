using Gtk;
using Window = Gtk.Window;

public class GtkSharpApp : Window
{
    public GtkSharpApp() : base("PokéWiki")
    {
        Fixed fix = new Fixed();

        SetDefaultSize(800, 500);
        SetPosition(WindowPosition.Center);
        Resizable = false;
        SetIconFromFile("Images/AppIcon - Pokémon.png");

        Image steelScreenBackground = new Image("Images/background_homescreen.png");
        fix.Put(steelScreenBackground, 0, 0);

        DeleteEvent += delegate
        {
            Application.Quit();
        };

        #region Menubar Settings :P // Design and functionality

        VBox vbMb = new VBox(false, 0);

        MenuBar mb = new MenuBar();
        vbMb.PackStart(mb, false, false, 0);

        Menu pokemonsMenu = new Menu();
        MenuItem pokemonsMI = new MenuItem("Pokémons");

        // Water MenuItem:
        MenuItem waterMI = new MenuItem();
        EventBox waterEventBox = new EventBox();
        HBox waterHbox = new HBox(false, 0);
        Label lblWaterText = new Label();
        Image waterImage = new Image();
        lblWaterText.Markup = "<span font_desc='Sans 9'>Água</span>";
        waterImage.Pixbuf = new Gdk.Pixbuf("Images/pokemon_water/WaterIcon.png");
        waterHbox.PackStart(waterImage, false, false, 2);
        waterHbox.PackStart(lblWaterText, false, false, 2);
        waterEventBox.Add(waterHbox);
        waterMI.Child = waterEventBox;
        waterMI.Activated += WaterTypePokemonHomepage;

        #endregion Menubar Settings :P // Design and functionality

        // Pokémons button:
        Button btnPokemonsWater = new Button();
        Image ImagePokemonsWater = new Image("Images/pokemon_water/WaterIcon.png");
        btnPokemonsWater.Image = ImagePokemonsWater;
        btnPokemonsWater.SetSizeRequest(150, 175);
        btnPokemonsWater.Relief = ReliefStyle.None;
        fix.Put(btnPokemonsWater, 250, 50);
        btnPokemonsWater.Clicked += PageWaterTypePokemon;//

        mb.Append(pokemonsMI);
        pokemonsMI.Submenu = pokemonsMenu;
        pokemonsMenu.Append(waterMI);

        fix.Add(vbMb);
        Add(fix);
        ShowAll();
    }

    //Kaua você é gay

    #region Water type screens

    private void WaterTypePokemonHomepage(object sender, EventArgs e)
    {
        Window win = new Window("PokéWiki // Pokémons tipo - Água");
        Fixed fix = new Fixed();

        win.SetDefaultSize(800, 500);
        win.SetPosition(WindowPosition.Center);
        win.Resizable = false;
        win.SetIconFromFile("Images/AppIcon - Pokémon.png");

        Image steelScreenBackground = new Image("Images/pokemon_water/background_pokemonWater_homescreen.png");
        fix.Put(steelScreenBackground, 0, 0);

        // Pokémons button:
        Button btnPokemonsWater = new Button();
        Image ImagePokemonsWater = new Image("Images/pokemon_water/WaterIcon.png");
        btnPokemonsWater.Image = ImagePokemonsWater;
        btnPokemonsWater.SetSizeRequest(150, 175);
        btnPokemonsWater.Relief = ReliefStyle.None;
        fix.Put(btnPokemonsWater, 250, 50);
        btnPokemonsWater.Clicked += PageWaterTypePokemon;//

        // Items button:
        Button btnItemsWater = new Button();
        Image ImageItemsWater = new Image("Images/pokemon_water/WaterIcon.png");
        btnItemsWater.Image = ImageItemsWater;
        btnItemsWater.SetSizeRequest(150, 175);
        btnItemsWater.Relief = ReliefStyle.None;
        fix.Put(btnItemsWater, 425, 50);
        btnItemsWater.Clicked += PageWaterItemsPokemon;
        //////
        // Trainers button:
        Button btnTrainersWater = new Button();
        Image ImageTrainersWater = new Image("Images/pokemon_water/WaterIcon.png");
        btnTrainersWater.Image = ImageTrainersWater;
        btnTrainersWater.SetSizeRequest(150, 175);
        btnTrainersWater.Relief = ReliefStyle.None;
        fix.Put(btnTrainersWater, 600, 50);
        btnTrainersWater.Clicked += PageWaterTrainersPokemon;

        win.Add(fix);
        win.ShowAll();
    }

    private void PageWaterTypePokemon(object sender, EventArgs e)
    {
        Window win = new Window("PokéWiki // Pokémons tipo - Água");
        Fixed fix = new Fixed();

        win.SetDefaultSize(200, 600);
        win.SetPosition(WindowPosition.Center);
        win.Resizable = false;
        win.SetIconFromFile("Images/AppIcon - Pokémon.png");
    }

    private void PageWaterItemsPokemon(object sender, EventArgs e)
    {
        Window win = new Window("PokéWiki // Pokémons tipo - Água");
        Fixed fix = new Fixed();

        win.SetDefaultSize(200, 600);
        win.SetPosition(WindowPosition.Center);
        win.Resizable = false;
        win.SetIconFromFile("Images/AppIcon - Pokémon.png");
    }

    private void PageWaterTrainersPokemon(object sender, EventArgs e)
    {
        Window win = new Window("PokéWiki // Pokémons tipo - Água");
        Fixed fix = new Fixed();

        win.SetDefaultSize(200, 600);
        win.SetPosition(WindowPosition.Center);
        win.Resizable = false;
        win.SetIconFromFile("Images/AppIcon - Pokémon.png");
    }

    #endregion Water type screens

    public static void Main()
    {
        Application.Init();
        new GtkSharpApp();
        Application.Run();
    }
}