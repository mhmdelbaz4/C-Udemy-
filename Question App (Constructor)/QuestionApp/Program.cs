using QuestionApp;
using System;

Question question1 = new Question();
Question question2 = new Question("Where's Cairo ?");
Question question3 = new Question("what's the currency of Saudia Arabia ?" ,"A.Dollar" ,"B.Pound" ,"C.Ryal" ,"D.Robyl" ,'C');
Question question4 = new Question()
{
    questionText = "Where's India",
    optionA = "A. Europe",
    optionB = "B .Africa",
    optionC = "C. Asia",
    optionD = "D. North America",
};

System.Console.WriteLine("************Question1****************");
System.Console.WriteLine(question1.questionText);
System.Console.WriteLine(question1.optionA);
System.Console.WriteLine(question1.optionB);
System.Console.WriteLine(question1.optionC);
System.Console.WriteLine(question1.optionD);
System.Console.WriteLine($"Correct answer {question1.correctAnswerLetter}");
System.Console.WriteLine("*************************************");

System.Console.WriteLine("************Question2****************");
System.Console.WriteLine(question2.questionText);
System.Console.WriteLine(question2.optionA);
System.Console.WriteLine(question2.optionB);
System.Console.WriteLine(question2.optionC);
System.Console.WriteLine(question2.optionD);
System.Console.WriteLine($"Correct answer {question2.correctAnswerLetter}");
System.Console.WriteLine("*************************************");

System.Console.WriteLine("************Question3****************");
System.Console.WriteLine(question3.questionText);
System.Console.WriteLine(question3.optionA);
System.Console.WriteLine(question3.optionB);
System.Console.WriteLine(question3.optionC);
System.Console.WriteLine(question3.optionD);
System.Console.WriteLine($"Correct answer {question3.correctAnswerLetter}");
System.Console.WriteLine("*************************************");

System.Console.WriteLine("************Question4****************");
System.Console.WriteLine(question4.questionText);
System.Console.WriteLine(question4.optionA);
System.Console.WriteLine(question4.optionB);
System.Console.WriteLine(question4.optionC);
System.Console.WriteLine(question4.optionD);
System.Console.WriteLine($"Correct answer {question4.correctAnswerLetter}");
System.Console.WriteLine("*************************************");

