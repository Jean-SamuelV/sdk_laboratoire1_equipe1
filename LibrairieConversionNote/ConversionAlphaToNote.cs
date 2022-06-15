namespace LibrairieConversionNote
{
    public class ConversionAlphaToNote
    {
        public string _note;

        public ConversionAlphaToNote(string note)
        {
            _note = note;
        }

        public string transformer(string noteanglaise)
        {
            string input = noteanglaise;
            List<string> noteenglish = new List<string>() { "A", "B", "C", "D", "E", "F", "G" };
            List<string> notefrench = new List<string>() { "La", "Si", "Do", "Re", "Mi", "Fa", "Sol" };

            for (int i = 0; i < noteenglish.Count; i++)
            {
                if (input == noteenglish[i])
                {
                    return notefrench[i];
                }
            }
            return "Note not found! A to G only.";
        }

    }
}