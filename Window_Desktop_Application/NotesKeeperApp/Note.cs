namespace NotesKeeperApp
{
    public class Note
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public override string ToString() => Title;
    }
}
