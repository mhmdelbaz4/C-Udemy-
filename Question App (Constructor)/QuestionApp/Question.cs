namespace QuestionApp
{
    class Question
    {
        public string? questionText;
        public string? optionA;
        public string? optionB;
        public string? optionC;
        public string? optionD;
        public char correctAnswerLetter;
        static char defaultCorrectAnswerLetter;

        public Question()
        {
            correctAnswerLetter = defaultCorrectAnswerLetter;
        }
        static Question()
        {
            defaultCorrectAnswerLetter = 'X';
        }

        public Question(string questionText)
        {
            correctAnswerLetter = defaultCorrectAnswerLetter;
            this.questionText = questionText;
        }

        public Question(string questionText ,string optionA ,string optionB ,string optionC ,string optionD , char correctAnswerLetter )
        {
            this.questionText = questionText;
            this.optionA = optionA;
            this.optionB = optionB;
            this.optionC = optionC;
            this.optionD = optionD;

            if(correctAnswerLetter == 'A' ||correctAnswerLetter == 'B' ||correctAnswerLetter == 'C' ||correctAnswerLetter == 'D')
            {
                this.correctAnswerLetter = correctAnswerLetter;
            }
            else
            {
                this.correctAnswerLetter = defaultCorrectAnswerLetter;
            }
            

        }

        public bool IsValid()
        {
            int count = 0;
            if( optionA != null)
                count ++;
            if( optionB != null)
            count ++;
            if( optionC != null)
            count ++;
            if( optionD != null)
            count ++;

            if(count >= 2)
                return true;
            else
                return false;
        }
        
    }
}