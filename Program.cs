Page FirstPage = new Page(MyNotes.VariablesPageOne);

Page SecondPage = new Page(MyNotes.VariablesPageTwo);

Page ThirdPage  = new Page(MyNotes.VariablesPageThree);

Page FourthPage = new Page(MyNotes.VariablesPageFour);

Chapter Kapitel1 = new Chapter("Variabler");

Kapitel1.Pages.Add(FirstPage);
Kapitel1.Pages.Add(SecondPage);
Kapitel1.Pages.Add(ThirdPage);
Kapitel1.Pages.Add(FourthPage);


Book mybook = new Book("Haps");
mybook.Chapters.Add(Kapitel1);
mybook.Start();





Console.ReadLine();