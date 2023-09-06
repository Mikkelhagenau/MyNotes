Page FirstPageVar = new Page(MyNotes.VariablesPageOne);

Page SecondPageVar = new Page(MyNotes.VariablesPageTwo);


Chapter Kapitel1 = new Chapter("Variabler");

Kapitel1.Pages.Add(FirstPageVar);
Kapitel1.Pages.Add(SecondPageVar);

Page FirstPageAI = new Page(MyNotes.AIPageOne);

Page SecondPageAI = new Page(MyNotes.AIPageTwo);



Chapter Kapitel2 = new Chapter("AI");

Kapitel2.Pages.Add(FirstPageAI);
Kapitel2.Pages.Add(SecondPageAI);


Book mybook = new Book("My programming notes");
mybook.Chapters.Add(Kapitel1);
mybook.Chapters.Add(Kapitel2);
mybook.Start();





Console.ReadLine();