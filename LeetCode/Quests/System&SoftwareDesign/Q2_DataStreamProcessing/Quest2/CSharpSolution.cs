public class StreamChecker {

    private string[] Words;
    public List<StreamedWord> StreamedWords = new List<StreamedWord>();

    public StreamChecker(string[] words) {
        Words = words;
    }
    
    public bool Query(char letter) {
        var hasValidWord = false;

        for(var i = StreamedWords.Count - 1; i >= 0; i--)
        {
            if(letter == StreamedWords[i].Word[StreamedWords[i].Position])
            {
                StreamedWords[i].Position++;
                if(StreamedWords[i].Position == StreamedWords[i].Word.Length)
                {
                    hasValidWord = true;
                    StreamedWords.RemoveAt(i);
                }
            }
            else
            {
                StreamedWords.RemoveAt(i);
            }
        }

        foreach(var word in Words)
        {
            if(word[0] == letter)
            {
                if(word.Length == 1)
                {
                    hasValidWord = true;
                    continue;
                }
                StreamedWords.Add(new StreamedWord {Word = word, Position = 1});
            }
        }

        return hasValidWord;
    }
}

public class StreamedWord
{
    public string Word {get;set;}
    public int Position {get;set;}
}

/**
 * Your StreamChecker object will be instantiated and called as such:
 * StreamChecker obj = new StreamChecker(words);
 * bool param_1 = obj.Query(letter);
 */