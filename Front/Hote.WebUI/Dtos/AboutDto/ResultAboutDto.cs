namespace Hote.WebUI.Dtos.AboutDto
{
    public class ResultAboutDto //Hem admin tarafında kullanılacak hem de vitrin tarafında kullanılacak
    {
        public int AboutID { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Content { get; set; }
        public int RooomCount { get; set; }
        public int CrewCount { get; set; }
        public int CustomerCount { get; set; }

    }
}
