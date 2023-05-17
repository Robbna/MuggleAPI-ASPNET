using Model.VO;

namespace Model
{
  public class Book
  {
    public int id { get; set; }
    public string? title { get; set; }
    public string? author { get; set; }
    public List<PublishDate>? publish_date { get; set; }
    public List<string>? plot_take_place_years { get; set; }
    public List<BookCover>? book_covers { get; set; }
    public List<int>? characters { get; set; }
  }
}