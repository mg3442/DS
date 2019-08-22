using DrinkAndGo.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace DrinkAndGo.Data
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context =
                applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Drinks.Any())
            {
                context.AddRange
                (
                    new Drink {
                        Name = "Beer",
                        Price = 3.95M, ShortDescription = "The most widely consumed alcohol",
                        LongDescription = "Beer is the world's oldest and most widely consumed alcoholic drink; it is the third most popular drink overall, after water and tea. The production of beer is called brewing, which involves the fermentation of starches, mainly derived from cereal grains—most commonly malted barley, although wheat, maize (corn), and rice are widely used. Most beer is flavoured with hops, which add bitterness and act as a natural preservative, though other flavourings such as herbs or fruit may occasionally be included. The fermentation process causes a natural carbonation effect, although this is often removed during processing, and replaced with forced carbonation. Some of humanity's earliest known writings refer to the production and distribution of beer: the Code of Hammurabi included laws regulating beer and beer parlours",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "beerL.jpg",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "beerS.jpg"
                    },
                    new Drink {
                        Name = "Rum & Coke",
                        Price = 12.55M, ShortDescription = "Cocktail made of cola, lime and rum",
                        LongDescription = "The world's second most popular drink was born in a collision between the United States and Spain. It happened during the Spanish-American War at the turn of the century when Teddy Roosevelt, the Rough Riders, and Americans in large numbers arrived in Cuba. One afternoon, a group of off-duty soldiers from the U.S. Signal Corps were gathered in a bar in Old Havana. Fausto Rodriguez, a young messenger, later recalled that Captain Russell came in and ordered Bacardi (Gold) rum and Coca-Cola on ice with a wedge of lime. The captain drank the concoction with such pleasure that it sparked the interest of the soldiers around him. They had the bartender prepare a round of the captain's drink for them. The Bacardi rum and Coke was an instant hit. As it does to this day, the drink united the crowd in a spirit of fun and good fellowship. When they ordered another round, one soldier suggested that they toast ¡Por Cuba Libre! in celebration of the newly freed Cuba",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "rumL.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "rumS.jpg"
                    },
                    new Drink {
                        Name = "Tequila ",
                        Price = 14.35M, ShortDescription = "Beverage made from the blue agave plant",
                        LongDescription = "Tequila (Spanish About this sound [teˈkila] ) is a regionally specific name for a distilled beverage made from the blue agave plant, primarily in the area surrounding the city of Tequila, 65 km (40 mi) northwest of Guadalajara, and in the highlands (Los Altos) of the central western Mexican state of Jalisco. Although tequila is similar to mezcal, modern tequila differs somewhat in the method of its production, in the use of only blue agave plants, as well as in its regional specificity. Tequila is commonly served neat in Mexico and as a shot with salt and lime across the rest of the world.The red volcanic soil in the surrounding region is particularly well suited to the growing of the blue agave, and more than 300 million of the plants are harvested there each year. Agave tequila grows differently depending on the region. Blue agaves grown in the highlands Los Altos region are larger in size and sweeter in aroma and taste. Agaves harvested in the lowlands, on the other hand, have a more herbaceous fragrance and flavor",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "teqL.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "teqS.jpg"

                    },
                    new Drink
                    {
                        Name = "Wine ",
                        Price = 16.75M,
                        ShortDescription = "A very elegant alcoholic drink",
                        LongDescription = "Wine is an alcoholic drink made from fermented grapes. The earliest archaeological and archaeobotanical evidence for grape wine and viniculture, dating to 6000–5800 BC was found on the territory of modern Georgia. Both archaeological and genetic evidence suggest that the earliest production of wine elsewhere was relatively later, likely having taken place in the Southern Caucasus (which encompasses Armenia, Georgia and Azerbaijan), or the West Asian region between Eastern Turkey, and northern Iran. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "wineL.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "wineS.jpg"
                    },
                    new Drink
                    {
                        Name = "Margarita",
                        Price = 17.85M,
                        ShortDescription = "A cocktail with sec, tequila and lime",
                        Category = Categories["Alcoholic"],
                        LongDescription = "Margarita is a cocktail consisting of tequila, orange liqueur, and lime juice often served with salt on the rim of the glass. The drink is served shaken with ice (on the rocks), blended with ice (frozen margarita), or without ice (straight up). Although it has become acceptable to serve a margarita in a wide variety of glass types, ranging from cocktail and wine glasses to pint glasses and even large schooners, the drink is traditionally served in the eponymous margarita glass, a stepped-diameter variant of a cocktail glass or champagne coupe",
                        ImageUrl = "margaritaL.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "margaritaS.jpg"
                    },
                    new Drink {
                        Name = "Whiskey with ice",
                        Price = 15.85M, ShortDescription = "The best way to taste whiskey",
                        LongDescription = "Whiskey or whisky is a type of distilled alcoholic beverage made from fermented grain mash. Various grains (which may be malted) are used for different varieties, including barley, corn, rye, and wheat. Whisky is typically aged in wooden casks, generally made of charred white oak. Whisky is a strictly regulated spirit worldwide with many classes and types. The typical unifying characteristics of the different classes and types are the fermentation of grains, distillation, and aging in wooden barrels",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "whiskeyL.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "whiskeyS.jpg"
                    },
                    new Drink
                    {
                        Name = "Jägermeister",
                        Price = 15.45M,
                        ShortDescription = "A German digestif made with 56 herbs",
                        LongDescription = "Jägermeister (/ˈjeɪɡərˌmaɪstər/, YAY-gər-my-stər, German: [ˈjɛːɡɐˌmaɪstɐ], stylized Jägermeiſter) is a digestif made with 56 herbs and spices at a strength of 35% alcohol by volume (61 degrees proof, or US 70 proof). It is the flagship product of Mast-Jägermeister SE, headquartered in Wolfenbüttel, Germany",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "jagerL.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "jagerS.jpg"
                    }, 
                    new Drink
                    {
                        Name = "Champagne",
                        Price = 15.05M,
                        ShortDescription = "That is how sparkling wine can be called",
                        LongDescription = "Champagne (/ʃæmˈpeɪn/, French: [ʃɑ̃paɲ]) is sparkling wine. Many people use the term Champagne as a generic term for sparkling wine but in some countries, it is illegal to label any product Champagne unless it both comes from the Champagne region and is produced under the rules of the appellation. Specifically, in the EU countries, only sparkling wine which comes from the Champagne region of France can be legally labelled as Champagne",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "champL.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "champS.jpg"
                    },
                    new Drink
                    {
                        Name = "Piña colada ",
                        Price = 15.55M,
                        ShortDescription = "A sweet cocktail made with rum",
                        LongDescription = "The piña colada (/ˌpiːnjə koʊˈlɑːdə, -nə-, -kə-/; Spanish: piña [ˈpiɲa], pineapple, and colada [koˈlaða], strained) is a sweet cocktail made with rum, cream of coconut or coconut milk, and pineapple juice, usually served either blended or shaken with ice. It may be garnished with either a pineapple wedge, maraschino cherry, or both. There are two versions of the drink's origin, but both say it originated in Puerto Rico",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "pinacolL.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "pinacolS.jpg"
                    },
                    new Drink
                    {
                        Name = "White Russian",
                        Price = 13.82M,
                        ShortDescription = "A cocktail made with vodka",
                        LongDescription = "A White Russian is a cocktail made with vodka, coffee liqueur (e.g., Kahlúa or Tia Maria) and cream served with ice in an Old Fashioned glass. Often milk or half and half will be used as an alternative to cream",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "wrL.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "wrS.jpg"
                    },
                    new Drink
                    {
                        Name = "Long Island Iced Tea",
                        Price = 14.91M,
                        ShortDescription = "A mixed drink made with tequila",
                        LongDescription = "A Long Island Iced Tea is a type of alcoholic mixed drink typically made with vodka, tequila, light rum, triple sec, gin, and a splash of cola, which gives the drink the same amber hue as its namesake. A popular version mixes equal parts vodka, gin, rum, triple sec, with ​1 1⁄2 parts sour mix and a splash of cola. Lastly, it is decorated with the lemon and straw, after stirring with bar spoon smoothly",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "Long IslandL.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "Long IslandS.jpg"
                    },
                    new Drink
                    {
                        Name = "Vodka",
                        Price = 12.51M,
                        ShortDescription = "A distilled beverage with water and ethanol",
                        LongDescription = "Vodka (Polish: wódka [ˈvutka], Russian: водка [ˈvotkə]) is a clear distilled alcoholic beverage originating from Poland and Russia, composed primarily of water and ethanol, but sometimes with traces of impurities and flavorings. Traditionally it is made by distilling the liquid from cereal grains or potatoes that have been fermented, although some modern brands use fruits or sugar as the base",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "vodkaL.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "vodkaS.jpg"
                    },
                    new Drink
                    {
                        Name = "Gin and tonic",
                        Price = 14.12M,
                        ShortDescription = "Made with gin and tonic water poured over ice",
                        LongDescription = "A gin and tonic is a highball cocktail made with gin and tonic water poured over ice. It is usually garnished with a slice or wedge of lime. The amount of gin varies according to taste. Suggested ratios of gin to tonic are between 1:1 and 1:3. The drink is a particular phenomenon as its taste is quite different from the taste of its constituent liquids which are rather bitter. The chemical structures of both ingredients are of a similar molecular shape and attract each other, shielding the bitter taste",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "gatL.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "gatS.jpg"
                    },
                    new Drink
                    {
                        Name = "Cosmopolitan",
                        Price = 15.22M,
                        ShortDescription = "Made with vodka, triple sec, cranberry juice",
                        LongDescription = "A cosmopolitan, or informally a cosmo, is a cocktail made with vodka, triple sec, cranberry juice, and freshly squeezed or sweetened lime juice.The International Bartenders Association recipe is based on vodka citron, lemon-flavored vodka. The cosmopolitan is a relative of cranberry coolers like the Cape Codder",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "cosmoL.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "cosmoS.jpg"
                    },
                    new Drink {
                        Name = "Tea",
                        Price = 2.15M,
                        ShortDescription = "Made by leaves of the tea plant in hot water",
                        LongDescription = "Tea is an aromatic beverage commonly prepared by pouring hot or boiling water over cured leaves of the Camellia sinensis, an evergreen shrub (bush) native to East Asia. After water, it is the most widely consumed drink in the world. There are many different types of tea; some, like Darjeeling and Chinese greens, have a cooling, slightly bitter, and astringent flavour, while others have vastly different profiles that include sweet, nutty, floral or grassy notes",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "teaL.jpg",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "teaS.jpg"
                    },
                    new Drink
                    {
                        Name = "Water ",
                        Price = 0.84M,
                        ShortDescription = " It makes up more than half of your body weight",
                        LongDescription = "Water is a transparent, tasteless, odorless, and nearly colorless chemical substance, which is the main constituent of Earth's streams, lakes, and oceans, and the fluids of most living organisms. It is vital for all known forms of life, even though it provides no calories or organic nutrients. Its chemical formula is H2O, meaning that each of its molecules contains one oxygen and two hydrogen atoms, connected by covalent bonds",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "waterL.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "waterS.jpg"
                    },
                    new Drink
                    {
                        Name = "Coffee ",
                        Price = 2.55M,
                        ShortDescription = " A beverage prepared from coffee beans",
                        LongDescription = "Coffee is a brewed drink prepared from roasted coffee beans, the seeds of berries from certain Coffea species. The genus Coffea is native to tropical Africa (specifically having its origin in Ethiopia and Sudan) and Madagascar, the Comoros, Mauritius, and Réunion in the Indian Ocean",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "coffeeL.jpg",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "coffeeS.jpg"
                    },
                    new Drink
                    {
                        Name = "Kvass",
                        Price = 3.31M,
                        ShortDescription = "A very refreshing Eastern European beverage",
                        LongDescription = "Kvass is a traditional fermented Slavic and Baltic beverage commonly made from rye bread, which is known in many Central and Eastern European and Asian countries as 'black bread'. The colour of the bread used contributes to the colour of the resulting drink. Kvass is classified as a non-alcoholic drink because the alcohol content from fermentation is typically low (0.5–1.0%). It may be flavoured with fruits such as strawberries and raisins, or with herbs such as mint",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "kvassL.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "kvassS.jpg"
                    },
                    new Drink
                    {
                        Name = "Juice ",
                        Price = 2.44M,
                        ShortDescription = "Naturally contained in fruit or vegetable tissue",
                        LongDescription = "Juice is a drink made from the extraction or pressing of the natural liquid contained in fruit and vegetables. It can also refer to liquids that are flavored with concentrate or other biological food sources, such as meat or seafood, such as clam juice. Juice is commonly consumed as a beverage or used as an ingredient or flavoring in foods or other beverages, as for smoothies. Juice emerged as a popular beverage choice after the development of pasteurization methods enabled its preservation without using fermentation (which is used in wine production)",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "juiceL.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "juiceS.jpg"
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Alcoholic", Description="All alcoholic drinks" },
                        new Category { CategoryName = "Non-alcoholic", Description="All non-alcoholic drinks" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
