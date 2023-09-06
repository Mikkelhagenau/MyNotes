Page FirstPage = new Page(MyNotes.VariablesPageOne);

Page SecondPage = new Page(MyNotes.VariablesPageTwo);


Chapter Kapitel1 = new Chapter("Variabler");

Kapitel1.Pages.Add(FirstPage);
Kapitel1.Pages.Add(SecondPage);

Page FirstPageAI = new Page(MyNotes.ArtificialIntelligencePageOne);

Page SecondPageAI = new Page(MyNotes.ArtificialIntelligencePageTwo);



Chapter Kapitel2 = new Chapter("Artificial Intelligence");

Kapitel2.Pages.Add(FirstPageAI);
Kapitel2.Pages.Add(SecondPageAI);


Book mybook = new Book("Haps");
mybook.Chapters.Add(Kapitel1);
mybook.Chapters.Add(Kapitel2);
mybook.Start();





Console.ReadLine();