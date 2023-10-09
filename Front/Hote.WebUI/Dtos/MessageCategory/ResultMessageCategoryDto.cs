using Hotel.EntityLayer.Concrete;

namespace Hote.WebUI.Dtos.MessageCategory
{
    public class ResultMessageCategoryDto
    {
        public int MessageCategoryID { get; set; }
        public string MessageCategoryName { get; set; }
        public List<ResultMessageContactDto> Contacs { get; set; }
    }
    public class ResultMessageContactDto
    {
        public int ContacID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public int MessageCategoryID { get; set; }
        //public MessageCategory messageCategory { get; set; }
    }
}
